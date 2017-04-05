namespace GUI_Test2
{
    partial class EditHubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditHubForm));
            this.buttonListDownButton = new System.Windows.Forms.Button();
            this.buttonListUpButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonListBox = new System.Windows.Forms.ListBox();
            this.hubImageBox = new System.Windows.Forms.GroupBox();
            this.hubImagePictureBox = new System.Windows.Forms.PictureBox();
            this.addHubImageButton = new System.Windows.Forms.Button();
            this.chooseHubImageButton = new System.Windows.Forms.Button();
            this.addButtonBox = new System.Windows.Forms.GroupBox();
            this.targetNavigableBox = new System.Windows.Forms.GroupBox();
            this.hubFromButtonRadio = new System.Windows.Forms.RadioButton();
            this.navComboBox = new System.Windows.Forms.ComboBox();
            this.pathGroupFromButtonRadio = new System.Windows.Forms.RadioButton();
            this.pathFromButtonRadio = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButtonButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonTextTextBox = new System.Windows.Forms.TextBox();
            this.useButtonImage = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonHeightTextBox = new System.Windows.Forms.TextBox();
            this.buttonWidthTextBox = new System.Windows.Forms.TextBox();
            this.useButtonSizeDefaults = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonYLocTextBox = new System.Windows.Forms.TextBox();
            this.buttonXLocTextBox = new System.Windows.Forms.TextBox();
            this.useButtonLocationDefaults = new System.Windows.Forms.CheckBox();
            this.chooseButtonImageButton = new System.Windows.Forms.Button();
            this.buttonPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.hubImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hubImagePictureBox)).BeginInit();
            this.addButtonBox.SuspendLayout();
            this.targetNavigableBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonListDownButton
            // 
            this.buttonListDownButton.Location = new System.Drawing.Point(115, 493);
            this.buttonListDownButton.Name = "buttonListDownButton";
            this.buttonListDownButton.Size = new System.Drawing.Size(22, 23);
            this.buttonListDownButton.TabIndex = 43;
            this.buttonListDownButton.Text = "▼";
            this.buttonListDownButton.UseVisualStyleBackColor = true;
            this.buttonListDownButton.Click += new System.EventHandler(this.buttonListDownButton_Click);
            // 
            // buttonListUpButton
            // 
            this.buttonListUpButton.Location = new System.Drawing.Point(115, 464);
            this.buttonListUpButton.Name = "buttonListUpButton";
            this.buttonListUpButton.Size = new System.Drawing.Size(22, 23);
            this.buttonListUpButton.TabIndex = 42;
            this.buttonListUpButton.Text = "▲";
            this.buttonListUpButton.UseVisualStyleBackColor = true;
            this.buttonListUpButton.Click += new System.EventHandler(this.buttonListUpButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(379, 82);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(379, 53);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonListBox, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(15, 153);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.384164F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(97, 363);
            this.tableLayoutPanel4.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Current Buttons";
            // 
            // buttonListBox
            // 
            this.buttonListBox.FormattingEnabled = true;
            this.buttonListBox.Location = new System.Drawing.Point(3, 26);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(91, 329);
            this.buttonListBox.TabIndex = 1;
            // 
            // hubImageBox
            // 
            this.hubImageBox.Controls.Add(this.hubImagePictureBox);
            this.hubImageBox.Controls.Add(this.addHubImageButton);
            this.hubImageBox.Controls.Add(this.chooseHubImageButton);
            this.hubImageBox.Location = new System.Drawing.Point(9, 12);
            this.hubImageBox.Name = "hubImageBox";
            this.hubImageBox.Size = new System.Drawing.Size(341, 135);
            this.hubImageBox.TabIndex = 45;
            this.hubImageBox.TabStop = false;
            this.hubImageBox.Text = "Add Hub Image";
            // 
            // hubImagePictureBox
            // 
            this.hubImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hubImagePictureBox.Image = global::GUI_Test2.Properties.Resources.defaultHub;
            this.hubImagePictureBox.Location = new System.Drawing.Point(6, 13);
            this.hubImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.hubImagePictureBox.Name = "hubImagePictureBox";
            this.hubImagePictureBox.Size = new System.Drawing.Size(205, 117);
            this.hubImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hubImagePictureBox.TabIndex = 9;
            this.hubImagePictureBox.TabStop = false;
            // 
            // addHubImageButton
            // 
            this.addHubImageButton.Location = new System.Drawing.Point(216, 41);
            this.addHubImageButton.Name = "addHubImageButton";
            this.addHubImageButton.Size = new System.Drawing.Size(121, 23);
            this.addHubImageButton.TabIndex = 8;
            this.addHubImageButton.Text = "Add Hub Image";
            this.addHubImageButton.UseVisualStyleBackColor = true;
            this.addHubImageButton.Click += new System.EventHandler(this.addHubImageButton_Click);
            // 
            // chooseHubImageButton
            // 
            this.chooseHubImageButton.Location = new System.Drawing.Point(216, 13);
            this.chooseHubImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.chooseHubImageButton.Name = "chooseHubImageButton";
            this.chooseHubImageButton.Size = new System.Drawing.Size(119, 23);
            this.chooseHubImageButton.TabIndex = 1;
            this.chooseHubImageButton.Text = "Choose Hub Image...";
            this.chooseHubImageButton.UseVisualStyleBackColor = true;
            this.chooseHubImageButton.Click += new System.EventHandler(this.chooseHubImageButton_Click);
            // 
            // addButtonBox
            // 
            this.addButtonBox.Controls.Add(this.targetNavigableBox);
            this.addButtonBox.Controls.Add(this.deleteButton);
            this.addButtonBox.Controls.Add(this.createButtonButton);
            this.addButtonBox.Controls.Add(this.label15);
            this.addButtonBox.Controls.Add(this.buttonTextTextBox);
            this.addButtonBox.Controls.Add(this.useButtonImage);
            this.addButtonBox.Controls.Add(this.label14);
            this.addButtonBox.Controls.Add(this.label13);
            this.addButtonBox.Controls.Add(this.label12);
            this.addButtonBox.Controls.Add(this.buttonHeightTextBox);
            this.addButtonBox.Controls.Add(this.buttonWidthTextBox);
            this.addButtonBox.Controls.Add(this.useButtonSizeDefaults);
            this.addButtonBox.Controls.Add(this.label11);
            this.addButtonBox.Controls.Add(this.label10);
            this.addButtonBox.Controls.Add(this.label9);
            this.addButtonBox.Controls.Add(this.buttonYLocTextBox);
            this.addButtonBox.Controls.Add(this.buttonXLocTextBox);
            this.addButtonBox.Controls.Add(this.useButtonLocationDefaults);
            this.addButtonBox.Controls.Add(this.chooseButtonImageButton);
            this.addButtonBox.Controls.Add(this.buttonPictureBox);
            this.addButtonBox.Location = new System.Drawing.Point(143, 153);
            this.addButtonBox.Name = "addButtonBox";
            this.addButtonBox.Size = new System.Drawing.Size(330, 363);
            this.addButtonBox.TabIndex = 46;
            this.addButtonBox.TabStop = false;
            this.addButtonBox.Text = "Add Button";
            this.addButtonBox.Enter += new System.EventHandler(this.addButtonBox_Enter);
            // 
            // targetNavigableBox
            // 
            this.targetNavigableBox.Controls.Add(this.hubFromButtonRadio);
            this.targetNavigableBox.Controls.Add(this.navComboBox);
            this.targetNavigableBox.Controls.Add(this.pathGroupFromButtonRadio);
            this.targetNavigableBox.Controls.Add(this.pathFromButtonRadio);
            this.targetNavigableBox.Location = new System.Drawing.Point(7, 62);
            this.targetNavigableBox.Name = "targetNavigableBox";
            this.targetNavigableBox.Size = new System.Drawing.Size(241, 85);
            this.targetNavigableBox.TabIndex = 54;
            this.targetNavigableBox.TabStop = false;
            this.targetNavigableBox.Text = "Target Navigable";
            // 
            // hubFromButtonRadio
            // 
            this.hubFromButtonRadio.AutoSize = true;
            this.hubFromButtonRadio.Location = new System.Drawing.Point(6, 64);
            this.hubFromButtonRadio.Name = "hubFromButtonRadio";
            this.hubFromButtonRadio.Size = new System.Drawing.Size(45, 17);
            this.hubFromButtonRadio.TabIndex = 3;
            this.hubFromButtonRadio.TabStop = true;
            this.hubFromButtonRadio.Text = "Hub";
            this.hubFromButtonRadio.UseVisualStyleBackColor = true;
            // 
            // navComboBox
            // 
            this.navComboBox.FormattingEnabled = true;
            this.navComboBox.Location = new System.Drawing.Point(114, 15);
            this.navComboBox.Name = "navComboBox";
            this.navComboBox.Size = new System.Drawing.Size(121, 21);
            this.navComboBox.TabIndex = 4;
            // 
            // pathGroupFromButtonRadio
            // 
            this.pathGroupFromButtonRadio.AutoSize = true;
            this.pathGroupFromButtonRadio.Location = new System.Drawing.Point(6, 41);
            this.pathGroupFromButtonRadio.Name = "pathGroupFromButtonRadio";
            this.pathGroupFromButtonRadio.Size = new System.Drawing.Size(79, 17);
            this.pathGroupFromButtonRadio.TabIndex = 2;
            this.pathGroupFromButtonRadio.TabStop = true;
            this.pathGroupFromButtonRadio.Text = "Path Group";
            this.pathGroupFromButtonRadio.UseVisualStyleBackColor = true;
            // 
            // pathFromButtonRadio
            // 
            this.pathFromButtonRadio.AutoSize = true;
            this.pathFromButtonRadio.Location = new System.Drawing.Point(6, 19);
            this.pathFromButtonRadio.Name = "pathFromButtonRadio";
            this.pathFromButtonRadio.Size = new System.Drawing.Size(47, 17);
            this.pathFromButtonRadio.TabIndex = 1;
            this.pathFromButtonRadio.TabStop = true;
            this.pathFromButtonRadio.Text = "Path";
            this.pathFromButtonRadio.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(211, 335);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 57;
            this.deleteButton.Text = "Delete Button";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonButton_Click);
            // 
            // createButtonButton
            // 
            this.createButtonButton.Location = new System.Drawing.Point(211, 306);
            this.createButtonButton.Name = "createButtonButton";
            this.createButtonButton.Size = new System.Drawing.Size(111, 23);
            this.createButtonButton.TabIndex = 55;
            this.createButtonButton.Text = "Create/Edit Button";
            this.createButtonButton.UseVisualStyleBackColor = true;
            this.createButtonButton.Click += new System.EventHandler(this.createButtonButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Button Text";
            // 
            // buttonTextTextBox
            // 
            this.buttonTextTextBox.Location = new System.Drawing.Point(7, 36);
            this.buttonTextTextBox.Multiline = true;
            this.buttonTextTextBox.Name = "buttonTextTextBox";
            this.buttonTextTextBox.Size = new System.Drawing.Size(241, 20);
            this.buttonTextTextBox.TabIndex = 53;
            // 
            // useButtonImage
            // 
            this.useButtonImage.AutoSize = true;
            this.useButtonImage.Location = new System.Drawing.Point(211, 153);
            this.useButtonImage.Name = "useButtonImage";
            this.useButtonImage.Size = new System.Drawing.Size(114, 17);
            this.useButtonImage.TabIndex = 48;
            this.useButtonImage.Text = "Use Button Image ";
            this.useButtonImage.UseVisualStyleBackColor = true;
            this.useButtonImage.CheckedChanged += new System.EventHandler(this.useButtonImage_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(24, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Use Custom Picture Size (in Pixels)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(29, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(29, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Width:";
            // 
            // buttonHeightTextBox
            // 
            this.buttonHeightTextBox.Enabled = false;
            this.buttonHeightTextBox.Location = new System.Drawing.Point(69, 217);
            this.buttonHeightTextBox.Name = "buttonHeightTextBox";
            this.buttonHeightTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonHeightTextBox.TabIndex = 44;
            // 
            // buttonWidthTextBox
            // 
            this.buttonWidthTextBox.Enabled = false;
            this.buttonWidthTextBox.Location = new System.Drawing.Point(69, 191);
            this.buttonWidthTextBox.Name = "buttonWidthTextBox";
            this.buttonWidthTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonWidthTextBox.TabIndex = 42;
            // 
            // useButtonSizeDefaults
            // 
            this.useButtonSizeDefaults.AutoSize = true;
            this.useButtonSizeDefaults.Checked = true;
            this.useButtonSizeDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useButtonSizeDefaults.Location = new System.Drawing.Point(8, 154);
            this.useButtonSizeDefaults.Name = "useButtonSizeDefaults";
            this.useButtonSizeDefaults.Size = new System.Drawing.Size(144, 17);
            this.useButtonSizeDefaults.TabIndex = 40;
            this.useButtonSizeDefaults.Text = "Use Button Size Defaults";
            this.useButtonSizeDefaults.UseVisualStyleBackColor = true;
            this.useButtonSizeDefaults.CheckedChanged += new System.EventHandler(this.useButtonSizeDefaults_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(24, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(24, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(24, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Coords for center of Button";
            // 
            // buttonYLocTextBox
            // 
            this.buttonYLocTextBox.Enabled = false;
            this.buttonYLocTextBox.Location = new System.Drawing.Point(40, 313);
            this.buttonYLocTextBox.Name = "buttonYLocTextBox";
            this.buttonYLocTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonYLocTextBox.TabIndex = 47;
            // 
            // buttonXLocTextBox
            // 
            this.buttonXLocTextBox.Enabled = false;
            this.buttonXLocTextBox.Location = new System.Drawing.Point(40, 287);
            this.buttonXLocTextBox.Name = "buttonXLocTextBox";
            this.buttonXLocTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonXLocTextBox.TabIndex = 46;
            // 
            // useButtonLocationDefaults
            // 
            this.useButtonLocationDefaults.AutoSize = true;
            this.useButtonLocationDefaults.Checked = true;
            this.useButtonLocationDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useButtonLocationDefaults.Location = new System.Drawing.Point(8, 251);
            this.useButtonLocationDefaults.Name = "useButtonLocationDefaults";
            this.useButtonLocationDefaults.Size = new System.Drawing.Size(165, 17);
            this.useButtonLocationDefaults.TabIndex = 45;
            this.useButtonLocationDefaults.Text = "Use Button Location Defaults";
            this.useButtonLocationDefaults.UseVisualStyleBackColor = true;
            this.useButtonLocationDefaults.CheckedChanged += new System.EventHandler(this.useButtonLocationDefaults_CheckedChanged);
            // 
            // chooseButtonImageButton
            // 
            this.chooseButtonImageButton.Enabled = false;
            this.chooseButtonImageButton.Location = new System.Drawing.Point(179, 232);
            this.chooseButtonImageButton.Name = "chooseButtonImageButton";
            this.chooseButtonImageButton.Size = new System.Drawing.Size(132, 25);
            this.chooseButtonImageButton.TabIndex = 50;
            this.chooseButtonImageButton.Text = "Choose Button Image";
            this.chooseButtonImageButton.UseVisualStyleBackColor = true;
            this.chooseButtonImageButton.Click += new System.EventHandler(this.setButtonImageButton_Click);
            // 
            // buttonPictureBox
            // 
            this.buttonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPictureBox.Enabled = false;
            this.buttonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("buttonPictureBox.Image")));
            this.buttonPictureBox.InitialImage = null;
            this.buttonPictureBox.Location = new System.Drawing.Point(211, 176);
            this.buttonPictureBox.Name = "buttonPictureBox";
            this.buttonPictureBox.Size = new System.Drawing.Size(100, 50);
            this.buttonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonPictureBox.TabIndex = 38;
            this.buttonPictureBox.TabStop = false;
            // 
            // EditHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 521);
            this.Controls.Add(this.addButtonBox);
            this.Controls.Add(this.hubImageBox);
            this.Controls.Add(this.buttonListDownButton);
            this.Controls.Add(this.buttonListUpButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.tableLayoutPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EditHubForm";
            this.Text = "Edit Hub";
            this.Load += new System.EventHandler(this.EditHubForm_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.hubImageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hubImagePictureBox)).EndInit();
            this.addButtonBox.ResumeLayout(false);
            this.addButtonBox.PerformLayout();
            this.targetNavigableBox.ResumeLayout(false);
            this.targetNavigableBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox buttonListBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonListUpButton;
        private System.Windows.Forms.Button buttonListDownButton;
        private System.Windows.Forms.GroupBox hubImageBox;
        private System.Windows.Forms.PictureBox hubImagePictureBox;
        private System.Windows.Forms.Button addHubImageButton;
        private System.Windows.Forms.Button chooseHubImageButton;
        private System.Windows.Forms.GroupBox addButtonBox;
        private System.Windows.Forms.GroupBox targetNavigableBox;
        private System.Windows.Forms.RadioButton hubFromButtonRadio;
        private System.Windows.Forms.ComboBox navComboBox;
        private System.Windows.Forms.RadioButton pathGroupFromButtonRadio;
        private System.Windows.Forms.RadioButton pathFromButtonRadio;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button createButtonButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox buttonTextTextBox;
        private System.Windows.Forms.CheckBox useButtonImage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox buttonHeightTextBox;
        private System.Windows.Forms.TextBox buttonWidthTextBox;
        private System.Windows.Forms.CheckBox useButtonSizeDefaults;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox buttonYLocTextBox;
        private System.Windows.Forms.TextBox buttonXLocTextBox;
        private System.Windows.Forms.CheckBox useButtonLocationDefaults;
        private System.Windows.Forms.Button chooseButtonImageButton;
        private System.Windows.Forms.PictureBox buttonPictureBox;
    }
}