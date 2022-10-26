namespace MsCrmTools.PrivDiscover
{
    partial class MainControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsddbLoad = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLoadAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadFromSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolImageList = new System.Windows.Forms.ImageList(this.components);
            this.gbPrivileges = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lvPrivileges = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvImagesList = new System.Windows.Forms.ImageList(this.components);
            this.gbSelectedPrivileges = new System.Windows.Forms.GroupBox();
            this.btnDisplayRoles = new System.Windows.Forms.Button();
            this.lvSelectedPrivileges = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbResultingRoles = new System.Windows.Forms.GroupBox();
            this.btnOpenSecurityRole = new System.Windows.Forms.Button();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrivDepth = new System.Windows.Forms.Panel();
            this.rdbLevelNone = new System.Windows.Forms.RadioButton();
            this.rdbLevelAny = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLevelAny = new System.Windows.Forms.Label();
            this.rdbLevelUser = new System.Windows.Forms.RadioButton();
            this.pbLevelOrg = new System.Windows.Forms.PictureBox();
            this.rdbLevelDiv = new System.Windows.Forms.RadioButton();
            this.pbLevelSubDiv = new System.Windows.Forms.PictureBox();
            this.rdbLevelSubDiv = new System.Windows.Forms.RadioButton();
            this.pbLevelDiv = new System.Windows.Forms.PictureBox();
            this.rdbLevelOrg = new System.Windows.Forms.RadioButton();
            this.pbLevelUser = new System.Windows.Forms.PictureBox();
            this.pnlSeparator = new System.Windows.Forms.Panel();
            this.pnlPrivOperators = new System.Windows.Forms.Panel();
            this.rdbPrivOperatorLessThan = new System.Windows.Forms.RadioButton();
            this.rdbPrivOperatorLessOrEquals = new System.Windows.Forms.RadioButton();
            this.rdbPrivOperatorEquals = new System.Windows.Forms.RadioButton();
            this.rdbPrivOperatorGreaterOrEquals = new System.Windows.Forms.RadioButton();
            this.rdbPrivOperatorCreaterThan = new System.Windows.Forms.RadioButton();
            this.privilegeList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripMenu.SuspendLayout();
            this.gbPrivileges.SuspendLayout();
            this.gbSelectedPrivileges.SuspendLayout();
            this.gbResultingRoles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPrivDepth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelSubDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUser)).BeginInit();
            this.pnlPrivOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbLoad});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1275, 34);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsddbLoad
            // 
            this.tsddbLoad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadAll,
            this.tsmiLoadFromSolution});
            this.tsddbLoad.Image = global::MsCrmTools.SecurityRelated.Properties.Resources.Dataverse_16x16;
            this.tsddbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbLoad.Name = "tsddbLoad";
            this.tsddbLoad.Size = new System.Drawing.Size(85, 29);
            this.tsddbLoad.Text = "Load";
            this.tsddbLoad.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbLoad_DropDownItemClicked);
            // 
            // tsmiLoadAll
            // 
            this.tsmiLoadAll.Image = global::MsCrmTools.SecurityRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadAll.Name = "tsmiLoadAll";
            this.tsmiLoadAll.Size = new System.Drawing.Size(401, 34);
            this.tsmiLoadAll.Text = "Roles and all privileges";
            // 
            // tsmiLoadFromSolution
            // 
            this.tsmiLoadFromSolution.Image = global::MsCrmTools.SecurityRelated.Properties.Resources.Dataverse_16x16;
            this.tsmiLoadFromSolution.Name = "tsmiLoadFromSolution";
            this.tsmiLoadFromSolution.Size = new System.Drawing.Size(401, 34);
            this.tsmiLoadFromSolution.Text = "Roles and Privileges from solution(s)";
            // 
            // toolImageList
            // 
            this.toolImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolImageList.ImageStream")));
            this.toolImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.toolImageList.Images.SetKeyName(0, "Icon.png");
            // 
            // gbPrivileges
            // 
            this.gbPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPrivileges.Controls.Add(this.lblSearch);
            this.gbPrivileges.Controls.Add(this.txtSearch);
            this.gbPrivileges.Controls.Add(this.lvPrivileges);
            this.gbPrivileges.Location = new System.Drawing.Point(5, 43);
            this.gbPrivileges.Margin = new System.Windows.Forms.Padding(5);
            this.gbPrivileges.Name = "gbPrivileges";
            this.gbPrivileges.Padding = new System.Windows.Forms.Padding(5);
            this.gbPrivileges.Size = new System.Drawing.Size(420, 722);
            this.gbPrivileges.TabIndex = 3;
            this.gbPrivileges.TabStop = false;
            this.gbPrivileges.Text = "Privileges";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(9, 34);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 20);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(79, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(330, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearchTextChanged);
            // 
            // lvPrivileges
            // 
            this.lvPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPrivileges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvPrivileges.FullRowSelect = true;
            this.lvPrivileges.HideSelection = false;
            this.lvPrivileges.Location = new System.Drawing.Point(9, 74);
            this.lvPrivileges.Margin = new System.Windows.Forms.Padding(5);
            this.lvPrivileges.Name = "lvPrivileges";
            this.lvPrivileges.Size = new System.Drawing.Size(400, 636);
            this.lvPrivileges.SmallImageList = this.lvImagesList;
            this.lvPrivileges.TabIndex = 2;
            this.lvPrivileges.UseCompatibleStateImageBehavior = false;
            this.lvPrivileges.View = System.Windows.Forms.View.Details;
            this.lvPrivileges.SelectedIndexChanged += new System.EventHandler(this.LvPrivilegesSelectedIndexChanged);
            this.lvPrivileges.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvPrivilegesMouseDoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 240;
            // 
            // lvImagesList
            // 
            this.lvImagesList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lvImagesList.ImageStream")));
            this.lvImagesList.TransparentColor = System.Drawing.Color.Transparent;
            this.lvImagesList.Images.SetKeyName(0, "ico_16_1036.gif");
            this.lvImagesList.Images.SetKeyName(1, "key.png");
            // 
            // gbSelectedPrivileges
            // 
            this.gbSelectedPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelectedPrivileges.Controls.Add(this.btnDisplayRoles);
            this.gbSelectedPrivileges.Controls.Add(this.lvSelectedPrivileges);
            this.gbSelectedPrivileges.Location = new System.Drawing.Point(582, 43);
            this.gbSelectedPrivileges.Margin = new System.Windows.Forms.Padding(5);
            this.gbSelectedPrivileges.Name = "gbSelectedPrivileges";
            this.gbSelectedPrivileges.Padding = new System.Windows.Forms.Padding(5);
            this.gbSelectedPrivileges.Size = new System.Drawing.Size(689, 358);
            this.gbSelectedPrivileges.TabIndex = 4;
            this.gbSelectedPrivileges.TabStop = false;
            this.gbSelectedPrivileges.Text = "Selected Privileges";
            // 
            // btnDisplayRoles
            // 
            this.btnDisplayRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayRoles.Location = new System.Drawing.Point(9, 29);
            this.btnDisplayRoles.Margin = new System.Windows.Forms.Padding(5);
            this.btnDisplayRoles.Name = "btnDisplayRoles";
            this.btnDisplayRoles.Size = new System.Drawing.Size(671, 35);
            this.btnDisplayRoles.TabIndex = 7;
            this.btnDisplayRoles.Text = "Display roles that match the selection\r\n";
            this.btnDisplayRoles.UseVisualStyleBackColor = true;
            this.btnDisplayRoles.Click += new System.EventHandler(this.BtnDisplayRolesClick);
            // 
            // lvSelectedPrivileges
            // 
            this.lvSelectedPrivileges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSelectedPrivileges.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader4});
            this.lvSelectedPrivileges.FullRowSelect = true;
            this.lvSelectedPrivileges.HideSelection = false;
            this.lvSelectedPrivileges.Location = new System.Drawing.Point(9, 74);
            this.lvSelectedPrivileges.Margin = new System.Windows.Forms.Padding(5);
            this.lvSelectedPrivileges.Name = "lvSelectedPrivileges";
            this.lvSelectedPrivileges.Size = new System.Drawing.Size(669, 273);
            this.lvSelectedPrivileges.SmallImageList = this.lvImagesList;
            this.lvSelectedPrivileges.TabIndex = 1;
            this.lvSelectedPrivileges.UseCompatibleStateImageBehavior = false;
            this.lvSelectedPrivileges.View = System.Windows.Forms.View.Details;
            this.lvSelectedPrivileges.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvSelectedPrivilegesMouseDoubleClick);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Operator";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Depth";
            this.columnHeader4.Width = 120;
            // 
            // gbResultingRoles
            // 
            this.gbResultingRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultingRoles.Controls.Add(this.btnOpenSecurityRole);
            this.gbResultingRoles.Controls.Add(this.lvRoles);
            this.gbResultingRoles.Location = new System.Drawing.Point(582, 412);
            this.gbResultingRoles.Margin = new System.Windows.Forms.Padding(5);
            this.gbResultingRoles.Name = "gbResultingRoles";
            this.gbResultingRoles.Padding = new System.Windows.Forms.Padding(5);
            this.gbResultingRoles.Size = new System.Drawing.Size(689, 357);
            this.gbResultingRoles.TabIndex = 5;
            this.gbResultingRoles.TabStop = false;
            this.gbResultingRoles.Text = "Roles that match selection";
            // 
            // btnOpenSecurityRole
            // 
            this.btnOpenSecurityRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSecurityRole.Location = new System.Drawing.Point(9, 29);
            this.btnOpenSecurityRole.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenSecurityRole.Name = "btnOpenSecurityRole";
            this.btnOpenSecurityRole.Size = new System.Drawing.Size(671, 35);
            this.btnOpenSecurityRole.TabIndex = 8;
            this.btnOpenSecurityRole.Text = "Open security role";
            this.btnOpenSecurityRole.UseVisualStyleBackColor = true;
            this.btnOpenSecurityRole.Click += new System.EventHandler(this.BtnOpenSecurityRoleClick);
            // 
            // lvRoles
            // 
            this.lvRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvRoles.FullRowSelect = true;
            this.lvRoles.HideSelection = false;
            this.lvRoles.Location = new System.Drawing.Point(9, 74);
            this.lvRoles.Margin = new System.Windows.Forms.Padding(5);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.OwnerDraw = true;
            this.lvRoles.Size = new System.Drawing.Size(668, 272);
            this.lvRoles.SmallImageList = this.lvImagesList;
            this.lvRoles.TabIndex = 0;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            this.lvRoles.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lvRoles_DrawColumnHeader);
            this.lvRoles.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.lvRoles_DrawSubItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(435, 505);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(435, 72);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 35);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlPrivDepth);
            this.panel1.Controls.Add(this.pnlSeparator);
            this.panel1.Controls.Add(this.pnlPrivOperators);
            this.panel1.Location = new System.Drawing.Point(424, 117);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 378);
            this.panel1.TabIndex = 8;
            // 
            // pnlPrivDepth
            // 
            this.pnlPrivDepth.Controls.Add(this.rdbLevelNone);
            this.pnlPrivDepth.Controls.Add(this.rdbLevelAny);
            this.pnlPrivDepth.Controls.Add(this.pictureBox1);
            this.pnlPrivDepth.Controls.Add(this.lblLevelAny);
            this.pnlPrivDepth.Controls.Add(this.rdbLevelUser);
            this.pnlPrivDepth.Controls.Add(this.pbLevelOrg);
            this.pnlPrivDepth.Controls.Add(this.rdbLevelDiv);
            this.pnlPrivDepth.Controls.Add(this.pbLevelSubDiv);
            this.pnlPrivDepth.Controls.Add(this.rdbLevelSubDiv);
            this.pnlPrivDepth.Controls.Add(this.pbLevelDiv);
            this.pnlPrivDepth.Controls.Add(this.rdbLevelOrg);
            this.pnlPrivDepth.Controls.Add(this.pbLevelUser);
            this.pnlPrivDepth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrivDepth.Location = new System.Drawing.Point(0, 206);
            this.pnlPrivDepth.Name = "pnlPrivDepth";
            this.pnlPrivDepth.Size = new System.Drawing.Size(157, 285);
            this.pnlPrivDepth.TabIndex = 13;
            // 
            // rdbLevelNone
            // 
            this.rdbLevelNone.AutoSize = true;
            this.rdbLevelNone.Location = new System.Drawing.Point(5, 5);
            this.rdbLevelNone.Margin = new System.Windows.Forms.Padding(5);
            this.rdbLevelNone.Name = "rdbLevelNone";
            this.rdbLevelNone.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelNone.TabIndex = 10;
            this.rdbLevelNone.UseVisualStyleBackColor = true;
            // 
            // rdbLevelAny
            // 
            this.rdbLevelAny.AutoSize = true;
            this.rdbLevelAny.Checked = true;
            this.rdbLevelAny.Location = new System.Drawing.Point(5, 34);
            this.rdbLevelAny.Margin = new System.Windows.Forms.Padding(5);
            this.rdbLevelAny.Name = "rdbLevelAny";
            this.rdbLevelAny.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelAny.TabIndex = 0;
            this.rdbLevelAny.TabStop = true;
            this.rdbLevelAny.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblLevelAny
            // 
            this.lblLevelAny.AutoSize = true;
            this.lblLevelAny.Location = new System.Drawing.Point(33, 34);
            this.lblLevelAny.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLevelAny.Name = "lblLevelAny";
            this.lblLevelAny.Size = new System.Drawing.Size(36, 20);
            this.lblLevelAny.TabIndex = 1;
            this.lblLevelAny.Text = "Any";
            // 
            // rdbLevelUser
            // 
            this.rdbLevelUser.AutoSize = true;
            this.rdbLevelUser.Location = new System.Drawing.Point(5, 64);
            this.rdbLevelUser.Margin = new System.Windows.Forms.Padding(5);
            this.rdbLevelUser.Name = "rdbLevelUser";
            this.rdbLevelUser.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelUser.TabIndex = 2;
            this.rdbLevelUser.UseVisualStyleBackColor = true;
            // 
            // pbLevelOrg
            // 
            this.pbLevelOrg.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelOrg.Image")));
            this.pbLevelOrg.Location = new System.Drawing.Point(35, 149);
            this.pbLevelOrg.Margin = new System.Windows.Forms.Padding(5);
            this.pbLevelOrg.Name = "pbLevelOrg";
            this.pbLevelOrg.Size = new System.Drawing.Size(24, 25);
            this.pbLevelOrg.TabIndex = 9;
            this.pbLevelOrg.TabStop = false;
            // 
            // rdbLevelDiv
            // 
            this.rdbLevelDiv.AutoSize = true;
            this.rdbLevelDiv.Location = new System.Drawing.Point(5, 93);
            this.rdbLevelDiv.Margin = new System.Windows.Forms.Padding(5);
            this.rdbLevelDiv.Name = "rdbLevelDiv";
            this.rdbLevelDiv.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelDiv.TabIndex = 3;
            this.rdbLevelDiv.UseVisualStyleBackColor = true;
            // 
            // pbLevelSubDiv
            // 
            this.pbLevelSubDiv.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelSubDiv.Image")));
            this.pbLevelSubDiv.Location = new System.Drawing.Point(35, 119);
            this.pbLevelSubDiv.Margin = new System.Windows.Forms.Padding(5);
            this.pbLevelSubDiv.Name = "pbLevelSubDiv";
            this.pbLevelSubDiv.Size = new System.Drawing.Size(24, 25);
            this.pbLevelSubDiv.TabIndex = 8;
            this.pbLevelSubDiv.TabStop = false;
            // 
            // rdbLevelSubDiv
            // 
            this.rdbLevelSubDiv.AutoSize = true;
            this.rdbLevelSubDiv.Location = new System.Drawing.Point(5, 123);
            this.rdbLevelSubDiv.Margin = new System.Windows.Forms.Padding(5);
            this.rdbLevelSubDiv.Name = "rdbLevelSubDiv";
            this.rdbLevelSubDiv.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelSubDiv.TabIndex = 4;
            this.rdbLevelSubDiv.UseVisualStyleBackColor = true;
            // 
            // pbLevelDiv
            // 
            this.pbLevelDiv.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelDiv.Image")));
            this.pbLevelDiv.Location = new System.Drawing.Point(35, 90);
            this.pbLevelDiv.Margin = new System.Windows.Forms.Padding(5);
            this.pbLevelDiv.Name = "pbLevelDiv";
            this.pbLevelDiv.Size = new System.Drawing.Size(24, 25);
            this.pbLevelDiv.TabIndex = 7;
            this.pbLevelDiv.TabStop = false;
            // 
            // rdbLevelOrg
            // 
            this.rdbLevelOrg.AutoSize = true;
            this.rdbLevelOrg.Location = new System.Drawing.Point(5, 152);
            this.rdbLevelOrg.Margin = new System.Windows.Forms.Padding(5);
            this.rdbLevelOrg.Name = "rdbLevelOrg";
            this.rdbLevelOrg.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelOrg.TabIndex = 5;
            this.rdbLevelOrg.UseVisualStyleBackColor = true;
            // 
            // pbLevelUser
            // 
            this.pbLevelUser.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelUser.Image")));
            this.pbLevelUser.Location = new System.Drawing.Point(35, 61);
            this.pbLevelUser.Margin = new System.Windows.Forms.Padding(5);
            this.pbLevelUser.Name = "pbLevelUser";
            this.pbLevelUser.Size = new System.Drawing.Size(24, 25);
            this.pbLevelUser.TabIndex = 6;
            this.pbLevelUser.TabStop = false;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 132);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(236, 5);
            this.pnlSeparator.TabIndex = 9;
            // 
            // pnlPrivOperators
            // 
            this.pnlPrivOperators.Controls.Add(this.rdbPrivOperatorLessThan);
            this.pnlPrivOperators.Controls.Add(this.rdbPrivOperatorLessOrEquals);
            this.pnlPrivOperators.Controls.Add(this.rdbPrivOperatorEquals);
            this.pnlPrivOperators.Controls.Add(this.rdbPrivOperatorGreaterOrEquals);
            this.pnlPrivOperators.Controls.Add(this.rdbPrivOperatorCreaterThan);
            this.pnlPrivOperators.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrivOperators.Location = new System.Drawing.Point(0, 0);
            this.pnlPrivOperators.Name = "pnlPrivOperators";
            this.pnlPrivOperators.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pnlPrivOperators.Size = new System.Drawing.Size(157, 132);
            this.pnlPrivOperators.TabIndex = 14;
            // 
            // rdbPrivOperatorLessThan
            // 
            this.rdbPrivOperatorLessThan.AutoSize = true;
            this.rdbPrivOperatorLessThan.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbPrivOperatorLessThan.Location = new System.Drawing.Point(6, 216);
            this.rdbPrivOperatorLessThan.Name = "rdbPrivOperatorLessThan";
            this.rdbPrivOperatorLessThan.Size = new System.Drawing.Size(230, 36);
            this.rdbPrivOperatorLessThan.TabIndex = 4;
            this.rdbPrivOperatorLessThan.Text = "Less than";
            this.rdbPrivOperatorLessThan.UseVisualStyleBackColor = true;
            this.rdbPrivOperatorLessThan.Click += new System.EventHandler(this.rdbPrivOperatorLessThan_Click);
            // 
            // rdbPrivOperatorLessOrEquals
            // 
            this.rdbPrivOperatorLessOrEquals.AutoSize = true;
            this.rdbPrivOperatorLessOrEquals.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbPrivOperatorLessOrEquals.Location = new System.Drawing.Point(6, 162);
            this.rdbPrivOperatorLessOrEquals.Name = "rdbPrivOperatorLessOrEquals";
            this.rdbPrivOperatorLessOrEquals.Size = new System.Drawing.Size(230, 36);
            this.rdbPrivOperatorLessOrEquals.TabIndex = 3;
            this.rdbPrivOperatorLessOrEquals.Text = "Less or eq.";
            this.rdbPrivOperatorLessOrEquals.UseVisualStyleBackColor = true;
            this.rdbPrivOperatorLessOrEquals.Click += new System.EventHandler(this.rdbPrivOperatorLessThan_Click);
            // 
            // rdbPrivOperatorEquals
            // 
            this.rdbPrivOperatorEquals.AutoSize = true;
            this.rdbPrivOperatorEquals.Checked = true;
            this.rdbPrivOperatorEquals.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbPrivOperatorEquals.Location = new System.Drawing.Point(6, 108);
            this.rdbPrivOperatorEquals.Name = "rdbPrivOperatorEquals";
            this.rdbPrivOperatorEquals.Size = new System.Drawing.Size(230, 36);
            this.rdbPrivOperatorEquals.TabIndex = 2;
            this.rdbPrivOperatorEquals.TabStop = true;
            this.rdbPrivOperatorEquals.Tag = "";
            this.rdbPrivOperatorEquals.Text = "Equals";
            this.rdbPrivOperatorEquals.UseVisualStyleBackColor = true;
            this.rdbPrivOperatorEquals.Click += new System.EventHandler(this.rdbPrivOperatorLessThan_Click);
            // 
            // rdbPrivOperatorGreaterOrEquals
            // 
            this.rdbPrivOperatorGreaterOrEquals.AutoSize = true;
            this.rdbPrivOperatorGreaterOrEquals.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbPrivOperatorGreaterOrEquals.Location = new System.Drawing.Point(6, 54);
            this.rdbPrivOperatorGreaterOrEquals.Name = "rdbPrivOperatorGreaterOrEquals";
            this.rdbPrivOperatorGreaterOrEquals.Size = new System.Drawing.Size(230, 36);
            this.rdbPrivOperatorGreaterOrEquals.TabIndex = 1;
            this.rdbPrivOperatorGreaterOrEquals.Text = "Greater or eq.";
            this.rdbPrivOperatorGreaterOrEquals.UseVisualStyleBackColor = true;
            this.rdbPrivOperatorGreaterOrEquals.Click += new System.EventHandler(this.rdbPrivOperatorLessThan_Click);
            // 
            // rdbPrivOperatorCreaterThan
            // 
            this.rdbPrivOperatorCreaterThan.AutoSize = true;
            this.rdbPrivOperatorCreaterThan.Dock = System.Windows.Forms.DockStyle.Top;
            this.rdbPrivOperatorCreaterThan.Location = new System.Drawing.Point(6, 0);
            this.rdbPrivOperatorCreaterThan.Name = "rdbPrivOperatorCreaterThan";
            this.rdbPrivOperatorCreaterThan.Size = new System.Drawing.Size(230, 36);
            this.rdbPrivOperatorCreaterThan.TabIndex = 0;
            this.rdbPrivOperatorCreaterThan.Text = "Greater than";
            this.rdbPrivOperatorCreaterThan.UseVisualStyleBackColor = true;
            this.rdbPrivOperatorCreaterThan.Click += new System.EventHandler(this.rdbPrivOperatorLessThan_Click);
            // 
            // privilegeList
            // 
            this.privilegeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("privilegeList.ImageStream")));
            this.privilegeList.TransparentColor = System.Drawing.Color.Transparent;
            this.privilegeList.Images.SetKeyName(0, "pbLevelNone.Image.gif");
            this.privilegeList.Images.SetKeyName(1, "pbLevelUser.Image.gif");
            this.privilegeList.Images.SetKeyName(2, "pbLevelDiv.Image.gif");
            this.privilegeList.Images.SetKeyName(3, "pbLevelSubDiv.Image.gif");
            this.privilegeList.Images.SetKeyName(4, "pbLevelOrg.Image.gif");
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbResultingRoles);
            this.Controls.Add(this.gbSelectedPrivileges);
            this.Controls.Add(this.gbPrivileges);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1275, 769);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbPrivileges.ResumeLayout(false);
            this.gbPrivileges.PerformLayout();
            this.gbSelectedPrivileges.ResumeLayout(false);
            this.gbResultingRoles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlPrivDepth.ResumeLayout(false);
            this.pnlPrivDepth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelSubDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUser)).EndInit();
            this.pnlPrivOperators.ResumeLayout(false);
            this.pnlPrivOperators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ImageList toolImageList;
        private System.Windows.Forms.GroupBox gbPrivileges;
        private System.Windows.Forms.GroupBox gbSelectedPrivileges;
        private System.Windows.Forms.GroupBox gbResultingRoles;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lvPrivileges;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvSelectedPrivileges;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDisplayRoles;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ImageList lvImagesList;
        private System.Windows.Forms.Button btnOpenSecurityRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLevelOrg;
        private System.Windows.Forms.PictureBox pbLevelSubDiv;
        private System.Windows.Forms.PictureBox pbLevelDiv;
        private System.Windows.Forms.PictureBox pbLevelUser;
        private System.Windows.Forms.RadioButton rdbLevelOrg;
        private System.Windows.Forms.RadioButton rdbLevelSubDiv;
        private System.Windows.Forms.RadioButton rdbLevelDiv;
        private System.Windows.Forms.RadioButton rdbLevelUser;
        private System.Windows.Forms.Label lblLevelAny;
        private System.Windows.Forms.RadioButton rdbLevelAny;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdbLevelNone;
        private System.Windows.Forms.ImageList privilegeList;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripDropDownButton tsddbLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromSolution;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadAll;
        private System.Windows.Forms.Panel pnlPrivOperators;
        private System.Windows.Forms.RadioButton rdbPrivOperatorLessThan;
        private System.Windows.Forms.RadioButton rdbPrivOperatorLessOrEquals;
        private System.Windows.Forms.RadioButton rdbPrivOperatorEquals;
        private System.Windows.Forms.RadioButton rdbPrivOperatorGreaterOrEquals;
        private System.Windows.Forms.RadioButton rdbPrivOperatorCreaterThan;
        private System.Windows.Forms.Panel pnlPrivDepth;
        private System.Windows.Forms.Panel pnlSeparator;
    }
}
