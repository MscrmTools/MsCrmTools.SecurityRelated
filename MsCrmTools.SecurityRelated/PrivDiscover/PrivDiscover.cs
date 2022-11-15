// PROJECT : MsCrmTools.RolePrivilegeAnalyzer
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using MsCrmTools.PrivDiscover.AppCode;
using MsCrmTools.SecurityRelated.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MsCrmTools.PrivDiscover
{
    public partial class MainControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        #region Variables

        private List<EntityMetadata> entities;
        private Thread fillPrivThread;
        private List<ListViewGroup> lvgList = new List<ListViewGroup>();
        private List<ListViewItem> lviList = new List<ListViewItem>();

        /// <summary>
        /// List of privileges for the current organization
        /// </summary>
        private DataCollection<Entity> privileges;

        /// <summary>
        /// List of security roles for the current organization
        /// </summary>
        private List<SecurityRole> roles;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class <see cref="MainControl"/>
        /// </summary>
        public MainControl()
        {
            InitializeComponent();

            pnlSeparator.Height = 1;
            btnAdd.Top = panel1.Top + panel1.Height + 10;
        }

        #endregion Constructor

        #region Methods

        private void BtnAddClick(object sender, EventArgs e)
        {
            if (lvPrivileges.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in lvPrivileges.SelectedItems)
            {
                var existingPriv = lvSelectedPrivileges.Items.Cast<ListViewItem>().FirstOrDefault(selectedItem =>
                    ((Privilege)selectedItem.Tag).Id == ((Entity)item.Tag).Id);

                if (existingPriv != null)
                {
                    lvSelectedPrivileges.Items.Remove(existingPriv);
                }

                var privilege = (Entity)item.Tag;
                string groupName;
                var group = (from entity in entities
                             where entity.Privileges.Any(p => p.PrivilegeId == privilege.Id)
                             select new { entity.LogicalName, entity.DisplayName.UserLocalizedLabel.Label }).FirstOrDefault();

                if (group == null)
                {
                    if (privilege["name"].ToString().EndsWith("Entity"))
                        groupName = "Entity";
                    else if (privilege["name"].ToString().EndsWith("Attribute"))
                        groupName = "Attribute";
                    else if (privilege["name"].ToString().EndsWith("Relationship"))
                        groupName = "Relationship";
                    else if (privilege["name"].ToString().EndsWith("OptionSet"))
                        groupName = "OptionSet";
                    else
                        groupName = "_Common";
                }
                else
                {
                    if (group.LogicalName == "customeraddress")
                        groupName =
                            entities.First(x => x.LogicalName == "account").DisplayName.UserLocalizedLabel.Label;
                    else if (group.LogicalName == "email" || group.LogicalName == "task"
                        || group.LogicalName == "letter" || group.LogicalName == "phonecall"
                        || group.LogicalName == "appointment" || group.LogicalName == "serviceappointment"
                        || group.LogicalName == "campaignresponse" || group.LogicalName == "fax")
                        groupName =
                            entities.First(x => x.LogicalName == "activitypointer").DisplayName.UserLocalizedLabel.Label;
                    else
                        groupName = group.Label;
                }

                if (lvSelectedPrivileges.Groups[groupName] == null)
                {
                    lvSelectedPrivileges.Groups.Add(groupName, groupName);
                }

                var priv = new Privilege { Id = privilege.Id, Name = privilege.GetAttributeValue<string>("name"), IsAnyDepth = true };

                if (rdbLevelAny.Checked)
                {
                    priv.IsAnyDepth = true;
                    priv.IsNoDepth = true;
                }
                else if (rdbLevelNone.Checked)
                {
                    priv.IsAnyDepth = false;
                    priv.IsNoDepth = true;
                }
                else if (rdbLevelUser.Checked)
                {
                    priv.Depth = PrivilegeDepth.Basic;
                    priv.IsAnyDepth = false;
                }
                else if (rdbLevelDiv.Checked)
                {
                    priv.Depth = PrivilegeDepth.Local;
                    priv.IsAnyDepth = false;
                }
                else if (rdbLevelSubDiv.Checked)
                {
                    priv.Depth = PrivilegeDepth.Deep;
                    priv.IsAnyDepth = false;
                }
                else if (rdbLevelOrg.Checked)
                {
                    priv.Depth = PrivilegeDepth.Global;
                    priv.IsAnyDepth = false;
                }
                else
                {
                    return;
                }

                var clonedItem = (ListViewItem)item.Clone();
                //clonedItem.SubItems.Add(comboBox1.SelectedItem?.ToString());
                clonedItem.SubItems.Add(pnlPrivOperators.Controls.OfType<RadioButton>().First(rb => rb.Checked).Text);
                clonedItem.SubItems.Add(priv.IsAnyDepth ? "Any" : priv.IsNoDepth ? "None" : GetPrivilegeDepthLabel(priv.Depth));
                clonedItem.Tag = priv;
                clonedItem.Group =
                    groupName != null
                        ? lvSelectedPrivileges.Groups[groupName]
                        : lvSelectedPrivileges.Groups["_Common"];

                lvSelectedPrivileges.Items.Add(clonedItem);
            }

            ((ListViewGroupSorter)lvSelectedPrivileges).SortGroups(true);
            lvSelectedPrivileges.Sort();
        }

        private void BtnRemoveClick(object sender, EventArgs e)
        {
            if (lvSelectedPrivileges.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in lvSelectedPrivileges.SelectedItems)
            {
                lvSelectedPrivileges.Items.Remove(item);
            }
        }

        private string GetPrivilegeDepthLabel(PrivilegeDepth privilegeDepth)
        {
            switch (privilegeDepth)
            {
                case PrivilegeDepth.Basic:
                    return "User";

                case PrivilegeDepth.Local:
                    return "Division";

                case PrivilegeDepth.Deep:
                    return "Division and sub-Divisions";

                case PrivilegeDepth.Global:
                    return "Organization";

                default:
                    throw new Exception("Not supported!");
            }
        }

        private void LoadRolesAndPrivs(bool fromSolution)
        {
            lvPrivileges.Items.Clear();
            lvSelectedPrivileges.Items.Clear();
            lvRoles.Items.Clear();
            lviList.Clear();
            lvgList.Clear();

            List<Entity> solutions = new List<Entity>();

            if (fromSolution)
            {
                var dialog = new SolutionPicker(Service);
                if (dialog.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                solutions.AddRange(dialog.SelectedSolutions);
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Retrieving roles...",
                AsyncArgument = null,
                Work = (bw, e) =>
                {
                    var rManager = new RolesManager(Service);
                    roles = rManager.GetRoles();

                    bw.ReportProgress(0, "Retrieving privileges...");

                    privileges = rManager.GetPrivileges();

                    bw.ReportProgress(0, "Retrieving entities privileges...");

                    var mdManager = new MetadataManager(Service);
                    entities = mdManager.GetEntitiesWithPrivileges(solutions);

                    bw.ReportProgress(0, "Preparing UI list items...");

                    ComputeListItems();
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error != null)
                    {
                        MessageBox.Show(this, "An error occured: " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        fillPrivThread = new Thread(DoWork);
                        fillPrivThread.Start();
                    }

                    txtSearch.Enabled = true;
                },
                ProgressChanged = e => { SetWorkingMessage(e.UserState.ToString()); }
            });
        }

        #endregion Methods

        public string HelpUrl => "https://github.com/MscrmTools/MsCrmTools.SecurityRelated/wiki";

        public string RepositoryName => "MsCrmTools.SecurityRelated";

        public string UserName => "MscrmTools";

        private string AddSpacesToSentence(Guid privilegeId, string text, bool preserveAcronyms)
        {
            var emd = entities.FirstOrDefault(e => e.Privileges.Any(p => p.PrivilegeId.Equals(privilegeId)));
            if (emd != null)
            {
                var name = emd.DisplayName?.UserLocalizedLabel?.Label;
                if (text.StartsWith("Write")) return $"Write {name}";
                if (text.StartsWith("Create")) return $"Create {name}";
                if (text.StartsWith("Read")) return $"Read {name}";
                if (text.StartsWith("Delete")) return $"Delete {name}";
                if (text.StartsWith("Assign")) return $"Assign {name}";
                if (text.StartsWith("Share")) return $"Share {name}";
                if (text.StartsWith("AppendTo")) return $"Append to {name}";
                if (text.StartsWith("Append")) return $"Append {name}";
            }

            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;
            StringBuilder newText = new StringBuilder(text.Length * 2);
            newText.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    if ((text[i - 1] != ' ' && !char.IsUpper(text[i - 1])) ||
                        (preserveAcronyms && char.IsUpper(text[i - 1]) &&
                         i < text.Length - 1 && !char.IsUpper(text[i + 1])))
                        newText.Append(' ');
                newText.Append(text[i]);
            }
            return newText.ToString();
        }

        private void BtnDisplayRolesClick(object sender, EventArgs e)
        {
            lvRoles.Items.Clear();
            lvRoles.Columns.Clear();
            lvRoles.Columns.Add(new ColumnHeader { Name = "Name", Text = @"Name", Width = 200 });

            if (lvSelectedPrivileges.Items.Count == 0)
                return;

            var lviList = new List<ListViewItem>();

            foreach (SecurityRole role in roles.OrderBy(r => r.Name))
            {
                bool matchPrivileges = false;
                Dictionary<string, string> privDepths = new Dictionary<string, string>();

                foreach (ListViewItem item in lvSelectedPrivileges.Items)
                {
                    string foundDepth = string.Empty;
                    var currentPrivilege = (Privilege)item.Tag;
                    var conditionOperator = item.SubItems[1].Text;

                    if (conditionOperator == "Equals")
                    {
                        if (currentPrivilege.IsNoDepth)
                        {
                            matchPrivileges = role.Privileges.All(p => p.Id != currentPrivilege.Id);
                        }

                        if (currentPrivilege.IsAnyDepth)
                        {
                            var privilegeFound = role.Privileges.FirstOrDefault(p => p.Id == currentPrivilege.Id);
                            if (privilegeFound != null)
                            {
                                matchPrivileges = true;
                                foundDepth = privilegeFound.Depth.ToString();
                            }
                        }

                        if (!currentPrivilege.IsNoDepth && !currentPrivilege.IsAnyDepth)
                        {
                            matchPrivileges = role.Privileges.Any(p =>
                                p.Id == currentPrivilege.Id && currentPrivilege.Depth == p.Depth);
                            foundDepth = currentPrivilege.Depth.ToString();
                        }
                    }
                    else if (conditionOperator == "Greater than")
                    {
                        Privilege privFound;
                        if (currentPrivilege.IsNoDepth)
                        {
                            matchPrivileges = role.Privileges.Any(p => p.Id == currentPrivilege.Id);
                            privFound = role.Privileges.FirstOrDefault(p =>
                                      p.Id == currentPrivilege.Id && (
                                          p.Depth == PrivilegeDepth.Basic
                                          || p.Depth == PrivilegeDepth.Local
                                          || p.Depth == PrivilegeDepth.Deep
                                          || p.Depth == PrivilegeDepth.Global
                                      ));
                            foundDepth = privFound?.Depth.ToString();
                        }
                        else
                        {
                            switch (currentPrivilege.Depth)
                            {
                                case PrivilegeDepth.Basic:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Local
                                            || p.Depth == PrivilegeDepth.Deep
                                            || p.Depth == PrivilegeDepth.Global
                                        ));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;

                                case PrivilegeDepth.Local:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Deep
                                            || p.Depth == PrivilegeDepth.Global
                                        ));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;

                                case PrivilegeDepth.Deep:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id &&
                                        p.Depth == PrivilegeDepth.Global);
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;

                                case PrivilegeDepth.Global:
                                    break;
                            }
                        }
                    }
                    else if (conditionOperator == "Greater or eq.")
                    {
                        Privilege privFound;
                        if (currentPrivilege.IsNoDepth)
                        {
                            // Greater or equal of nothing is all roles
                            matchPrivileges = true;
                            foundDepth = "";
                        }
                        else
                        {
                            switch (currentPrivilege.Depth)
                            {
                                case PrivilegeDepth.Basic:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Basic
                                            || p.Depth == PrivilegeDepth.Local
                                            || p.Depth == PrivilegeDepth.Deep
                                            || p.Depth == PrivilegeDepth.Global
                                        ));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;

                                case PrivilegeDepth.Local:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Local
                                            || p.Depth == PrivilegeDepth.Deep
                                            || p.Depth == PrivilegeDepth.Global
                                        ));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;

                                case PrivilegeDepth.Deep:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Deep
                                            || p.Depth == PrivilegeDepth.Global
                                        ));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;

                                case PrivilegeDepth.Global:
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && p.Depth == PrivilegeDepth.Global);
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                    break;
                            }
                        }
                    }
                    else if (conditionOperator == "Lower than" || conditionOperator == "Less than")
                    {
                        Privilege privFound;
                        switch (currentPrivilege.Depth)
                        {
                            case PrivilegeDepth.Basic:
                                matchPrivileges = role.Privileges.All(p =>
                                    p.Id != currentPrivilege.Id);
                                foundDepth = "";
                                break;

                            case PrivilegeDepth.Local:
                                matchPrivileges = role.Privileges.All(p => p.Id != currentPrivilege.Id);
                                foundDepth = "";

                                if (!matchPrivileges)
                                {
                                    privFound = role.Privileges.FirstOrDefault(p => p.Id == currentPrivilege.Id && p.Depth == PrivilegeDepth.Basic);
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                }

                                break;

                            case PrivilegeDepth.Deep:
                                matchPrivileges = role.Privileges.All(p => p.Id != currentPrivilege.Id);
                                foundDepth = "";

                                if (!matchPrivileges)
                                {
                                    privFound = role.Privileges.FirstOrDefault(p => p.Id == currentPrivilege.Id && (p.Depth == PrivilegeDepth.Basic || p.Depth == PrivilegeDepth.Local));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                }

                                break;

                            case PrivilegeDepth.Global:
                                matchPrivileges = role.Privileges.All(p => p.Id != currentPrivilege.Id);
                                foundDepth = "";

                                if (!matchPrivileges)
                                {
                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Basic
                                            || p.Depth == PrivilegeDepth.Local
                                            || p.Depth == PrivilegeDepth.Deep
                                            ));
                                    matchPrivileges = privFound != null;
                                    foundDepth = privFound?.Depth.ToString();
                                }

                                break;
                        }
                    }
                    else if (conditionOperator == "Lower or eq." || conditionOperator == "Less or eq.")
                    {
                        if (currentPrivilege.IsNoDepth)
                        {
                            matchPrivileges = role.Privileges.All(p => p.Id != currentPrivilege.Id);
                            foundDepth = "";
                        }
                        else
                        {
                            Privilege privFound;
                            switch (currentPrivilege.Depth)
                            {
                                case PrivilegeDepth.Basic:
                                    matchPrivileges = role.Privileges.All(p =>
                                        p.Id != currentPrivilege.Id);
                                    foundDepth = "";

                                    if (!matchPrivileges)
                                    {
                                        privFound = role.Privileges.FirstOrDefault(p =>
                                            p.Id == currentPrivilege.Id &&
                                            p.Depth == PrivilegeDepth.Basic);
                                        matchPrivileges = privFound != null;
                                        foundDepth = privFound?.Depth.ToString();
                                    }

                                    break;

                                case PrivilegeDepth.Local:
                                    matchPrivileges = role.Privileges.All(p =>
                                        p.Id != currentPrivilege.Id);
                                    foundDepth = "";

                                    if (!matchPrivileges)
                                    {
                                        privFound = role.Privileges.FirstOrDefault(p =>
                                            p.Id == currentPrivilege.Id &&
                                            (p.Depth == PrivilegeDepth.Basic
                                             || p.Depth == PrivilegeDepth.Local));
                                        matchPrivileges = privFound != null;
                                        foundDepth = privFound?.Depth.ToString();
                                    }

                                    break;

                                case PrivilegeDepth.Deep:
                                    matchPrivileges = role.Privileges.All(p =>
                                        p.Id != currentPrivilege.Id);
                                    foundDepth = "";

                                    if (!matchPrivileges)
                                    {
                                        privFound = role.Privileges.FirstOrDefault(p =>
                                            p.Id == currentPrivilege.Id && (
                                                p.Depth == PrivilegeDepth.Basic
                                                || p.Depth == PrivilegeDepth.Local
                                                || p.Depth == PrivilegeDepth.Deep
                                            ));
                                        matchPrivileges = privFound != null;
                                        foundDepth = privFound?.Depth.ToString();
                                    }

                                    break;

                                case PrivilegeDepth.Global:
                                    matchPrivileges = true;

                                    privFound = role.Privileges.FirstOrDefault(p =>
                                        p.Id == currentPrivilege.Id && (
                                            p.Depth == PrivilegeDepth.Basic
                                            || p.Depth == PrivilegeDepth.Local
                                            || p.Depth == PrivilegeDepth.Deep
                                            || p.Depth == PrivilegeDepth.Global
                                        ));
                                    foundDepth = privFound?.Depth.ToString();

                                    break;
                            }
                        }
                    }

                    if (!matchPrivileges)
                    {
                        if (rdbLevelAny.Checked)
                        {
                            foundDepth = "";
                            matchPrivileges = true;
                        }
                        else break;
                    }

                    privDepths.Add(currentPrivilege.Name, foundDepth);
                }

                if (matchPrivileges)
                {
                    var item2 = new ListViewItem(role.Name) { Tag = role.Id, ImageIndex = 0 };
                    foreach (var pair in privDepths)
                    {
                        item2.SubItems.Add(pair.Value);
                    }

                    lviList.Add(item2);
                }
            }

            foreach (ListViewItem item in lvSelectedPrivileges.Items)
            {
                var currentPrivilege = (Privilege)item.Tag;
                lvRoles.Columns.Add(new ColumnHeader { Name = currentPrivilege.Name, Text = AddSpacesToSentence(currentPrivilege.Id, currentPrivilege.Name.Replace("prv", ""), true), TextAlign = HorizontalAlignment.Center, Width = 120 });
            }

            lvRoles.Items.AddRange(lviList.ToArray());
        }

        private void BtnOpenSecurityRoleClick(object sender, EventArgs e)
        {
            if (lvRoles.SelectedItems.Count == 0)
                return;

            ConnectionDetail.OpenUrlWithBrowserProfile(new Uri(string.Format("{0}/biz/roles/edit.aspx?id={1}", ConnectionDetail.OriginalUrl, (Guid)lvRoles.SelectedItems[0].Tag)));
        }

        private void ComputeListItems()
        {
            foreach (var privilege in privileges)
            {
                string entitySchemaName = null;
                var groupName = string.Empty;
                var entitiesWithPrivilege = (from emd in entities
                                             where emd.Privileges.Any(p => p.PrivilegeId == privilege.Id)
                                             select emd).ToList();
                EntityMetadata entity;
                if (entitiesWithPrivilege.Count > 0 && entitiesWithPrivilege.Any(g => g.IsActivity.Value))
                {
                    entity = entitiesWithPrivilege.FirstOrDefault(g => g.LogicalName == "activitypointer");
                    entitySchemaName = "Activity";
                }
                else
                {
                    entity = entitiesWithPrivilege.FirstOrDefault();
                    if (entity != null)
                    {
                        entitySchemaName = entity.SchemaName;
                    }
                }

                if (entity == null)
                {
                    if (privilege["name"].ToString().EndsWith("Entity"))
                        groupName = "Entity";
                    else if (privilege["name"].ToString().EndsWith("Attribute"))
                        groupName = "Attribute";
                    else if (privilege["name"].ToString().EndsWith("Relationship"))
                        groupName = "Relationship";
                    else if (privilege["name"].ToString().EndsWith("OptionSet"))
                        groupName = "OptionSet";
                    else
                    {
                        if (privilege["name"].ToString().StartsWith("prvCreate")
                            || privilege["name"].ToString().StartsWith("prvRead")
                            || privilege["name"].ToString().StartsWith("prvWrite")
                            || privilege["name"].ToString().StartsWith("prvDelete")
                            || privilege["name"].ToString().StartsWith("prvAppend")
                            || privilege["name"].ToString().StartsWith("prvAppendTo")
                            || privilege["name"].ToString().StartsWith("prvAssign")
                            || privilege["name"].ToString().StartsWith("prvShare")
                            )
                        {
                            continue;
                        }

                        groupName = "_Common";
                    }
                }
                else
                {
                    if (entity.LogicalName == "customeraddress")
                        groupName =
                            entities.First(x => x.LogicalName == "account").DisplayName.UserLocalizedLabel.Label;
                    else if (entity.IsActivity.Value || entity.LogicalName == "bulkoperation")
                    {
                        groupName =
                            entities.First(x => x.LogicalName == "activitypointer").DisplayName.UserLocalizedLabel.Label;
                    }
                    else
                        groupName = entity.DisplayName.UserLocalizedLabel.Label;
                }

                var lvGroup = lvgList.FirstOrDefault(f => f.Name == groupName);

                if (lvGroup == null)
                {
                    lvgList.Add(new ListViewGroup(groupName, groupName));
                }

                privilege["groupname"] = groupName;

                var item = new ListViewItem
                {
                    Text = privilege["name"].ToString().Remove(0, 3),
                    ImageIndex = 1,
                    Tag = privilege,
                    Group =
                        groupName != null
                            ? lvgList.First(f => f.Name == groupName)
                            : lvgList.First(f => f.Name == "_Common")
                };

                if (entitySchemaName != null)
                    item.Text = item.Text.Replace(entitySchemaName, "");

                lviList.Add(item);
            }

            ListViewDelegates.AddGroupsRange(lvPrivileges, lvgList.ToArray());
        }

        private void DoWork()
        {
            Thread.Sleep(400);

            var filterTerm = txtSearch.Text;
            IEnumerable<Entity> matchingPrivileges;

            if (filterTerm.Length != 0)
            {
                matchingPrivileges =
                    privileges.Where(
                        x => x["name"].ToString().IndexOf(filterTerm, StringComparison.OrdinalIgnoreCase) >= 0
                        || entities.Any(e => e.DisplayName?.UserLocalizedLabel?.Label.IndexOf(filterTerm, StringComparison.OrdinalIgnoreCase) >= 0 && e.Privileges.Any(p => p.PrivilegeId == x.Id))).ToList();
            }
            else
            {
                matchingPrivileges = privileges.ToList();
            }

            var items = lviList.Where(i => matchingPrivileges.FirstOrDefault(mp => mp.Id.Equals(((Entity)i.Tag).Id)) != null).ToList();

            foreach (ListViewItem item in items)
            {
                var grpName = ((Entity)item.Tag).GetAttributeValue<string>("groupname");
                item.Group = grpName != null
                            ? lvgList.First(f => f.Name == grpName)
                            : lvgList.First(f => f.Name == "_Common");
            }

            //ListViewDelegates.AddGroupsRange(lvPrivileges, lvgList.ToArray());

            ListViewDelegates.AddItemsRange(lvPrivileges, items.ToArray());
            ListViewDelegates.SortGroup(lvPrivileges, true);
            ListViewDelegates.Sort(lvPrivileges, true);
            CommonDelegates.SetEnableState(btnAdd, true);
            CommonDelegates.SetEnableState(btnRemove, true);
        }

        private void LvPrivilegesMouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnAddClick(null, null);
        }

        private void LvPrivilegesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPrivileges.SelectedItems.Count <= 0) return;

            bool canBeLocal = true;
            bool canBeBasic = true;
            bool canBeDeep = true;
            bool canBeGlobal = true;

            foreach (ListViewItem item in lvPrivileges.SelectedItems)
            {
                var privilege = item.Tag as Entity;

                if (privilege == null) continue;

                if ((bool)privilege["canbelocal"] == false)
                    canBeLocal = false;
                if ((bool)privilege["canbebasic"] == false)
                    canBeBasic = false;
                if ((bool)privilege["canbedeep"] == false)
                    canBeDeep = false;
                if ((bool)privilege["canbeglobal"] == false)
                    canBeGlobal = false;
            }

            rdbLevelUser.Enabled = canBeBasic;
            pbLevelUser.Enabled = canBeBasic;
            rdbLevelDiv.Enabled = canBeLocal;
            pbLevelDiv.Enabled = canBeLocal;
            rdbLevelSubDiv.Enabled = canBeDeep;
            pbLevelSubDiv.Enabled = canBeDeep;
            rdbLevelOrg.Enabled = canBeGlobal;
            pbLevelOrg.Enabled = canBeGlobal;

            if (!canBeBasic && rdbLevelUser.Checked
                || !canBeLocal && rdbLevelDiv.Checked
                || !canBeDeep && rdbLevelSubDiv.Checked
                || !canBeGlobal && rdbLevelOrg.Checked)
                rdbLevelAny.Checked = true;
        }

        private void lvRoles_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvRoles_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex >= 1 && e.SubItem.Text != null)
            {
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                }

                var depth = e.SubItem.Text;
                int imageIndex = 0;
                if (depth != string.Empty)
                {
                    switch (Enum.Parse(typeof(PrivilegeDepth), depth))
                    {
                        case PrivilegeDepth.Basic:
                            imageIndex = 1;
                            break;

                        case PrivilegeDepth.Local:
                            imageIndex = 2;
                            break;

                        case PrivilegeDepth.Deep:
                            imageIndex = 3;
                            break;

                        case PrivilegeDepth.Global:
                            imageIndex = 4;
                            break;
                    }
                }

                var sourceBmp = new Bitmap(privilegeList.Images[imageIndex]);
                Rectangle srcRect = new Rectangle(0, 0, 16, 16);
                Bitmap cropped = sourceBmp.Clone(srcRect, sourceBmp.PixelFormat);
                e.Graphics.DrawImage(cropped, new Point(e.Bounds.X + (e.Bounds.Width - 16) / 2, e.Bounds.Y));
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void LvSelectedPrivilegesMouseDoubleClick(object sender, MouseEventArgs e)
        {
            BtnRemoveClick(null, null);
        }

        private void rdbPrivOperatorLessThan_Click(object sender, EventArgs e)
        {
            rdbLevelAny.Enabled = true;
            rdbLevelOrg.Enabled = true;
            rdbLevelNone.Enabled = true;

            var operatorValue = pnlPrivOperators.Controls.OfType<RadioButton>().First(rb => rb.Checked).Text;//comboBox1.SelectedItem?.ToString();

            if (operatorValue == "Greater than")
            {
                rdbLevelAny.Enabled = false;
                rdbLevelOrg.Enabled = false;
                rdbLevelAny.Checked = false;
                rdbLevelOrg.Checked = false;
            }
            else if (operatorValue == "Greater or eq.")
            {
                rdbLevelAny.Enabled = false;
                rdbLevelAny.Checked = false;
            }
            else if (operatorValue == "Lower than" || operatorValue == "Less than")
            {
                rdbLevelAny.Enabled = false;
                rdbLevelNone.Enabled = false;
                rdbLevelAny.Checked = false;
                rdbLevelNone.Checked = false;
            }
            else if (operatorValue == "Lower or eq." || operatorValue == "Less or eq.")
            {
                rdbLevelAny.Enabled = false;
                rdbLevelAny.Checked = false;
            }
        }

        private void tsddbLoad_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiLoadAll)
            {
                ExecuteMethod(LoadRolesAndPrivs, false);
            }
            else if (e.ClickedItem == tsmiLoadFromSolution)
            {
                ExecuteMethod(LoadRolesAndPrivs, true);
            }
        }

        private void TxtSearchTextChanged(object sender, EventArgs e)
        {
            fillPrivThread?.Abort();

            lvPrivileges.Items.Clear();
            //lvPrivileges.Groups.Clear();

            btnAdd.Enabled = false;
            btnRemove.Enabled = false;

            fillPrivThread = new Thread(DoWork);
            fillPrivThread.Start();
        }
    }
}