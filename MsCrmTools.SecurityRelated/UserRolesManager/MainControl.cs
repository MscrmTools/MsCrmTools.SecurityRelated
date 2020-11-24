using Microsoft.Xrm.Sdk;
using MsCrmTools.UserRolesManager.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MsCrmTools.UserRolesManager
{
    public partial class MainControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        private List<Entity> allRoles;
        private Guid currentUserId;

        public string RepositoryName => "MsCrmTools.SecurityRelated";
        public string UserName => "MscrmTools";
        public string HelpUrl => "https://github.com/MscrmTools/MsCrmTools.SecurityRelated/wiki";

        public MainControl()
        {
            InitializeComponent();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            toolStripComboBatchSize.SelectedItem = "50";
        }
        private void LoadCrmItems()
        {
            principalSelector.Service = Service;
            roleSelector.Service = Service;

            principalSelector.LoadViews();
            roleSelector.LoadRoles();

            allRoles = roleSelector.AllRoles;

            currentUserId = (new SystemUserManager(Service)).GetCurrentUserId();
        }

        private void TsbCloseClick(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbLoadCrmItems_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadCrmItems);
        }

        /// <summary>
        /// Allow users to cancel the action 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            CancelWorker();
        }

        #region Action 1 : Add roles to principals

        /// <summary>
        /// Add the selected Roles to the selected Users or Teams
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionAddSelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptContinue()) {
                return;
            }

            var ra = new RoleAction
            {
                ActionType = 1,
                Roles = roleSelector.SelectedRoles,
                Principals = principalSelector.SelectedItems,
                BatchSize = int.Parse(toolStripComboBatchSize.Text)
            };

            ToggleToolButtons(true);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Adding roles to principal(s)...",
                AsyncArgument = ra,
                IsCancelable = true,
                Work = (bw, evt) =>
                {
                    var action = (RoleAction)evt.Argument;
                    // set the batch size for this instance
                    var rManager = new RoleManager(Service) {
                        BatchSize = action.BatchSize
                    };
                    rManager.AddRolesToPrincipals(action.Roles, action.Principals, allRoles, bw);
                },
                PostWorkCallBack = evt =>
                {
                    if (evt.Error != null)
                    {
                        MessageBox.Show(this, "An error occured: " + evt.Error.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    ToggleToolButtons(false);
                },
                ProgressChanged = evt => { SetWorkingMessage(string.Format(evt.UserState.ToString(), evt.ProgressPercentage)); }
            });
        }

        #endregion Action 1 : Add roles to principals

        #region Action 2 : Remove roles from principals

        /// <summary>
        /// Remove the selected Roles from the User/Team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actionRemoveSelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptContinue()) {
                return;
            }

            var ra = new RoleAction
            {
                ActionType = 2,
                Roles = roleSelector.SelectedRoles,
                Principals = principalSelector.SelectedItems,
                BatchSize = int.Parse(toolStripComboBatchSize.Text)
            };

            if (ra.Principals.Any(p => p.Id == currentUserId))
            {
                MessageBox.Show(this,
                    "You can't remove roles from your own profile. Your profile will be removed from the principals list",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ra.Principals.Remove(ra.Principals.First(r => r.Id == currentUserId));
            }

            ToggleToolButtons(true);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Removing roles to principal(s)...",
                AsyncArgument = ra,
                IsCancelable = true,
                Work = (bw, evt) =>
                {
                    var action = (RoleAction)evt.Argument;
                    // set the batch size for this instance
                    var rManager = new RoleManager(Service) {
                        BatchSize = action.BatchSize
                    };

                    rManager.RemoveRolesFromPrincipals(action.Roles, action.Principals, allRoles, bw);
                },
                PostWorkCallBack = evt =>
                {
                    if (evt.Error != null)
                    {
                        MessageBox.Show(this, "An error occured: " + evt.Error.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    ToggleToolButtons(false);
                },
                ProgressChanged = evt => SetWorkingMessage(string.Format(evt.UserState.ToString(), evt.ProgressPercentage))
            });
        }
        #endregion Action 2 : Remove roles from principals

        #region Action 3 : Remove then Add roles to principals
        /// <summary>
        /// Remove all Roles from the User/Team, then add the selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void actionRemoveAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PromptContinue()) {
                return;
            }
            var ra = new RoleAction
            {
                ActionType = 3,
                Roles = roleSelector.SelectedRoles,
                Principals = principalSelector.SelectedItems,
                BatchSize = int.Parse(toolStripComboBatchSize.Text)
            };

            if (ra.Principals.Any(p => p.Id == currentUserId))
            {
                MessageBox.Show(this,
                    "You can't remove roles from your own profile. Your profile will be removed from the principals list",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                ra.Principals.Remove(ra.Principals.First(r => r.Id == currentUserId));
            }

            ToggleToolButtons(true);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Removing roles from principal(s)...",
                AsyncArgument = ra,
                IsCancelable = true,
                Work = (bw, evt) =>
                {
                    var action = (RoleAction)evt.Argument;
                    // set the batch size for this instance
                    var rManager = new RoleManager(Service) {
                        BatchSize = action.BatchSize
                    };

                    rManager.RemoveExistingRolesFromPrincipals(action.Principals);

                    bw.ReportProgress(0, "Adding roles to principals ({0} %)...");

                    rManager.AddRolesToPrincipals(action.Roles, action.Principals, allRoles, bw);
                },
                PostWorkCallBack = evt =>
                {
                    if (evt.Error != null)
                    {
                        MessageBox.Show(this, "An error occured: " + evt.Error.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    ToggleToolButtons(false);
                },
                ProgressChanged = evt => { SetWorkingMessage(string.Format(evt.UserState.ToString(), evt.ProgressPercentage)); }
            });
        }

        #endregion Action 3 : Remove then Add roles to principals

        /// <summary>
        /// Make sure we know the consequences of our actions.
        /// </summary>
        /// <returns></returns>
        private bool PromptContinue() 
        {
            if (principalSelector.SelectedItems.Count * roleSelector.SelectedRoles.Count < 100) {
                return true;
            }

            return MessageBox.Show(this, "Applying a large number Roles may take some time to complete. \n" +
                "Once started, you may Cancel using the toolbar button but Role changes already been applied will not be rolled back.", "Continue with Role Changes?", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        /// <summary>
        /// Toggle tool buttons on run
        /// </summary>
        /// <param name="cancelEnabled"></param>
        private void ToggleToolButtons(bool cancelEnabled) {
            tsbCancel.Enabled = cancelEnabled;
            toolStripComboBatchSize.Enabled = !cancelEnabled;
            actionRemoveSelToolStripMenuItem.Enabled = !cancelEnabled;
            actionRemoveAddToolStripMenuItem.Enabled = !cancelEnabled;
            actionAddSelToolStripMenuItem.Enabled = !cancelEnabled;
        }
    }
}