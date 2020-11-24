namespace MsCrmTools.UserRolesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadCrmItems = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbRoleActions = new System.Windows.Forms.ToolStripDropDownButton();
            this.actionAddSelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionRemoveSelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionRemoveAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.roleSelector = new MsCrmTools.UserRolesManager.UserControls.RoleSelector();
            this.principalSelector = new MsCrmTools.UserRolesManager.UserControls.PrincipalSelector();
            this.toolStripComboBatchSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.toolStripSeparator1,
            this.tsbLoadCrmItems,
            this.toolStripSeparator,
            this.toolStripLabel1,
            this.toolStripComboBatchSize,
            this.tsddbRoleActions,
            this.tsbCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(714, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(23, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.TsbCloseClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLoadCrmItems
            // 
            this.tsbLoadCrmItems.Image = ((System.Drawing.Image)(resources.GetObject("tsbLoadCrmItems.Image")));
            this.tsbLoadCrmItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadCrmItems.Name = "tsbLoadCrmItems";
            this.tsbLoadCrmItems.Size = new System.Drawing.Size(177, 22);
            this.tsbLoadCrmItems.Text = "Load Roles, Users and Teams";
            this.tsbLoadCrmItems.Click += new System.EventHandler(this.tsbLoadCrmItems_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbRoleActions
            // 
            this.tsddbRoleActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionAddSelToolStripMenuItem,
            this.actionRemoveSelToolStripMenuItem,
            this.actionRemoveAddToolStripMenuItem});
            this.tsddbRoleActions.Image = ((System.Drawing.Image)(resources.GetObject("tsddbRoleActions.Image")));
            this.tsddbRoleActions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbRoleActions.Name = "tsddbRoleActions";
            this.tsddbRoleActions.Size = new System.Drawing.Size(76, 22);
            this.tsddbRoleActions.Text = "Actions";
            // 
            // actionAddSelToolStripMenuItem
            // 
            this.actionAddSelToolStripMenuItem.Name = "actionAddSelToolStripMenuItem";
            this.actionAddSelToolStripMenuItem.Size = new System.Drawing.Size(455, 22);
            this.actionAddSelToolStripMenuItem.Text = "Add selected roles to selected users or teams";
            this.actionAddSelToolStripMenuItem.Click += new System.EventHandler(this.actionAddSelToolStripMenuItem_Click);
            // 
            // actionRemoveSelToolStripMenuItem
            // 
            this.actionRemoveSelToolStripMenuItem.Name = "actionRemoveSelToolStripMenuItem";
            this.actionRemoveSelToolStripMenuItem.Size = new System.Drawing.Size(455, 22);
            this.actionRemoveSelToolStripMenuItem.Text = "Remove selected roles from selected users or teams";
            this.actionRemoveSelToolStripMenuItem.Click += new System.EventHandler(this.actionRemoveSelToolStripMenuItem_Click);
            // 
            // actionRemoveAddToolStripMenuItem
            // 
            this.actionRemoveAddToolStripMenuItem.Name = "actionRemoveAddToolStripMenuItem";
            this.actionRemoveAddToolStripMenuItem.Size = new System.Drawing.Size(455, 22);
            this.actionRemoveAddToolStripMenuItem.Text = "Remove exisiting roles then add selected roles to selected users or teams";
            this.actionRemoveAddToolStripMenuItem.Click += new System.EventHandler(this.actionRemoveAddToolStripMenuItem_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Enabled = false;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(63, 22);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.ToolTipText = "Cancel the current request";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.roleSelector);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.principalSelector);
            this.splitContainer.Size = new System.Drawing.Size(714, 452);
            this.splitContainer.SplitterDistance = 340;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 2;
            // 
            // roleSelector
            // 
            this.roleSelector.AllRoles = null;
            this.roleSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleSelector.Location = new System.Drawing.Point(0, 0);
            this.roleSelector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.roleSelector.Name = "roleSelector";
            this.roleSelector.Size = new System.Drawing.Size(340, 452);
            this.roleSelector.TabIndex = 0;
            // 
            // principalSelector
            // 
            this.principalSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.principalSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principalSelector.Location = new System.Drawing.Point(0, 0);
            this.principalSelector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.principalSelector.Name = "principalSelector";
            this.principalSelector.Size = new System.Drawing.Size(371, 452);
            this.principalSelector.TabIndex = 1;
            // 
            // toolStripComboBatchSize
            // 
            this.toolStripComboBatchSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBatchSize.Items.AddRange(new object[] {
            "1",
            "25",
            "50",
            "75",
            "100"});
            this.toolStripComboBatchSize.Name = "toolStripComboBatchSize";
            this.toolStripComboBatchSize.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBatchSize.ToolTipText = "Select the batch size for the Associate /Disassociate  actions";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Batch Size:";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(714, 477);
            this.Load += new System.EventHandler(this.MainControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadCrmItems;
        private UserControls.PrincipalSelector principalSelector;
        private System.Windows.Forms.SplitContainer splitContainer;
        private UserControls.RoleSelector roleSelector;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripDropDownButton tsddbRoleActions;
        private System.Windows.Forms.ToolStripMenuItem actionAddSelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionRemoveSelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionRemoveAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBatchSize;
    }
}
