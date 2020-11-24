namespace MsCrmTools.UserRolesManager.UserControls
{
    partial class PrincipalSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalSelector));
            this.label1 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.cbbViews = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ilUserAndTeams = new System.Windows.Forms.ImageList(this.components);
            this.panelRecordType = new System.Windows.Forms.Panel();
            this.panelView = new System.Windows.Forms.Panel();
            this.lvUsersAndTeams = new System.Windows.Forms.ListView();
            this.labelDetailLabel = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelDetails = new System.Windows.Forms.Label();
            this.panelRecordType.SuspendLayout();
            this.panelView.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record type";
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Users",
            "Teams"});
            this.cbbType.Location = new System.Drawing.Point(128, 3);
            this.cbbType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(534, 21);
            this.cbbType.TabIndex = 1;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // cbbViews
            // 
            this.cbbViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbViews.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbViews.FormattingEnabled = true;
            this.cbbViews.Location = new System.Drawing.Point(128, 3);
            this.cbbViews.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbbViews.Name = "cbbViews";
            this.cbbViews.Size = new System.Drawing.Size(534, 21);
            this.cbbViews.TabIndex = 2;
            this.cbbViews.SelectedIndexChanged += new System.EventHandler(this.cbbViews_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "View";
            // 
            // ilUserAndTeams
            // 
            this.ilUserAndTeams.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilUserAndTeams.ImageStream")));
            this.ilUserAndTeams.TransparentColor = System.Drawing.Color.Transparent;
            this.ilUserAndTeams.Images.SetKeyName(0, "ico_16_8.gif");
            this.ilUserAndTeams.Images.SetKeyName(1, "ico_16_9.gif");
            // 
            // panelRecordType
            // 
            this.panelRecordType.Controls.Add(this.cbbType);
            this.panelRecordType.Controls.Add(this.label1);
            this.panelRecordType.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecordType.Location = new System.Drawing.Point(0, 0);
            this.panelRecordType.Margin = new System.Windows.Forms.Padding(2);
            this.panelRecordType.Name = "panelRecordType";
            this.panelRecordType.Size = new System.Drawing.Size(663, 26);
            this.panelRecordType.TabIndex = 5;
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.cbbViews);
            this.panelView.Controls.Add(this.label2);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 26);
            this.panelView.Margin = new System.Windows.Forms.Padding(2);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(663, 26);
            this.panelView.TabIndex = 6;
            // 
            // lvUsersAndTeams
            // 
            this.lvUsersAndTeams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsersAndTeams.FullRowSelect = true;
            this.lvUsersAndTeams.HideSelection = false;
            this.lvUsersAndTeams.Location = new System.Drawing.Point(0, 79);
            this.lvUsersAndTeams.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvUsersAndTeams.Name = "lvUsersAndTeams";
            this.lvUsersAndTeams.Size = new System.Drawing.Size(663, 377);
            this.lvUsersAndTeams.SmallImageList = this.ilUserAndTeams;
            this.lvUsersAndTeams.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvUsersAndTeams.TabIndex = 8;
            this.lvUsersAndTeams.UseCompatibleStateImageBehavior = false;
            this.lvUsersAndTeams.View = System.Windows.Forms.View.Details;
            this.lvUsersAndTeams.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvUsersAndTeams_ItemSelectionChanged);
            // 
            // labelDetailLabel
            // 
            this.labelDetailLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDetailLabel.Location = new System.Drawing.Point(2, 2);
            this.labelDetailLabel.Name = "labelDetailLabel";
            this.labelDetailLabel.Size = new System.Drawing.Size(42, 23);
            this.labelDetailLabel.TabIndex = 9;
            this.labelDetailLabel.Text = "Details:";
            this.labelDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelDetails);
            this.panelInfo.Controls.Add(this.labelDetailLabel);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 52);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(2);
            this.panelInfo.Size = new System.Drawing.Size(663, 27);
            this.panelInfo.TabIndex = 10;
            // 
            // labelDetails
            // 
            this.labelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDetails.Location = new System.Drawing.Point(44, 2);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(617, 23);
            this.labelDetails.TabIndex = 10;
            this.labelDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PrincipalSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvUsersAndTeams);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelRecordType);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PrincipalSelector";
            this.Size = new System.Drawing.Size(663, 456);
            this.panelRecordType.ResumeLayout(false);
            this.panelRecordType.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.ComboBox cbbViews;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList ilUserAndTeams;
        private System.Windows.Forms.Panel panelRecordType;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.ListView lvUsersAndTeams;
        private System.Windows.Forms.Label labelDetailLabel;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelDetails;
    }
}
