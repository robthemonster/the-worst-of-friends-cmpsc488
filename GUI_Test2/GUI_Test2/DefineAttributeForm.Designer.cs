﻿namespace GUI_Test2
{
    partial class DefineAttributeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefineAttributeForm));
            this.addAttributeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.oKButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.scopeAttributesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.initialValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.allHubCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.globalRadioButton = new System.Windows.Forms.RadioButton();
            this.playerRadioButton = new System.Windows.Forms.RadioButton();
            this.hubRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hubSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.scopeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialValueNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAttributeButton
            // 
            this.addAttributeButton.Location = new System.Drawing.Point(304, 257);
            this.addAttributeButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAttributeButton.Name = "addAttributeButton";
            this.addAttributeButton.Size = new System.Drawing.Size(77, 28);
            this.addAttributeButton.TabIndex = 17;
            this.addAttributeButton.Text = "Add/Edit";
            this.addAttributeButton.UseVisualStyleBackColor = true;
            this.addAttributeButton.Click += new System.EventHandler(this.addAttributeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(389, 257);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 28);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // oKButton
            // 
            this.oKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.oKButton.Location = new System.Drawing.Point(412, 294);
            this.oKButton.Margin = new System.Windows.Forms.Padding(4);
            this.oKButton.Name = "oKButton";
            this.oKButton.Size = new System.Drawing.Size(100, 28);
            this.oKButton.TabIndex = 14;
            this.oKButton.Text = "OK";
            this.oKButton.UseVisualStyleBackColor = true;
            this.oKButton.Click += new System.EventHandler(this.oKButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Attributes In Scope:";
            // 
            // scopeAttributesListBox
            // 
            this.scopeAttributesListBox.FormattingEnabled = true;
            this.scopeAttributesListBox.HorizontalScrollbar = true;
            this.scopeAttributesListBox.ItemHeight = 16;
            this.scopeAttributesListBox.Location = new System.Drawing.Point(16, 62);
            this.scopeAttributesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.scopeAttributesListBox.Name = "scopeAttributesListBox";
            this.scopeAttributesListBox.Size = new System.Drawing.Size(133, 260);
            this.scopeAttributesListBox.TabIndex = 11;
            this.scopeAttributesListBox.SelectedIndexChanged += new System.EventHandler(this.scopeAttributesListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.initialValueNumericUpDown);
            this.groupBox1.Controls.Add(this.allHubCheckBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(171, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(341, 103);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attribute Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Initial Value";
            // 
            // initialValueNumericUpDown
            // 
            this.initialValueNumericUpDown.Location = new System.Drawing.Point(204, 42);
            this.initialValueNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.initialValueNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.initialValueNumericUpDown.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.initialValueNumericUpDown.Name = "initialValueNumericUpDown";
            this.initialValueNumericUpDown.Size = new System.Drawing.Size(111, 22);
            this.initialValueNumericUpDown.TabIndex = 19;
            // 
            // allHubCheckBox
            // 
            this.allHubCheckBox.AutoSize = true;
            this.allHubCheckBox.Enabled = false;
            this.allHubCheckBox.Location = new System.Drawing.Point(8, 75);
            this.allHubCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.allHubCheckBox.Name = "allHubCheckBox";
            this.allHubCheckBox.Size = new System.Drawing.Size(136, 21);
            this.allHubCheckBox.TabIndex = 24;
            this.allHubCheckBox.Text = "Apply to all Hubs";
            this.allHubCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(8, 41);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(187, 22);
            this.nameTextBox.TabIndex = 19;
            // 
            // globalRadioButton
            // 
            this.globalRadioButton.AutoSize = true;
            this.globalRadioButton.Location = new System.Drawing.Point(4, 4);
            this.globalRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.globalRadioButton.Name = "globalRadioButton";
            this.globalRadioButton.Size = new System.Drawing.Size(70, 18);
            this.globalRadioButton.TabIndex = 1;
            this.globalRadioButton.Text = "Global";
            this.globalRadioButton.UseVisualStyleBackColor = true;
            this.globalRadioButton.CheckedChanged += new System.EventHandler(this.globalRadioButton_CheckedChanged);
            // 
            // playerRadioButton
            // 
            this.playerRadioButton.AutoSize = true;
            this.playerRadioButton.Location = new System.Drawing.Point(4, 56);
            this.playerRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.playerRadioButton.Name = "playerRadioButton";
            this.playerRadioButton.Size = new System.Drawing.Size(69, 20);
            this.playerRadioButton.TabIndex = 0;
            this.playerRadioButton.Text = "Player";
            this.playerRadioButton.UseVisualStyleBackColor = true;
            this.playerRadioButton.CheckedChanged += new System.EventHandler(this.playerRadioButton_CheckedChanged);
            // 
            // hubRadioButton
            // 
            this.hubRadioButton.AutoSize = true;
            this.hubRadioButton.Location = new System.Drawing.Point(4, 30);
            this.hubRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.hubRadioButton.Name = "hubRadioButton";
            this.hubRadioButton.Size = new System.Drawing.Size(55, 18);
            this.hubRadioButton.TabIndex = 23;
            this.hubRadioButton.Text = "Hub";
            this.hubRadioButton.UseVisualStyleBackColor = true;
            this.hubRadioButton.CheckedChanged += new System.EventHandler(this.hubRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.globalRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hubRadioButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.playerRadioButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.hubSelectionComboBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 80);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // hubSelectionComboBox
            // 
            this.hubSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hubSelectionComboBox.Enabled = false;
            this.hubSelectionComboBox.FormattingEnabled = true;
            this.hubSelectionComboBox.Location = new System.Drawing.Point(150, 30);
            this.hubSelectionComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.hubSelectionComboBox.Name = "hubSelectionComboBox";
            this.hubSelectionComboBox.Size = new System.Drawing.Size(165, 24);
            this.hubSelectionComboBox.TabIndex = 26;
            this.hubSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.hubSelectionComboBox_SelectedIndexChanged);
            // 
            // scopeTextBox
            // 
            this.scopeTextBox.Location = new System.Drawing.Point(16, 30);
            this.scopeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.scopeTextBox.Name = "scopeTextBox";
            this.scopeTextBox.ReadOnly = true;
            this.scopeTextBox.Size = new System.Drawing.Size(133, 22);
            this.scopeTextBox.TabIndex = 19;
            this.scopeTextBox.Text = "Global";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(171, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(341, 113);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scope";
            // 
            // DefineAttributeForm
            // 
            this.AcceptButton = this.addAttributeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.oKButton;
            this.ClientSize = new System.Drawing.Size(520, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.scopeTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addAttributeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.oKButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scopeAttributesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DefineAttributeForm";
            this.Text = "Define Attribute Form";
            this.Load += new System.EventHandler(this.DefineAttributeForm_Load);
            this.Shown += new System.EventHandler(this.globalRadioButton_CheckedChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialValueNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAttributeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button oKButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox scopeAttributesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton globalRadioButton;
        private System.Windows.Forms.RadioButton playerRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown initialValueNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton hubRadioButton;
        private System.Windows.Forms.CheckBox allHubCheckBox;
        private System.Windows.Forms.ComboBox hubSelectionComboBox;
        private System.Windows.Forms.TextBox scopeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}