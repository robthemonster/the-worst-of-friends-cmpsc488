namespace GUI_Test2
{
    partial class EditGameSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGameSettings));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GameOverReqsListBox = new System.Windows.Forms.ListBox();
            this.removeRequirementButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hubComboBox = new System.Windows.Forms.ComboBox();
            this.hubLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.GOGlobalRadioButton = new System.Windows.Forms.RadioButton();
            this.GOHubRadioButton = new System.Windows.Forms.RadioButton();
            this.GOPlayerRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.comparitorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addRequirementButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.playerAttributesBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removePlayerAttributeVisibleButton = new System.Windows.Forms.Button();
            this.addPlayerAttributeVisibleButton = new System.Windows.Forms.Button();
            this.visiblePlayerAttributesListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeGlobalAttributeVisibleButton = new System.Windows.Forms.Button();
            this.addGlobalAttributeVisibleButton = new System.Windows.Forms.Button();
            this.visibleGlobalAttributesListBox = new System.Windows.Forms.ListBox();
            this.globalAttributesBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roundStartNavBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.roundEndNavBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musicBox = new System.Windows.Forms.GroupBox();
            this.useMusic = new System.Windows.Forms.CheckBox();
            this.defaultFontButton = new System.Windows.Forms.Button();
            this.defaultDialoguePaneTextureButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseScrollSoundButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonXLocTextBox = new System.Windows.Forms.TextBox();
            this.buttonYLocTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxPlayerCountTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.musicBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GameOverReqsListBox);
            this.groupBox4.Controls.Add(this.removeRequirementButton);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Controls.Add(this.addRequirementButton);
            this.groupBox4.Location = new System.Drawing.Point(7, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 166);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Game Over Requirements";
            // 
            // GameOverReqsListBox
            // 
            this.GameOverReqsListBox.FormattingEnabled = true;
            this.GameOverReqsListBox.Location = new System.Drawing.Point(235, 19);
            this.GameOverReqsListBox.Name = "GameOverReqsListBox";
            this.GameOverReqsListBox.Size = new System.Drawing.Size(78, 134);
            this.GameOverReqsListBox.TabIndex = 38;
            this.GameOverReqsListBox.SelectedIndexChanged += new System.EventHandler(this.GameOverReqsListBox_SelectedIndexChanged);
            // 
            // removeRequirementButton
            // 
            this.removeRequirementButton.Location = new System.Drawing.Point(315, 87);
            this.removeRequirementButton.Name = "removeRequirementButton";
            this.removeRequirementButton.Size = new System.Drawing.Size(101, 23);
            this.removeRequirementButton.TabIndex = 37;
            this.removeRequirementButton.Text = "Remove Condition";
            this.removeRequirementButton.UseVisualStyleBackColor = true;
            this.removeRequirementButton.Click += new System.EventHandler(this.removeRequirementButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hubComboBox);
            this.groupBox5.Controls.Add(this.hubLabel);
            this.groupBox5.Controls.Add(this.tableLayoutPanel3);
            this.groupBox5.Location = new System.Drawing.Point(8, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 83);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Attribute Scope";
            // 
            // hubComboBox
            // 
            this.hubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hubComboBox.Enabled = false;
            this.hubComboBox.FormattingEnabled = true;
            this.hubComboBox.Location = new System.Drawing.Point(113, 38);
            this.hubComboBox.Name = "hubComboBox";
            this.hubComboBox.Size = new System.Drawing.Size(91, 21);
            this.hubComboBox.TabIndex = 2;
            this.hubComboBox.SelectedIndexChanged += new System.EventHandler(this.hubComboBox_SelectedIndexChanged);
            // 
            // hubLabel
            // 
            this.hubLabel.AutoSize = true;
            this.hubLabel.Enabled = false;
            this.hubLabel.Location = new System.Drawing.Point(117, 22);
            this.hubLabel.Name = "hubLabel";
            this.hubLabel.Size = new System.Drawing.Size(60, 13);
            this.hubLabel.TabIndex = 1;
            this.hubLabel.Text = "Hub Select";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.GOGlobalRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.GOHubRadioButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.GOPlayerRadioButton, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(90, 68);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // GOGlobalRadioButton
            // 
            this.GOGlobalRadioButton.AutoSize = true;
            this.GOGlobalRadioButton.Location = new System.Drawing.Point(3, 3);
            this.GOGlobalRadioButton.Name = "GOGlobalRadioButton";
            this.GOGlobalRadioButton.Size = new System.Drawing.Size(55, 15);
            this.GOGlobalRadioButton.TabIndex = 0;
            this.GOGlobalRadioButton.TabStop = true;
            this.GOGlobalRadioButton.Text = "Global";
            this.GOGlobalRadioButton.UseVisualStyleBackColor = true;
            this.GOGlobalRadioButton.CheckedChanged += new System.EventHandler(this.GOGlobalRadioButton_CheckedChanged);
            // 
            // GOHubRadioButton
            // 
            this.GOHubRadioButton.AutoSize = true;
            this.GOHubRadioButton.Location = new System.Drawing.Point(3, 24);
            this.GOHubRadioButton.Name = "GOHubRadioButton";
            this.GOHubRadioButton.Size = new System.Drawing.Size(45, 15);
            this.GOHubRadioButton.TabIndex = 1;
            this.GOHubRadioButton.TabStop = true;
            this.GOHubRadioButton.Text = "Hub";
            this.GOHubRadioButton.UseVisualStyleBackColor = true;
            this.GOHubRadioButton.CheckedChanged += new System.EventHandler(this.GOHubRadioButton_CheckedChanged);
            // 
            // GOPlayerRadioButton
            // 
            this.GOPlayerRadioButton.AutoSize = true;
            this.GOPlayerRadioButton.Location = new System.Drawing.Point(3, 45);
            this.GOPlayerRadioButton.Name = "GOPlayerRadioButton";
            this.GOPlayerRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GOPlayerRadioButton.TabIndex = 2;
            this.GOPlayerRadioButton.TabStop = true;
            this.GOPlayerRadioButton.Text = "Player";
            this.GOPlayerRadioButton.UseVisualStyleBackColor = true;
            this.GOPlayerRadioButton.CheckedChanged += new System.EventHandler(this.GOPlayerRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.Controls.Add(this.valueTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.attributeComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comparitorComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 48);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(167, 21);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(47, 20);
            this.valueTextBox.TabIndex = 33;
            this.valueTextBox.Text = "0";
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Location = new System.Drawing.Point(3, 21);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(85, 21);
            this.attributeComboBox.TabIndex = 24;
            // 
            // comparitorComboBox
            // 
            this.comparitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comparitorComboBox.FormattingEnabled = true;
            this.comparitorComboBox.Location = new System.Drawing.Point(98, 21);
            this.comparitorComboBox.Name = "comparitorComboBox";
            this.comparitorComboBox.Size = new System.Drawing.Size(61, 21);
            this.comparitorComboBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Comparison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Attribute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Value";
            // 
            // addRequirementButton
            // 
            this.addRequirementButton.Location = new System.Drawing.Point(315, 57);
            this.addRequirementButton.Name = "addRequirementButton";
            this.addRequirementButton.Size = new System.Drawing.Size(101, 25);
            this.addRequirementButton.TabIndex = 24;
            this.addRequirementButton.Text = "Add Requirement";
            this.addRequirementButton.UseVisualStyleBackColor = true;
            this.addRequirementButton.Click += new System.EventHandler(this.addRequirementButton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(206, 21);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 16;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(287, 21);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // playerAttributesBox
            // 
            this.playerAttributesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerAttributesBox.FormattingEnabled = true;
            this.playerAttributesBox.Location = new System.Drawing.Point(6, 35);
            this.playerAttributesBox.Name = "playerAttributesBox";
            this.playerAttributesBox.Size = new System.Drawing.Size(88, 21);
            this.playerAttributesBox.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Player Attributes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removePlayerAttributeVisibleButton);
            this.groupBox1.Controls.Add(this.addPlayerAttributeVisibleButton);
            this.groupBox1.Controls.Add(this.visiblePlayerAttributesListBox);
            this.groupBox1.Controls.Add(this.playerAttributesBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 121);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visible Player Attributes";
            // 
            // removePlayerAttributeVisibleButton
            // 
            this.removePlayerAttributeVisibleButton.Location = new System.Drawing.Point(6, 87);
            this.removePlayerAttributeVisibleButton.Name = "removePlayerAttributeVisibleButton";
            this.removePlayerAttributeVisibleButton.Size = new System.Drawing.Size(91, 22);
            this.removePlayerAttributeVisibleButton.TabIndex = 41;
            this.removePlayerAttributeVisibleButton.Text = "Remove Condition";
            this.removePlayerAttributeVisibleButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerAttributeVisibleButton
            // 
            this.addPlayerAttributeVisibleButton.Location = new System.Drawing.Point(6, 61);
            this.addPlayerAttributeVisibleButton.Name = "addPlayerAttributeVisibleButton";
            this.addPlayerAttributeVisibleButton.Size = new System.Drawing.Size(91, 22);
            this.addPlayerAttributeVisibleButton.TabIndex = 40;
            this.addPlayerAttributeVisibleButton.Text = "Add Attribute";
            this.addPlayerAttributeVisibleButton.UseVisualStyleBackColor = true;
            // 
            // visiblePlayerAttributesListBox
            // 
            this.visiblePlayerAttributesListBox.FormattingEnabled = true;
            this.visiblePlayerAttributesListBox.Location = new System.Drawing.Point(103, 18);
            this.visiblePlayerAttributesListBox.Name = "visiblePlayerAttributesListBox";
            this.visiblePlayerAttributesListBox.Size = new System.Drawing.Size(78, 95);
            this.visiblePlayerAttributesListBox.TabIndex = 39;
            this.visiblePlayerAttributesListBox.SelectedIndexChanged += new System.EventHandler(this.visiblePlayerAttributesListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeGlobalAttributeVisibleButton);
            this.groupBox2.Controls.Add(this.addGlobalAttributeVisibleButton);
            this.groupBox2.Controls.Add(this.visibleGlobalAttributesListBox);
            this.groupBox2.Controls.Add(this.globalAttributesBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(7, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 121);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visible Global Attributes";
            // 
            // removeGlobalAttributeVisibleButton
            // 
            this.removeGlobalAttributeVisibleButton.Location = new System.Drawing.Point(6, 87);
            this.removeGlobalAttributeVisibleButton.Name = "removeGlobalAttributeVisibleButton";
            this.removeGlobalAttributeVisibleButton.Size = new System.Drawing.Size(91, 22);
            this.removeGlobalAttributeVisibleButton.TabIndex = 41;
            this.removeGlobalAttributeVisibleButton.Text = "Remove Condition";
            this.removeGlobalAttributeVisibleButton.UseVisualStyleBackColor = true;
            // 
            // addGlobalAttributeVisibleButton
            // 
            this.addGlobalAttributeVisibleButton.Location = new System.Drawing.Point(6, 61);
            this.addGlobalAttributeVisibleButton.Name = "addGlobalAttributeVisibleButton";
            this.addGlobalAttributeVisibleButton.Size = new System.Drawing.Size(91, 22);
            this.addGlobalAttributeVisibleButton.TabIndex = 40;
            this.addGlobalAttributeVisibleButton.Text = "Add Attribute";
            this.addGlobalAttributeVisibleButton.UseVisualStyleBackColor = true;
            // 
            // visibleGlobalAttributesListBox
            // 
            this.visibleGlobalAttributesListBox.FormattingEnabled = true;
            this.visibleGlobalAttributesListBox.Location = new System.Drawing.Point(103, 18);
            this.visibleGlobalAttributesListBox.Name = "visibleGlobalAttributesListBox";
            this.visibleGlobalAttributesListBox.Size = new System.Drawing.Size(78, 95);
            this.visibleGlobalAttributesListBox.TabIndex = 39;
            this.visibleGlobalAttributesListBox.SelectedIndexChanged += new System.EventHandler(this.visibleGlobalAttributesListBox_SelectedIndexChanged);
            // 
            // globalAttributesBox
            // 
            this.globalAttributesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.globalAttributesBox.FormattingEnabled = true;
            this.globalAttributesBox.Location = new System.Drawing.Point(6, 35);
            this.globalAttributesBox.Name = "globalAttributesBox";
            this.globalAttributesBox.Size = new System.Drawing.Size(88, 21);
            this.globalAttributesBox.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Global Attributes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Start of Round Path Group";
            // 
            // roundStartNavBox
            // 
            this.roundStartNavBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundStartNavBox.FormattingEnabled = true;
            this.roundStartNavBox.Location = new System.Drawing.Point(205, 66);
            this.roundStartNavBox.Name = "roundStartNavBox";
            this.roundStartNavBox.Size = new System.Drawing.Size(121, 21);
            this.roundStartNavBox.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "End of Round Path Group";
            // 
            // roundEndNavBox
            // 
            this.roundEndNavBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundEndNavBox.FormattingEnabled = true;
            this.roundEndNavBox.Location = new System.Drawing.Point(205, 109);
            this.roundEndNavBox.Name = "roundEndNavBox";
            this.roundEndNavBox.Size = new System.Drawing.Size(121, 21);
            this.roundEndNavBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Font";
            // 
            // musicBox
            // 
            this.musicBox.Controls.Add(this.useMusic);
            this.musicBox.Location = new System.Drawing.Point(203, 212);
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(177, 48);
            this.musicBox.TabIndex = 49;
            this.musicBox.TabStop = false;
            this.musicBox.Text = "Play Button Sound (Optional)";
            // 
            // useMusic
            // 
            this.useMusic.AutoSize = true;
            this.useMusic.Location = new System.Drawing.Point(28, 19);
            this.useMusic.Name = "useMusic";
            this.useMusic.Size = new System.Drawing.Size(136, 17);
            this.useMusic.TabIndex = 1;
            this.useMusic.Text = "Use Play Button Sound";
            this.useMusic.UseVisualStyleBackColor = true;
            this.useMusic.CheckedChanged += new System.EventHandler(this.useMusic_CheckedChanged);
            // 
            // defaultFontButton
            // 
            this.defaultFontButton.Location = new System.Drawing.Point(29, 69);
            this.defaultFontButton.Name = "defaultFontButton";
            this.defaultFontButton.Size = new System.Drawing.Size(77, 23);
            this.defaultFontButton.TabIndex = 50;
            this.defaultFontButton.Text = "Choose Font";
            this.defaultFontButton.UseVisualStyleBackColor = true;
            this.defaultFontButton.Click += new System.EventHandler(this.defaultFontButton_Click);
            // 
            // defaultDialoguePaneTextureButton
            // 
            this.defaultDialoguePaneTextureButton.Location = new System.Drawing.Point(6, 111);
            this.defaultDialoguePaneTextureButton.Name = "defaultDialoguePaneTextureButton";
            this.defaultDialoguePaneTextureButton.Size = new System.Drawing.Size(119, 23);
            this.defaultDialoguePaneTextureButton.TabIndex = 52;
            this.defaultDialoguePaneTextureButton.Text = "Choose Pane Texture";
            this.defaultDialoguePaneTextureButton.UseVisualStyleBackColor = true;
            this.defaultDialoguePaneTextureButton.Click += new System.EventHandler(this.defaultDialoguePaneTextureButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Pane Texture";
            // 
            // chooseScrollSoundButton
            // 
            this.chooseScrollSoundButton.Location = new System.Drawing.Point(16, 31);
            this.chooseScrollSoundButton.Name = "chooseScrollSoundButton";
            this.chooseScrollSoundButton.Size = new System.Drawing.Size(114, 23);
            this.chooseScrollSoundButton.TabIndex = 54;
            this.chooseScrollSoundButton.Text = "Choose Scroll Sound";
            this.chooseScrollSoundButton.UseVisualStyleBackColor = true;
            this.chooseScrollSoundButton.Click += new System.EventHandler(this.chooseScrollSoundButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Dialogue Scroll Sound";
            // 
            // buttonXLocTextBox
            // 
            this.buttonXLocTextBox.Enabled = false;
            this.buttonXLocTextBox.Location = new System.Drawing.Point(158, 77);
            this.buttonXLocTextBox.Name = "buttonXLocTextBox";
            this.buttonXLocTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonXLocTextBox.TabIndex = 58;
            // 
            // buttonYLocTextBox
            // 
            this.buttonYLocTextBox.Enabled = false;
            this.buttonYLocTextBox.Location = new System.Drawing.Point(158, 99);
            this.buttonYLocTextBox.Name = "buttonYLocTextBox";
            this.buttonYLocTextBox.Size = new System.Drawing.Size(50, 20);
            this.buttonYLocTextBox.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(136, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Pane Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(135, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(135, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Y:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonXLocTextBox);
            this.groupBox3.Controls.Add(this.defaultDialoguePaneTextureButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chooseScrollSoundButton);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.defaultFontButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.buttonYLocTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(368, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 140);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Default Dialogue Pane Options";
            // 
            // maxPlayerCountTextBox
            // 
            this.maxPlayerCountTextBox.Enabled = false;
            this.maxPlayerCountTextBox.Location = new System.Drawing.Point(231, 164);
            this.maxPlayerCountTextBox.Name = "maxPlayerCountTextBox";
            this.maxPlayerCountTextBox.Size = new System.Drawing.Size(87, 20);
            this.maxPlayerCountTextBox.TabIndex = 62;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(228, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "Max Player Count";
            // 
            // EditGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 558);
            this.Controls.Add(this.maxPlayerCountTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.musicBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.roundStartNavBox);
            this.Controls.Add(this.roundEndNavBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Cancelbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditGameSettings";
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.EditGameSettings_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.musicBox.ResumeLayout(false);
            this.musicBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox GameOverReqsListBox;
        private System.Windows.Forms.Button removeRequirementButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox hubComboBox;
        private System.Windows.Forms.Label hubLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton GOGlobalRadioButton;
        private System.Windows.Forms.RadioButton GOHubRadioButton;
        private System.Windows.Forms.RadioButton GOPlayerRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox attributeComboBox;
        private System.Windows.Forms.ComboBox comparitorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addRequirementButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ComboBox playerAttributesBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox visiblePlayerAttributesListBox;
        private System.Windows.Forms.Button removePlayerAttributeVisibleButton;
        private System.Windows.Forms.Button addPlayerAttributeVisibleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeGlobalAttributeVisibleButton;
        private System.Windows.Forms.Button addGlobalAttributeVisibleButton;
        private System.Windows.Forms.ListBox visibleGlobalAttributesListBox;
        private System.Windows.Forms.ComboBox globalAttributesBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox roundStartNavBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox roundEndNavBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox musicBox;
        private System.Windows.Forms.CheckBox useMusic;
        private System.Windows.Forms.Button defaultFontButton;
        private System.Windows.Forms.Button defaultDialoguePaneTextureButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chooseScrollSoundButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buttonXLocTextBox;
        private System.Windows.Forms.TextBox buttonYLocTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox maxPlayerCountTextBox;
        private System.Windows.Forms.Label label14;
    }
}