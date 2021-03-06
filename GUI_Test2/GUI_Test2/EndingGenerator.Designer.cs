﻿namespace GUI_Test2
{
    partial class EndingGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndingGenerator));
            this.TierLabel = new System.Windows.Forms.Label();
            this.tierComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pathRequirementsListBox = new System.Windows.Forms.ListBox();
            this.removeConditionButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hubComboBox = new System.Windows.Forms.ComboBox();
            this.hubLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.globalRadioButton = new System.Windows.Forms.RadioButton();
            this.hubRadioButton = new System.Windows.Forms.RadioButton();
            this.playerRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.valueNumeric = new System.Windows.Forms.NumericUpDown();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.comparitorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addConditionButton = new System.Windows.Forms.Button();
            this.buttonListRightButton = new System.Windows.Forms.Button();
            this.buttonListLeftButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.unusedPathsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPathsButton = new System.Windows.Forms.Button();
            this.removePathsButton = new System.Windows.Forms.Button();
            this.pathsGroupedByTier = new System.Windows.Forms.ListView();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TierLabel
            // 
            this.TierLabel.AutoSize = true;
            this.TierLabel.Location = new System.Drawing.Point(549, 140);
            this.TierLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TierLabel.Name = "TierLabel";
            this.TierLabel.Size = new System.Drawing.Size(33, 17);
            this.TierLabel.TabIndex = 30;
            this.TierLabel.Text = "Tier";
            // 
            // tierComboBox
            // 
            this.tierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tierComboBox.FormattingEnabled = true;
            this.tierComboBox.Location = new System.Drawing.Point(525, 160);
            this.tierComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tierComboBox.Name = "tierComboBox";
            this.tierComboBox.Size = new System.Drawing.Size(76, 24);
            this.tierComboBox.TabIndex = 29;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pathRequirementsListBox);
            this.groupBox4.Controls.Add(this.removeConditionButton);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Controls.Add(this.addConditionButton);
            this.groupBox4.Location = new System.Drawing.Point(16, 267);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(605, 204);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Requirements";
            // 
            // pathRequirementsListBox
            // 
            this.pathRequirementsListBox.FormattingEnabled = true;
            this.pathRequirementsListBox.HorizontalScrollbar = true;
            this.pathRequirementsListBox.ItemHeight = 16;
            this.pathRequirementsListBox.Location = new System.Drawing.Point(425, 16);
            this.pathRequirementsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pathRequirementsListBox.Name = "pathRequirementsListBox";
            this.pathRequirementsListBox.Size = new System.Drawing.Size(169, 116);
            this.pathRequirementsListBox.TabIndex = 38;
            this.pathRequirementsListBox.SelectedIndexChanged += new System.EventHandler(this.pathRequirementsListBox_SelectedIndexChanged);
            // 
            // removeConditionButton
            // 
            this.removeConditionButton.Location = new System.Drawing.Point(477, 174);
            this.removeConditionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeConditionButton.Name = "removeConditionButton";
            this.removeConditionButton.Size = new System.Drawing.Size(121, 27);
            this.removeConditionButton.TabIndex = 37;
            this.removeConditionButton.Text = "Remove Condition";
            this.removeConditionButton.UseVisualStyleBackColor = true;
            this.removeConditionButton.Click += new System.EventHandler(this.removeConditionButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hubComboBox);
            this.groupBox5.Controls.Add(this.hubLabel);
            this.groupBox5.Controls.Add(this.tableLayoutPanel3);
            this.groupBox5.Location = new System.Drawing.Point(84, 23);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(280, 102);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Attribute Scope";
            // 
            // hubComboBox
            // 
            this.hubComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hubComboBox.DropDownWidth = 400;
            this.hubComboBox.Enabled = false;
            this.hubComboBox.FormattingEnabled = true;
            this.hubComboBox.Location = new System.Drawing.Point(151, 47);
            this.hubComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hubComboBox.Name = "hubComboBox";
            this.hubComboBox.Size = new System.Drawing.Size(120, 24);
            this.hubComboBox.TabIndex = 2;
            // 
            // hubLabel
            // 
            this.hubLabel.AutoSize = true;
            this.hubLabel.Enabled = false;
            this.hubLabel.Location = new System.Drawing.Point(156, 27);
            this.hubLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hubLabel.Name = "hubLabel";
            this.hubLabel.Size = new System.Drawing.Size(77, 17);
            this.hubLabel.TabIndex = 1;
            this.hubLabel.Text = "Hub Select";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.globalRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.hubRadioButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.playerRadioButton, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 17);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(120, 84);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // globalRadioButton
            // 
            this.globalRadioButton.AutoSize = true;
            this.globalRadioButton.Location = new System.Drawing.Point(4, 4);
            this.globalRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.globalRadioButton.Name = "globalRadioButton";
            this.globalRadioButton.Size = new System.Drawing.Size(70, 18);
            this.globalRadioButton.TabIndex = 0;
            this.globalRadioButton.TabStop = true;
            this.globalRadioButton.Text = "Global";
            this.globalRadioButton.UseVisualStyleBackColor = true;
            this.globalRadioButton.CheckedChanged += new System.EventHandler(this.globalRadioButton_CheckedChanged);
            // 
            // hubRadioButton
            // 
            this.hubRadioButton.AutoSize = true;
            this.hubRadioButton.Location = new System.Drawing.Point(4, 30);
            this.hubRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hubRadioButton.Name = "hubRadioButton";
            this.hubRadioButton.Size = new System.Drawing.Size(55, 18);
            this.hubRadioButton.TabIndex = 1;
            this.hubRadioButton.TabStop = true;
            this.hubRadioButton.Text = "Hub";
            this.hubRadioButton.UseVisualStyleBackColor = true;
            this.hubRadioButton.CheckedChanged += new System.EventHandler(this.hubRadioButton_CheckedChanged);
            // 
            // playerRadioButton
            // 
            this.playerRadioButton.AutoSize = true;
            this.playerRadioButton.Location = new System.Drawing.Point(4, 56);
            this.playerRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerRadioButton.Name = "playerRadioButton";
            this.playerRadioButton.Size = new System.Drawing.Size(69, 21);
            this.playerRadioButton.TabIndex = 2;
            this.playerRadioButton.TabStop = true;
            this.playerRadioButton.Text = "Player";
            this.playerRadioButton.UseVisualStyleBackColor = true;
            this.playerRadioButton.CheckedChanged += new System.EventHandler(this.playerRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.9697F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.0303F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Controls.Add(this.valueNumeric, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.attributeComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comparitorComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(84, 133);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 59);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // valueNumeric
            // 
            this.valueNumeric.Location = new System.Drawing.Point(222, 24);
            this.valueNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueNumeric.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.valueNumeric.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.valueNumeric.Name = "valueNumeric";
            this.valueNumeric.Size = new System.Drawing.Size(69, 22);
            this.valueNumeric.TabIndex = 46;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attributeComboBox.DropDownWidth = 300;
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Location = new System.Drawing.Point(4, 26);
            this.attributeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(105, 24);
            this.attributeComboBox.TabIndex = 24;
            // 
            // comparitorComboBox
            // 
            this.comparitorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comparitorComboBox.FormattingEnabled = true;
            this.comparitorComboBox.Location = new System.Drawing.Point(129, 26);
            this.comparitorComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comparitorComboBox.Name = "comparitorComboBox";
            this.comparitorComboBox.Size = new System.Drawing.Size(75, 24);
            this.comparitorComboBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Comparison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Attribute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Value";
            // 
            // addConditionButton
            // 
            this.addConditionButton.Location = new System.Drawing.Point(477, 140);
            this.addConditionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addConditionButton.Name = "addConditionButton";
            this.addConditionButton.Size = new System.Drawing.Size(121, 31);
            this.addConditionButton.TabIndex = 24;
            this.addConditionButton.Text = "Add Condition";
            this.addConditionButton.UseVisualStyleBackColor = true;
            this.addConditionButton.Click += new System.EventHandler(this.addConditionButton_Click);
            // 
            // buttonListRightButton
            // 
            this.buttonListRightButton.Location = new System.Drawing.Point(547, 96);
            this.buttonListRightButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListRightButton.Name = "buttonListRightButton";
            this.buttonListRightButton.Size = new System.Drawing.Size(35, 28);
            this.buttonListRightButton.TabIndex = 45;
            this.buttonListRightButton.Text = "►";
            this.buttonListRightButton.UseVisualStyleBackColor = true;
            this.buttonListRightButton.Click += new System.EventHandler(this.buttonListRightButton_Click);
            // 
            // buttonListLeftButton
            // 
            this.buttonListLeftButton.Location = new System.Drawing.Point(547, 60);
            this.buttonListLeftButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonListLeftButton.Name = "buttonListLeftButton";
            this.buttonListLeftButton.Size = new System.Drawing.Size(35, 28);
            this.buttonListLeftButton.TabIndex = 44;
            this.buttonListLeftButton.Text = "◄";
            this.buttonListLeftButton.UseVisualStyleBackColor = true;
            this.buttonListLeftButton.Click += new System.EventHandler(this.buttonListLeftButton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(515, 199);
            this.Savebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(100, 28);
            this.Savebutton.TabIndex = 16;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(515, 236);
            this.Cancelbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(100, 28);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // unusedPathsListBox
            // 
            this.unusedPathsListBox.AllowDrop = true;
            this.unusedPathsListBox.FormattingEnabled = true;
            this.unusedPathsListBox.HorizontalScrollbar = true;
            this.unusedPathsListBox.ItemHeight = 16;
            this.unusedPathsListBox.Location = new System.Drawing.Point(19, 32);
            this.unusedPathsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unusedPathsListBox.Name = "unusedPathsListBox";
            this.unusedPathsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.unusedPathsListBox.Size = new System.Drawing.Size(124, 228);
            this.unusedPathsListBox.TabIndex = 38;
            this.unusedPathsListBox.SelectedIndexChanged += new System.EventHandler(this.unusedPathsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ending Paths";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Unused Paths";
            // 
            // addPathsButton
            // 
            this.addPathsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addPathsButton.Location = new System.Drawing.Point(149, 118);
            this.addPathsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPathsButton.Name = "addPathsButton";
            this.addPathsButton.Size = new System.Drawing.Size(40, 23);
            this.addPathsButton.TabIndex = 35;
            this.addPathsButton.Text = "-->";
            this.addPathsButton.UseVisualStyleBackColor = true;
            this.addPathsButton.Click += new System.EventHandler(this.addPathsButton_Click);
            // 
            // removePathsButton
            // 
            this.removePathsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removePathsButton.Location = new System.Drawing.Point(149, 158);
            this.removePathsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removePathsButton.Name = "removePathsButton";
            this.removePathsButton.Size = new System.Drawing.Size(40, 23);
            this.removePathsButton.TabIndex = 34;
            this.removePathsButton.Text = "<--";
            this.removePathsButton.UseVisualStyleBackColor = true;
            this.removePathsButton.Click += new System.EventHandler(this.removePathsButton_Click);
            // 
            // pathsGroupedByTier
            // 
            this.pathsGroupedByTier.BackColor = System.Drawing.SystemColors.Menu;
            this.pathsGroupedByTier.HideSelection = false;
            this.pathsGroupedByTier.Location = new System.Drawing.Point(195, 31);
            this.pathsGroupedByTier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathsGroupedByTier.MultiSelect = false;
            this.pathsGroupedByTier.Name = "pathsGroupedByTier";
            this.pathsGroupedByTier.Size = new System.Drawing.Size(312, 229);
            this.pathsGroupedByTier.TabIndex = 39;
            this.pathsGroupedByTier.UseCompatibleStateImageBehavior = false;
            this.pathsGroupedByTier.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.pathsGroupedByTier_ItemSelectionChanged);
            // 
            // EndingGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 476);
            this.Controls.Add(this.buttonListRightButton);
            this.Controls.Add(this.pathsGroupedByTier);
            this.Controls.Add(this.buttonListLeftButton);
            this.Controls.Add(this.unusedPathsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPathsButton);
            this.Controls.Add(this.removePathsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.TierLabel);
            this.Controls.Add(this.tierComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "EndingGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EndingGenerator";
            this.Load += new System.EventHandler(this.EndingGenerator_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TierLabel;
        private System.Windows.Forms.ComboBox tierComboBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox pathRequirementsListBox;
        private System.Windows.Forms.Button removeConditionButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox hubComboBox;
        private System.Windows.Forms.Label hubLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton globalRadioButton;
        private System.Windows.Forms.RadioButton hubRadioButton;
        private System.Windows.Forms.RadioButton playerRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox attributeComboBox;
        private System.Windows.Forms.ComboBox comparitorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addConditionButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ListBox unusedPathsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPathsButton;
        private System.Windows.Forms.Button removePathsButton;
        private System.Windows.Forms.Button buttonListRightButton;
        private System.Windows.Forms.Button buttonListLeftButton;
        private System.Windows.Forms.ListView pathsGroupedByTier;
        private System.Windows.Forms.NumericUpDown valueNumeric;
    }
}