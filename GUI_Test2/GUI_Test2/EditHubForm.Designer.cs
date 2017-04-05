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
            this.addHubImageButton = new System.Windows.Forms.Button();
            this.deleteHubImageButton = new System.Windows.Forms.Button();
            this.hubImagePictureBox = new System.Windows.Forms.PictureBox();
            this.useButtonImage = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hubFromButtonRadio = new System.Windows.Forms.RadioButton();
            this.navComboBox = new System.Windows.Forms.ComboBox();
            this.pathGroupFromButtonRadio = new System.Windows.Forms.RadioButton();
            this.pathFromButtonRadio = new System.Windows.Forms.RadioButton();
            this.buttonListDownButton = new System.Windows.Forms.Button();
            this.buttonListUpButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.createButtonButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonTextTextBox = new System.Windows.Forms.TextBox();
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
            this.setButtonImageButton = new System.Windows.Forms.Button();
            this.buttonPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonListBox = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hubImagePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPictureBox)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // addHubImageButton
            // 
            this.addHubImageButton.Location = new System.Drawing.Point(393, 71);
            this.addHubImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.addHubImageButton.Name = "addHubImageButton";
            this.addHubImageButton.Size = new System.Drawing.Size(111, 19);
            this.addHubImageButton.TabIndex = 1;
            this.addHubImageButton.Text = "Add Hub Image";
            this.addHubImageButton.UseVisualStyleBackColor = true;
            // 
            // deleteHubImageButton
            // 
            this.deleteHubImageButton.Location = new System.Drawing.Point(393, 94);
            this.deleteHubImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteHubImageButton.Name = "deleteHubImageButton";
            this.deleteHubImageButton.Size = new System.Drawing.Size(111, 19);
            this.deleteHubImageButton.TabIndex = 2;
            this.deleteHubImageButton.Text = "Delete Hub Image";
            this.deleteHubImageButton.UseVisualStyleBackColor = true;
            // 
            // hubImagePictureBox
            // 
            this.hubImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hubImagePictureBox.Image = global::GUI_Test2.Properties.Resources.defaultHub;
            this.hubImagePictureBox.Location = new System.Drawing.Point(9, 10);
            this.hubImagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.hubImagePictureBox.Name = "hubImagePictureBox";
            this.hubImagePictureBox.Size = new System.Drawing.Size(314, 186);
            this.hubImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hubImagePictureBox.TabIndex = 0;
            this.hubImagePictureBox.TabStop = false;
            this.hubImagePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // useButtonImage
            // 
            this.useButtonImage.AutoSize = true;
            this.useButtonImage.Location = new System.Drawing.Point(337, 399);
            this.useButtonImage.Name = "useButtonImage";
            this.useButtonImage.Size = new System.Drawing.Size(114, 17);
            this.useButtonImage.TabIndex = 33;
            this.useButtonImage.Text = "Use Button Image ";
            this.useButtonImage.UseVisualStyleBackColor = true;
            this.useButtonImage.CheckedChanged += new System.EventHandler(this.useButtonImage_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hubFromButtonRadio);
            this.groupBox1.Controls.Add(this.navComboBox);
            this.groupBox1.Controls.Add(this.pathGroupFromButtonRadio);
            this.groupBox1.Controls.Add(this.pathFromButtonRadio);
            this.groupBox1.Location = new System.Drawing.Point(115, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 85);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Nagvigable";
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
            this.pathGroupFromButtonRadio.CheckedChanged += new System.EventHandler(this.pathGroupFromButtonRadio_CheckedChanged);
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
            this.pathFromButtonRadio.CheckedChanged += new System.EventHandler(this.pathFromButtonRadio_CheckedChanged);
            // 
            // buttonListDownButton
            // 
            this.buttonListDownButton.Location = new System.Drawing.Point(109, 480);
            this.buttonListDownButton.Name = "buttonListDownButton";
            this.buttonListDownButton.Size = new System.Drawing.Size(22, 23);
            this.buttonListDownButton.TabIndex = 43;
            this.buttonListDownButton.Text = "▼";
            this.buttonListDownButton.UseVisualStyleBackColor = true;
            this.buttonListDownButton.Click += new System.EventHandler(this.buttonListDownButton_Click);
            // 
            // buttonListUpButton
            // 
            this.buttonListUpButton.Location = new System.Drawing.Point(109, 451);
            this.buttonListUpButton.Name = "buttonListUpButton";
            this.buttonListUpButton.Size = new System.Drawing.Size(22, 23);
            this.buttonListUpButton.TabIndex = 42;
            this.buttonListUpButton.Text = "▲";
            this.buttonListUpButton.UseVisualStyleBackColor = true;
            this.buttonListUpButton.Click += new System.EventHandler(this.buttonListUpButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(485, 485);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 39;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(179, 428);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(111, 23);
            this.deleteButton.TabIndex = 44;
            this.deleteButton.Text = "Delete Button";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(401, 485);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 38;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // createButtonButton
            // 
            this.createButtonButton.Location = new System.Drawing.Point(179, 399);
            this.createButtonButton.Name = "createButtonButton";
            this.createButtonButton.Size = new System.Drawing.Size(111, 23);
            this.createButtonButton.TabIndex = 23;
            this.createButtonButton.Text = "Create/Edit Button";
            this.createButtonButton.UseVisualStyleBackColor = true;
            this.createButtonButton.Click += new System.EventHandler(this.createButtonButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Button Text";
            // 
            // buttonTextTextBox
            // 
            this.buttonTextTextBox.Location = new System.Drawing.Point(115, 224);
            this.buttonTextTextBox.Multiline = true;
            this.buttonTextTextBox.Name = "buttonTextTextBox";
            this.buttonTextTextBox.Size = new System.Drawing.Size(164, 20);
            this.buttonTextTextBox.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(390, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Use Custom Picture Size (in Pixels)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(395, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Height:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(395, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Width:";
            // 
            // buttonHeightTextBox
            // 
            this.buttonHeightTextBox.Enabled = false;
            this.buttonHeightTextBox.Location = new System.Drawing.Point(435, 269);
            this.buttonHeightTextBox.Name = "buttonHeightTextBox";
            this.buttonHeightTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonHeightTextBox.TabIndex = 29;
            // 
            // buttonWidthTextBox
            // 
            this.buttonWidthTextBox.Enabled = false;
            this.buttonWidthTextBox.Location = new System.Drawing.Point(435, 243);
            this.buttonWidthTextBox.Name = "buttonWidthTextBox";
            this.buttonWidthTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonWidthTextBox.TabIndex = 27;
            // 
            // useButtonSizeDefaults
            // 
            this.useButtonSizeDefaults.AutoSize = true;
            this.useButtonSizeDefaults.Checked = true;
            this.useButtonSizeDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useButtonSizeDefaults.Location = new System.Drawing.Point(376, 207);
            this.useButtonSizeDefaults.Name = "useButtonSizeDefaults";
            this.useButtonSizeDefaults.Size = new System.Drawing.Size(144, 17);
            this.useButtonSizeDefaults.TabIndex = 25;
            this.useButtonSizeDefaults.Text = "Use Button Size Defaults";
            this.useButtonSizeDefaults.UseVisualStyleBackColor = true;
            this.useButtonSizeDefaults.CheckedChanged += new System.EventHandler(this.useButtonSizeDefaults_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(390, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(390, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(390, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Coords for center of Button";
            // 
            // buttonYLocTextBox
            // 
            this.buttonYLocTextBox.Enabled = false;
            this.buttonYLocTextBox.Location = new System.Drawing.Point(406, 365);
            this.buttonYLocTextBox.Name = "buttonYLocTextBox";
            this.buttonYLocTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonYLocTextBox.TabIndex = 32;
            // 
            // buttonXLocTextBox
            // 
            this.buttonXLocTextBox.Enabled = false;
            this.buttonXLocTextBox.Location = new System.Drawing.Point(406, 339);
            this.buttonXLocTextBox.Name = "buttonXLocTextBox";
            this.buttonXLocTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonXLocTextBox.TabIndex = 31;
            // 
            // useButtonLocationDefaults
            // 
            this.useButtonLocationDefaults.AutoSize = true;
            this.useButtonLocationDefaults.Checked = true;
            this.useButtonLocationDefaults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useButtonLocationDefaults.Location = new System.Drawing.Point(374, 303);
            this.useButtonLocationDefaults.Name = "useButtonLocationDefaults";
            this.useButtonLocationDefaults.Size = new System.Drawing.Size(165, 17);
            this.useButtonLocationDefaults.TabIndex = 30;
            this.useButtonLocationDefaults.Text = "Use Button Location Defaults";
            this.useButtonLocationDefaults.UseVisualStyleBackColor = true;
            this.useButtonLocationDefaults.CheckedChanged += new System.EventHandler(this.useButtonLocationDefaults_CheckedChanged);
            // 
            // setButtonImageButton
            // 
            this.setButtonImageButton.Enabled = false;
            this.setButtonImageButton.Location = new System.Drawing.Point(349, 431);
            this.setButtonImageButton.Name = "setButtonImageButton";
            this.setButtonImageButton.Size = new System.Drawing.Size(101, 28);
            this.setButtonImageButton.TabIndex = 35;
            this.setButtonImageButton.Text = "Set Button Image";
            this.setButtonImageButton.UseVisualStyleBackColor = true;
            // 
            // buttonPictureBox
            // 
            this.buttonPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPictureBox.Enabled = false;
            this.buttonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("buttonPictureBox.Image")));
            this.buttonPictureBox.InitialImage = null;
            this.buttonPictureBox.Location = new System.Drawing.Point(456, 420);
            this.buttonPictureBox.Name = "buttonPictureBox";
            this.buttonPictureBox.Size = new System.Drawing.Size(100, 50);
            this.buttonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonPictureBox.TabIndex = 21;
            this.buttonPictureBox.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonListBox, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(9, 201);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.384164F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 281F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(97, 307);
            this.tableLayoutPanel4.TabIndex = 41;
            // 
            // buttonListBox
            // 
            this.buttonListBox.FormattingEnabled = true;
            this.buttonListBox.Location = new System.Drawing.Point(3, 29);
            this.buttonListBox.Name = "buttonListBox";
            this.buttonListBox.Size = new System.Drawing.Size(91, 264);
            this.buttonListBox.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Current Buttons";
            // 
            // EditHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 515);
            this.Controls.Add(this.useButtonImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonListDownButton);
            this.Controls.Add(this.buttonListUpButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.createButtonButton);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonTextTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonHeightTextBox);
            this.Controls.Add(this.buttonWidthTextBox);
            this.Controls.Add(this.useButtonSizeDefaults);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonYLocTextBox);
            this.Controls.Add(this.buttonXLocTextBox);
            this.Controls.Add(this.useButtonLocationDefaults);
            this.Controls.Add(this.setButtonImageButton);
            this.Controls.Add(this.buttonPictureBox);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.deleteHubImageButton);
            this.Controls.Add(this.addHubImageButton);
            this.Controls.Add(this.hubImagePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EditHubForm";
            this.Text = "Edit Hub";
            this.Load += new System.EventHandler(this.EditHubForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hubImagePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPictureBox)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hubImagePictureBox;
        private System.Windows.Forms.Button addHubImageButton;
        private System.Windows.Forms.Button deleteHubImageButton;
        private System.Windows.Forms.ListBox buttonListBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox buttonPictureBox;
        private System.Windows.Forms.Button setButtonImageButton;
        private System.Windows.Forms.CheckBox useButtonLocationDefaults;
        private System.Windows.Forms.TextBox buttonXLocTextBox;
        private System.Windows.Forms.TextBox buttonYLocTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox useButtonSizeDefaults;
        private System.Windows.Forms.TextBox buttonWidthTextBox;
        private System.Windows.Forms.TextBox buttonHeightTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox buttonTextTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button createButtonButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button buttonListUpButton;
        private System.Windows.Forms.Button buttonListDownButton;
        private System.Windows.Forms.RadioButton pathFromButtonRadio;
        private System.Windows.Forms.RadioButton pathGroupFromButtonRadio;
        private System.Windows.Forms.ComboBox navComboBox;
        private System.Windows.Forms.RadioButton hubFromButtonRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox useButtonImage;
    }
}