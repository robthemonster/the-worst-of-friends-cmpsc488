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
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAKEPATHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runPlaytestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hubListBox = new System.Windows.Forms.ListBox();
            this.pathGroupListBox = new System.Windows.Forms.ListBox();
            this.pathListBox = new System.Windows.Forms.ListBox();
            this.hubLabel = new System.Windows.Forms.Label();
            this.pathGroupLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(894, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeWindow);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.charactersToolStripMenuItem,
            this.attributesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.charactersToolStripMenuItem.Text = "Characters";
            this.charactersToolStripMenuItem.Click += new System.EventHandler(this.charactersToolStripMenuItem_Click);
            // 
            // attributesToolStripMenuItem
            // 
            this.attributesToolStripMenuItem.Name = "attributesToolStripMenuItem";
            this.attributesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.attributesToolStripMenuItem.Text = "Attributes";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hubToolStripMenuItem,
            this.pathToolStripMenuItem,
            this.pathGroupToolStripMenuItem,
            this.mAKEPATHSToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.createToolStripMenuItem.Text = "Create...";
            // 
            // hubToolStripMenuItem
            // 
            this.hubToolStripMenuItem.Name = "hubToolStripMenuItem";
            this.hubToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hubToolStripMenuItem.Text = "Hub";
            this.hubToolStripMenuItem.Click += new System.EventHandler(this.hubToolStripMenuItem_Click);
            // 
            // pathToolStripMenuItem
            // 
            this.pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            this.pathToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pathToolStripMenuItem.Text = "Path";
            this.pathToolStripMenuItem.Click += new System.EventHandler(this.pathToolStripMenuItem_Click);
            // 
            // pathGroupToolStripMenuItem
            // 
            this.pathGroupToolStripMenuItem.Name = "pathGroupToolStripMenuItem";
            this.pathGroupToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pathGroupToolStripMenuItem.Text = "PathGroup";
            this.pathGroupToolStripMenuItem.Click += new System.EventHandler(this.pathGroupToolStripMenuItem_Click);
            // 
            // mAKEPATHSToolStripMenuItem
            // 
            this.mAKEPATHSToolStripMenuItem.Name = "mAKEPATHSToolStripMenuItem";
            this.mAKEPATHSToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.mAKEPATHSToolStripMenuItem.Text = "MAKE PATHS!";
            this.mAKEPATHSToolStripMenuItem.Click += new System.EventHandler(this.makeSamplePaths);
            // 
            // runPlaytestToolStripMenuItem1
            // 
            this.runPlaytestToolStripMenuItem1.Name = "runPlaytestToolStripMenuItem1";
            this.runPlaytestToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.runPlaytestToolStripMenuItem1.Text = "Run Playtest";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.hubListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pathGroupListBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pathListBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hubLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pathGroupLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pathLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 424);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // hubListBox
            // 
            this.hubListBox.FormattingEnabled = true;
            this.hubListBox.Location = new System.Drawing.Point(3, 36);
            this.hubListBox.Name = "hubListBox";
            this.hubListBox.Size = new System.Drawing.Size(142, 355);
            this.hubListBox.TabIndex = 0;
            // 
            // pathGroupListBox
            // 
            this.pathGroupListBox.FormattingEnabled = true;
            this.pathGroupListBox.Location = new System.Drawing.Point(153, 36);
            this.pathGroupListBox.Name = "pathGroupListBox";
            this.pathGroupListBox.Size = new System.Drawing.Size(143, 355);
            this.pathGroupListBox.TabIndex = 1;
            // 
            // pathListBox
            // 
            this.pathListBox.FormattingEnabled = true;
            this.pathListBox.Location = new System.Drawing.Point(303, 36);
            this.pathListBox.Name = "pathListBox";
            this.pathListBox.Size = new System.Drawing.Size(144, 355);
            this.pathListBox.TabIndex = 2;
            this.pathListBox.SelectedIndexChanged += new System.EventHandler(this.pathListBox_SelectedIndexChanged);
            this.pathListBox.DoubleClick += new System.EventHandler(this.LoadPathFromPathListBox);
            // 
            // hubLabel
            // 
            this.hubLabel.AutoSize = true;
            this.hubLabel.Location = new System.Drawing.Point(3, 0);
            this.hubLabel.Name = "hubLabel";
            this.hubLabel.Size = new System.Drawing.Size(32, 13);
            this.hubLabel.TabIndex = 4;
            this.hubLabel.Text = "Hubs";
            // 
            // pathGroupLabel
            // 
            this.pathGroupLabel.AutoSize = true;
            this.pathGroupLabel.Location = new System.Drawing.Point(153, 0);
            this.pathGroupLabel.Name = "pathGroupLabel";
            this.pathGroupLabel.Size = new System.Drawing.Size(63, 13);
            this.pathGroupLabel.TabIndex = 5;
            this.pathGroupLabel.Text = "PathGroups";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(303, 0);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(34, 13);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Paths";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(773, 349);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(74, 35);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeWindow);
            // 
            // ProjectHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 464);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(902, 493);
            this.Name = "ProjectHomeForm";
            this.Text = "Project Home";
            this.Load += new System.EventHandler(this.ProjectHub_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStripMenuItem attributesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAKEPATHSToolStripMenuItem;
    }
}