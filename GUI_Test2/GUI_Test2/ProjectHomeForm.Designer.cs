namespace GUI_Test2
{
    partial class ProjectHomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectHomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAKEPATHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runPlaytestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hubListBox = new System.Windows.Forms.ListBox();
            this.pathListBox = new System.Windows.Forms.ListBox();
            this.hubLabel = new System.Windows.Forms.Label();
            this.pathGroupLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathGroupListBox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selectedNavImage = new System.Windows.Forms.PictureBox();
            this.navInfo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedNavImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.createToolStripMenuItem,
            this.runPlaytestToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(872, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attributesToolStripMenuItem,
            this.charactersToolStripMenuItem,
            this.endingsToolStripMenuItem,
            this.gameSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // attributesToolStripMenuItem
            // 
            this.attributesToolStripMenuItem.Name = "attributesToolStripMenuItem";
            this.attributesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.attributesToolStripMenuItem.Text = "Attributes";
            this.attributesToolStripMenuItem.Click += new System.EventHandler(this.attributesToolStripMenuItem_Click);
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.charactersToolStripMenuItem.Text = "Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.charactersToolStripMenuItem_Click);
            // 
            // endingsToolStripMenuItem
            // 
            this.endingsToolStripMenuItem.Name = "endingsToolStripMenuItem";
            this.endingsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.endingsToolStripMenuItem.Text = "Endings";
            this.endingsToolStripMenuItem.Click += new System.EventHandler(this.endingsToolStripMenuItem_Click);
            // 
            // gameSettingsToolStripMenuItem
            // 
            this.gameSettingsToolStripMenuItem.Name = "gameSettingsToolStripMenuItem";
            this.gameSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.gameSettingsToolStripMenuItem.Text = "Game Settings";
            this.gameSettingsToolStripMenuItem.Click += new System.EventHandler(this.gameSettingsToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hubToolStripMenuItem,
            this.pathToolStripMenuItem,
            this.pathGroupToolStripMenuItem,
            this.mAKEPATHSToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.createToolStripMenuItem.Text = "Create...";
            // 
            // hubToolStripMenuItem
            // 
            this.hubToolStripMenuItem.Name = "hubToolStripMenuItem";
            this.hubToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.hubToolStripMenuItem.Text = "Hub";
            this.hubToolStripMenuItem.Click += new System.EventHandler(this.hubToolStripMenuItem_Click);
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pathToolStripMenuItem.Text = "Path";
            this.pathToolStripMenuItem.Click += new System.EventHandler(this.pathToolStripMenuItem_Click);
            // 
            // pathGroupToolStripMenuItem
            // 
            this.pathGroupToolStripMenuItem.Name = "pathGroupToolStripMenuItem";
            this.pathGroupToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.pathGroupToolStripMenuItem.Text = "PathGroup";
            this.pathGroupToolStripMenuItem.Click += new System.EventHandler(this.pathGroupToolStripMenuItem_Click);
            // 
            // mAKEPATHSToolStripMenuItem
            // 
            this.mAKEPATHSToolStripMenuItem.Name = "mAKEPATHSToolStripMenuItem";
            this.mAKEPATHSToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.mAKEPATHSToolStripMenuItem.Text = "MAKE PATHS!";
            this.mAKEPATHSToolStripMenuItem.Click += new System.EventHandler(this.makeSamplePaths);
            // 
            // runPlaytestToolStripMenuItem1
            // 
            this.runPlaytestToolStripMenuItem1.Name = "runPlaytestToolStripMenuItem1";
            this.runPlaytestToolStripMenuItem1.Size = new System.Drawing.Size(101, 24);
            this.runPlaytestToolStripMenuItem1.Text = "Run Playtest";
            this.runPlaytestToolStripMenuItem1.Click += new System.EventHandler(this.runPlayTest_MenuItemClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.Controls.Add(this.hubListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pathListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hubLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pathGroupLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pathLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pathGroupListBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 53);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 490);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hubListBox
            // 
            this.hubListBox.FormattingEnabled = true;
            this.hubListBox.ItemHeight = 16;
            this.hubListBox.Location = new System.Drawing.Point(4, 45);
            this.hubListBox.Margin = new System.Windows.Forms.Padding(4);
            this.hubListBox.Name = "hubListBox";
            this.hubListBox.Size = new System.Drawing.Size(188, 436);
            this.hubListBox.TabIndex = 0;
            this.hubListBox.SelectedIndexChanged += new System.EventHandler(this.hubListBox_SelectedIndexChanged);
            this.hubListBox.DoubleClick += new System.EventHandler(this.LoadHubFromListBox);
            // 
            // pathListBox
            // 
            this.pathListBox.FormattingEnabled = true;
            this.pathListBox.ItemHeight = 16;
            this.pathListBox.Location = new System.Drawing.Point(404, 45);
            this.pathListBox.Margin = new System.Windows.Forms.Padding(4);
            this.pathListBox.Name = "pathListBox";
            this.pathListBox.Size = new System.Drawing.Size(191, 436);
            this.pathListBox.TabIndex = 2;
            this.pathListBox.SelectedIndexChanged += new System.EventHandler(this.pathListBox_SelectedIndexChanged_1);
            this.pathListBox.DoubleClick += new System.EventHandler(this.LoadPathFromPathListBox);
            // 
            // hubLabel
            // 
            this.hubLabel.AutoSize = true;
            this.hubLabel.Location = new System.Drawing.Point(4, 0);
            this.hubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hubLabel.Name = "hubLabel";
            this.hubLabel.Size = new System.Drawing.Size(41, 17);
            this.hubLabel.TabIndex = 4;
            this.hubLabel.Text = "Hubs";
            // 
            // pathGroupLabel
            // 
            this.pathGroupLabel.AutoSize = true;
            this.pathGroupLabel.Location = new System.Drawing.Point(204, 0);
            this.pathGroupLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathGroupLabel.Name = "pathGroupLabel";
            this.pathGroupLabel.Size = new System.Drawing.Size(84, 17);
            this.pathGroupLabel.TabIndex = 5;
            this.pathGroupLabel.Text = "PathGroups";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(404, 0);
            this.pathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(44, 17);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Paths";
            // 
            // pathGroupListBox
            // 
            this.pathGroupListBox.FormattingEnabled = true;
            this.pathGroupListBox.ItemHeight = 16;
            this.pathGroupListBox.Location = new System.Drawing.Point(204, 45);
            this.pathGroupListBox.Margin = new System.Windows.Forms.Padding(4);
            this.pathGroupListBox.Name = "pathGroupListBox";
            this.pathGroupListBox.Size = new System.Drawing.Size(189, 436);
            this.pathGroupListBox.TabIndex = 1;
            this.pathGroupListBox.SelectedIndexChanged += new System.EventHandler(this.pathGroupListBox_SelectedIndexChanged);
            this.pathGroupListBox.DoubleClick += new System.EventHandler(this.LoadPathGroupFromPathListBox);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(688, 492);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 42);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // selectedNavImage
            // 
            this.selectedNavImage.Location = new System.Drawing.Point(631, 98);
            this.selectedNavImage.Name = "selectedNavImage";
            this.selectedNavImage.Size = new System.Drawing.Size(221, 145);
            this.selectedNavImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.selectedNavImage.TabIndex = 3;
            this.selectedNavImage.TabStop = false;
            // 
            // navInfo
            // 
            this.navInfo.Location = new System.Drawing.Point(631, 255);
            this.navInfo.Name = "navInfo";
            this.navInfo.Size = new System.Drawing.Size(221, 233);
            this.navInfo.TabIndex = 4;
            // 
            // ProjectHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 562);
            this.Controls.Add(this.navInfo);
            this.Controls.Add(this.selectedNavImage);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(782, 596);
            this.Name = "ProjectHomeForm";
            this.Text = "Project Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeButton_Click);
            this.Load += new System.EventHandler(this.ProjectHub_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedNavImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runPlaytestToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox hubListBox;
        private System.Windows.Forms.ListBox pathGroupListBox;
        private System.Windows.Forms.ListBox pathListBox;
        private System.Windows.Forms.Label hubLabel;
        private System.Windows.Forms.Label pathGroupLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.ToolStripMenuItem attributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAKEPATHSToolStripMenuItem;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem endingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox selectedNavImage;
        private System.Windows.Forms.Label navInfo;
    }
}