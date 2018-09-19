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
            this.tsbLoadRolesAndPrivs = new System.Windows.Forms.ToolStripButton();
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbResultingRoles = new System.Windows.Forms.GroupBox();
            this.btnOpenSecurityRole = new System.Windows.Forms.Button();
            this.lvRoles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbLevelNone = new System.Windows.Forms.RadioButton();
            this.pbLevelOrg = new System.Windows.Forms.PictureBox();
            this.pbLevelSubDiv = new System.Windows.Forms.PictureBox();
            this.pbLevelDiv = new System.Windows.Forms.PictureBox();
            this.pbLevelUser = new System.Windows.Forms.PictureBox();
            this.rdbLevelOrg = new System.Windows.Forms.RadioButton();
            this.rdbLevelSubDiv = new System.Windows.Forms.RadioButton();
            this.rdbLevelDiv = new System.Windows.Forms.RadioButton();
            this.rdbLevelUser = new System.Windows.Forms.RadioButton();
            this.lblLevelAny = new System.Windows.Forms.Label();
            this.rdbLevelAny = new System.Windows.Forms.RadioButton();
            this.privilegeList = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenu.SuspendLayout();
            this.gbPrivileges.SuspendLayout();
            this.gbSelectedPrivileges.SuspendLayout();
            this.gbResultingRoles.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelSubDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUser)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadRolesAndPrivs});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1558, 37);
            this.toolStripMenu.TabIndex = 2;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbLoadRolesAndPrivs
            // 
            this.tsbLoadRolesAndPrivs.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadRolesAndPrivs.Image")));
            this.tsbLoadRolesAndPrivs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadRolesAndPrivs.Name = "tsbLoadRolesAndPrivs";
            this.tsbLoadRolesAndPrivs.Size = new System.Drawing.Size(267, 34);
            this.tsbLoadRolesAndPrivs.Text = "Load Roles and Privileges";
            this.tsbLoadRolesAndPrivs.Click += new System.EventHandler(this.TsbLoadRolesAndPrivsClick);
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
            this.gbPrivileges.Location = new System.Drawing.Point(6, 52);
            this.gbPrivileges.Margin = new System.Windows.Forms.Padding(6);
            this.gbPrivileges.Name = "gbPrivileges";
            this.gbPrivileges.Padding = new System.Windows.Forms.Padding(6);
            this.gbPrivileges.Size = new System.Drawing.Size(513, 866);
            this.gbPrivileges.TabIndex = 3;
            this.gbPrivileges.TabStop = false;
            this.gbPrivileges.Text = "Privileges";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(11, 41);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 25);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(97, 35);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(402, 29);
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
            this.lvPrivileges.Location = new System.Drawing.Point(11, 89);
            this.lvPrivileges.Margin = new System.Windows.Forms.Padding(6);
            this.lvPrivileges.Name = "lvPrivileges";
            this.lvPrivileges.Size = new System.Drawing.Size(488, 763);
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
            this.gbSelectedPrivileges.Location = new System.Drawing.Point(711, 52);
            this.gbSelectedPrivileges.Margin = new System.Windows.Forms.Padding(6);
            this.gbSelectedPrivileges.Name = "gbSelectedPrivileges";
            this.gbSelectedPrivileges.Padding = new System.Windows.Forms.Padding(6);
            this.gbSelectedPrivileges.Size = new System.Drawing.Size(842, 430);
            this.gbSelectedPrivileges.TabIndex = 4;
            this.gbSelectedPrivileges.TabStop = false;
            this.gbSelectedPrivileges.Text = "Selected Privileges";
            // 
            // btnDisplayRoles
            // 
            this.btnDisplayRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisplayRoles.Location = new System.Drawing.Point(11, 35);
            this.btnDisplayRoles.Margin = new System.Windows.Forms.Padding(6);
            this.btnDisplayRoles.Name = "btnDisplayRoles";
            this.btnDisplayRoles.Size = new System.Drawing.Size(820, 42);
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
            this.lvSelectedPrivileges.Location = new System.Drawing.Point(11, 89);
            this.lvSelectedPrivileges.Margin = new System.Windows.Forms.Padding(6);
            this.lvSelectedPrivileges.Name = "lvSelectedPrivileges";
            this.lvSelectedPrivileges.Size = new System.Drawing.Size(817, 327);
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
            this.gbResultingRoles.Location = new System.Drawing.Point(711, 494);
            this.gbResultingRoles.Margin = new System.Windows.Forms.Padding(6);
            this.gbResultingRoles.Name = "gbResultingRoles";
            this.gbResultingRoles.Padding = new System.Windows.Forms.Padding(6);
            this.gbResultingRoles.Size = new System.Drawing.Size(842, 429);
            this.gbResultingRoles.TabIndex = 5;
            this.gbResultingRoles.TabStop = false;
            this.gbResultingRoles.Text = "Roles that match selection";
            // 
            // btnOpenSecurityRole
            // 
            this.btnOpenSecurityRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSecurityRole.Location = new System.Drawing.Point(11, 35);
            this.btnOpenSecurityRole.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenSecurityRole.Name = "btnOpenSecurityRole";
            this.btnOpenSecurityRole.Size = new System.Drawing.Size(820, 42);
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
            this.lvRoles.Location = new System.Drawing.Point(11, 89);
            this.lvRoles.Margin = new System.Windows.Forms.Padding(6);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.OwnerDraw = true;
            this.lvRoles.Size = new System.Drawing.Size(816, 326);
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
            this.btnAdd.Location = new System.Drawing.Point(532, 439);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(532, 87);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 42);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemoveClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rdbLevelNone);
            this.panel1.Controls.Add(this.pbLevelOrg);
            this.panel1.Controls.Add(this.pbLevelSubDiv);
            this.panel1.Controls.Add(this.pbLevelDiv);
            this.panel1.Controls.Add(this.pbLevelUser);
            this.panel1.Controls.Add(this.rdbLevelOrg);
            this.panel1.Controls.Add(this.rdbLevelSubDiv);
            this.panel1.Controls.Add(this.rdbLevelDiv);
            this.panel1.Controls.Add(this.rdbLevelUser);
            this.panel1.Controls.Add(this.lblLevelAny);
            this.panel1.Controls.Add(this.rdbLevelAny);
            this.panel1.Location = new System.Drawing.Point(532, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 286);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // rdbLevelNone
            // 
            this.rdbLevelNone.AutoSize = true;
            this.rdbLevelNone.Location = new System.Drawing.Point(7, 58);
            this.rdbLevelNone.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLevelNone.Name = "rdbLevelNone";
            this.rdbLevelNone.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelNone.TabIndex = 10;
            this.rdbLevelNone.UseVisualStyleBackColor = true;
            // 
            // pbLevelOrg
            // 
            this.pbLevelOrg.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelOrg.Image")));
            this.pbLevelOrg.Location = new System.Drawing.Point(44, 230);
            this.pbLevelOrg.Margin = new System.Windows.Forms.Padding(6);
            this.pbLevelOrg.Name = "pbLevelOrg";
            this.pbLevelOrg.Size = new System.Drawing.Size(29, 30);
            this.pbLevelOrg.TabIndex = 9;
            this.pbLevelOrg.TabStop = false;
            // 
            // pbLevelSubDiv
            // 
            this.pbLevelSubDiv.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelSubDiv.Image")));
            this.pbLevelSubDiv.Location = new System.Drawing.Point(44, 195);
            this.pbLevelSubDiv.Margin = new System.Windows.Forms.Padding(6);
            this.pbLevelSubDiv.Name = "pbLevelSubDiv";
            this.pbLevelSubDiv.Size = new System.Drawing.Size(29, 30);
            this.pbLevelSubDiv.TabIndex = 8;
            this.pbLevelSubDiv.TabStop = false;
            // 
            // pbLevelDiv
            // 
            this.pbLevelDiv.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelDiv.Image")));
            this.pbLevelDiv.Location = new System.Drawing.Point(44, 160);
            this.pbLevelDiv.Margin = new System.Windows.Forms.Padding(6);
            this.pbLevelDiv.Name = "pbLevelDiv";
            this.pbLevelDiv.Size = new System.Drawing.Size(29, 30);
            this.pbLevelDiv.TabIndex = 7;
            this.pbLevelDiv.TabStop = false;
            // 
            // pbLevelUser
            // 
            this.pbLevelUser.Image = ((System.Drawing.Image)(resources.GetObject("pbLevelUser.Image")));
            this.pbLevelUser.Location = new System.Drawing.Point(44, 125);
            this.pbLevelUser.Margin = new System.Windows.Forms.Padding(6);
            this.pbLevelUser.Name = "pbLevelUser";
            this.pbLevelUser.Size = new System.Drawing.Size(29, 30);
            this.pbLevelUser.TabIndex = 6;
            this.pbLevelUser.TabStop = false;
            // 
            // rdbLevelOrg
            // 
            this.rdbLevelOrg.AutoSize = true;
            this.rdbLevelOrg.Location = new System.Drawing.Point(7, 234);
            this.rdbLevelOrg.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLevelOrg.Name = "rdbLevelOrg";
            this.rdbLevelOrg.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelOrg.TabIndex = 5;
            this.rdbLevelOrg.UseVisualStyleBackColor = true;
            // 
            // rdbLevelSubDiv
            // 
            this.rdbLevelSubDiv.AutoSize = true;
            this.rdbLevelSubDiv.Location = new System.Drawing.Point(7, 199);
            this.rdbLevelSubDiv.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLevelSubDiv.Name = "rdbLevelSubDiv";
            this.rdbLevelSubDiv.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelSubDiv.TabIndex = 4;
            this.rdbLevelSubDiv.UseVisualStyleBackColor = true;
            // 
            // rdbLevelDiv
            // 
            this.rdbLevelDiv.AutoSize = true;
            this.rdbLevelDiv.Location = new System.Drawing.Point(7, 163);
            this.rdbLevelDiv.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLevelDiv.Name = "rdbLevelDiv";
            this.rdbLevelDiv.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelDiv.TabIndex = 3;
            this.rdbLevelDiv.UseVisualStyleBackColor = true;
            // 
            // rdbLevelUser
            // 
            this.rdbLevelUser.AutoSize = true;
            this.rdbLevelUser.Location = new System.Drawing.Point(7, 128);
            this.rdbLevelUser.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLevelUser.Name = "rdbLevelUser";
            this.rdbLevelUser.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelUser.TabIndex = 2;
            this.rdbLevelUser.UseVisualStyleBackColor = true;
            // 
            // lblLevelAny
            // 
            this.lblLevelAny.AutoSize = true;
            this.lblLevelAny.Location = new System.Drawing.Point(42, 93);
            this.lblLevelAny.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLevelAny.Name = "lblLevelAny";
            this.lblLevelAny.Size = new System.Drawing.Size(47, 25);
            this.lblLevelAny.TabIndex = 1;
            this.lblLevelAny.Text = "Any";
            // 
            // rdbLevelAny
            // 
            this.rdbLevelAny.AutoSize = true;
            this.rdbLevelAny.Checked = true;
            this.rdbLevelAny.Location = new System.Drawing.Point(7, 93);
            this.rdbLevelAny.Margin = new System.Windows.Forms.Padding(6);
            this.rdbLevelAny.Name = "rdbLevelAny";
            this.rdbLevelAny.Size = new System.Drawing.Size(21, 20);
            this.rdbLevelAny.TabIndex = 0;
            this.rdbLevelAny.TabStop = true;
            this.rdbLevelAny.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Equals",
            "Greater than",
            "Greater or eq.",
            "Lower than",
            "Lower or eq."});
            this.comboBox1.Location = new System.Drawing.Point(0, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 32);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Operator";
            this.columnHeader6.Width = 120;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbResultingRoles);
            this.Controls.Add(this.gbSelectedPrivileges);
            this.Controls.Add(this.gbPrivileges);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1558, 923);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbPrivileges.ResumeLayout(false);
            this.gbPrivileges.PerformLayout();
            this.gbSelectedPrivileges.ResumeLayout(false);
            this.gbResultingRoles.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelSubDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevelUser)).EndInit();
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
        private System.Windows.Forms.ToolStripButton tsbLoadRolesAndPrivs;
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
