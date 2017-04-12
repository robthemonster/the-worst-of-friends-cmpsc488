namespace GUI_Test2
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
            this.buttonListDownButton = new System.Windows.Forms.Button();
            this.buttonListUpButton = new System.Windows.Forms.Button();
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.attributeComboBox = new System.Windows.Forms.ComboBox();
            this.comparitorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tierPathsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addConditionButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.unusedPathsListBox = new System.Windows.Forms.ListBox();
            this.usedPathsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addPathsButton = new System.Windows.Forms.Button();
            this.removePathsButton = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TierLabel
            // 
            this.TierLabel.AutoSize = true;
            this.TierLabel.Location = new System.Drawing.Point(269, 9);
            this.TierLabel.Name = "TierLabel";
            this.TierLabel.Size = new System.Drawing.Size(25, 13);
            this.TierLabel.TabIndex = 30;
            this.TierLabel.Text = "Tier";
            // 
            // tierComboBox
            // 
            this.tierComboBox.FormattingEnabled = true;
            this.tierComboBox.Location = new System.Drawing.Point(252, 25);
            this.tierComboBox.Name = "tierComboBox";
            this.tierComboBox.Size = new System.Drawing.Size(58, 21);
            this.tierComboBox.TabIndex = 29;
            this.tierComboBox.SelectedIndexChanged += new System.EventHandler(this.tierComboBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonListDownButton);
            this.groupBox4.Controls.Add(this.buttonListUpButton);
            this.groupBox4.Controls.Add(this.pathRequirementsListBox);
            this.groupBox4.Controls.Add(this.removeConditionButton);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Controls.Add(this.tierPathsListBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.addConditionButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 166);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Requirements";
            // 
            // buttonListDownButton
            // 
            this.buttonListDownButton.Location = new System.Drawing.Point(100, 134);
            this.buttonListDownButton.Name = "buttonListDownButton";
            this.buttonListDownButton.Size = new System.Drawing.Size(26, 23);
            this.buttonListDownButton.TabIndex = 45;
            this.buttonListDownButton.Text = "▼";
            this.buttonListDownButton.UseVisualStyleBackColor = true;
            // 
            // buttonListUpButton
            // 
            this.buttonListUpButton.Location = new System.Drawing.Point(100, 105);
            this.buttonListUpButton.Name = "buttonListUpButton";
            this.buttonListUpButton.Size = new System.Drawing.Size(26, 23);
            this.buttonListUpButton.TabIndex = 44;
            this.buttonListUpButton.Text = "▲";
            this.buttonListUpButton.UseVisualStyleBackColor = true;
            // 
            // pathRequirementsListBox
            // 
            this.pathRequirementsListBox.FormattingEnabled = true;
            this.pathRequirementsListBox.Location = new System.Drawing.Point(369, 19);
            this.pathRequirementsListBox.Name = "pathRequirementsListBox";
            this.pathRequirementsListBox.Size = new System.Drawing.Size(78, 95);
            this.pathRequirementsListBox.TabIndex = 38;
            this.pathRequirementsListBox.SelectedIndexChanged += new System.EventHandler(this.pathRequirementsListBox_SelectedIndexChanged);
            // 
            // removeConditionButton
            // 
            this.removeConditionButton.Location = new System.Drawing.Point(358, 141);
            this.removeConditionButton.Name = "removeConditionButton";
            this.removeConditionButton.Size = new System.Drawing.Size(91, 22);
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
            this.groupBox5.Location = new System.Drawing.Point(134, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 83);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Atribute Scope";
            // 
            // hubComboBox
            // 
            this.hubComboBox.Enabled = false;
            this.hubComboBox.FormattingEnabled = true;
            this.hubComboBox.Location = new System.Drawing.Point(113, 38);
            this.hubComboBox.Name = "hubComboBox";
            this.hubComboBox.Size = new System.Drawing.Size(91, 21);
            this.hubComboBox.TabIndex = 2;
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
            this.tableLayoutPanel3.Controls.Add(this.globalRadioButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.hubRadioButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.playerRadioButton, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 14);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(90, 68);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // globalRadioButton
            // 
            this.globalRadioButton.AutoSize = true;
            this.globalRadioButton.Location = new System.Drawing.Point(3, 3);
            this.globalRadioButton.Name = "globalRadioButton";
            this.globalRadioButton.Size = new System.Drawing.Size(55, 15);
            this.globalRadioButton.TabIndex = 0;
            this.globalRadioButton.TabStop = true;
            this.globalRadioButton.Text = "Global";
            this.globalRadioButton.UseVisualStyleBackColor = true;
            this.globalRadioButton.CheckedChanged += new System.EventHandler(this.globalRadioButton_CheckedChanged);
            // 
            // hubRadioButton
            // 
            this.hubRadioButton.AutoSize = true;
            this.hubRadioButton.Location = new System.Drawing.Point(3, 24);
            this.hubRadioButton.Name = "hubRadioButton";
            this.hubRadioButton.Size = new System.Drawing.Size(45, 15);
            this.hubRadioButton.TabIndex = 1;
            this.hubRadioButton.TabStop = true;
            this.hubRadioButton.Text = "Hub";
            this.hubRadioButton.UseVisualStyleBackColor = true;
            this.hubRadioButton.CheckedChanged += new System.EventHandler(this.hubRadioButton_CheckedChanged);
            // 
            // playerRadioButton
            // 
            this.playerRadioButton.AutoSize = true;
            this.playerRadioButton.Location = new System.Drawing.Point(3, 45);
            this.playerRadioButton.Name = "playerRadioButton";
            this.playerRadioButton.Size = new System.Drawing.Size(54, 17);
            this.playerRadioButton.TabIndex = 2;
            this.playerRadioButton.TabStop = true;
            this.playerRadioButton.Text = "Player";
            this.playerRadioButton.UseVisualStyleBackColor = true;
            this.playerRadioButton.CheckedChanged += new System.EventHandler(this.playerRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27273F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Controls.Add(this.valueTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.attributeComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comparitorComboBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(134, 108);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(221, 48);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(157, 21);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(47, 20);
            this.valueTextBox.TabIndex = 33;
            this.valueTextBox.Text = "0";
            this.valueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // attributeComboBox
            // 
            this.attributeComboBox.FormattingEnabled = true;
            this.attributeComboBox.Location = new System.Drawing.Point(3, 21);
            this.attributeComboBox.Name = "attributeComboBox";
            this.attributeComboBox.Size = new System.Drawing.Size(83, 21);
            this.attributeComboBox.TabIndex = 24;
            // 
            // comparitorComboBox
            // 
            this.comparitorComboBox.FormattingEnabled = true;
            this.comparitorComboBox.Location = new System.Drawing.Point(92, 21);
            this.comparitorComboBox.Name = "comparitorComboBox";
            this.comparitorComboBox.Size = new System.Drawing.Size(59, 21);
            this.comparitorComboBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Comparison";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Atribute";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Value";
            // 
            // tierPathsListBox
            // 
            this.tierPathsListBox.FormattingEnabled = true;
            this.tierPathsListBox.Location = new System.Drawing.Point(6, 38);
            this.tierPathsListBox.Name = "tierPathsListBox";
            this.tierPathsListBox.Size = new System.Drawing.Size(92, 121);
            this.tierPathsListBox.TabIndex = 22;
            this.tierPathsListBox.SelectedIndexChanged += new System.EventHandler(this.tierPathsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Endings In Tier";
            // 
            // addConditionButton
            // 
            this.addConditionButton.Location = new System.Drawing.Point(358, 114);
            this.addConditionButton.Name = "addConditionButton";
            this.addConditionButton.Size = new System.Drawing.Size(91, 25);
            this.addConditionButton.TabIndex = 24;
            this.addConditionButton.Text = "Add Condition";
            this.addConditionButton.UseVisualStyleBackColor = true;
            this.addConditionButton.Click += new System.EventHandler(this.addConditionButton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(318, 92);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 16;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(318, 121);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // unusedPathsListBox
            // 
            this.unusedPathsListBox.AllowDrop = true;
            this.unusedPathsListBox.FormattingEnabled = true;
            this.unusedPathsListBox.Location = new System.Drawing.Point(14, 26);
            this.unusedPathsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.unusedPathsListBox.Name = "unusedPathsListBox";
            this.unusedPathsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.unusedPathsListBox.Size = new System.Drawing.Size(94, 186);
            this.unusedPathsListBox.TabIndex = 38;
            this.unusedPathsListBox.SelectedIndexChanged += new System.EventHandler(this.unusedPathsListBox_SelectedIndexChanged);
            // 
            // usedPathsListBox
            // 
            this.usedPathsListBox.AllowDrop = true;
            this.usedPathsListBox.FormattingEnabled = true;
            this.usedPathsListBox.Location = new System.Drawing.Point(146, 24);
            this.usedPathsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.usedPathsListBox.Name = "usedPathsListBox";
            this.usedPathsListBox.Size = new System.Drawing.Size(94, 186);
            this.usedPathsListBox.TabIndex = 39;
            this.usedPathsListBox.SelectedIndexChanged += new System.EventHandler(this.usedPathsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ending Paths";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Unused Paths";
            // 
            // addPathsButton
            // 
            this.addPathsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addPathsButton.Location = new System.Drawing.Point(112, 96);
            this.addPathsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPathsButton.Name = "addPathsButton";
            this.addPathsButton.Size = new System.Drawing.Size(30, 19);
            this.addPathsButton.TabIndex = 35;
            this.addPathsButton.Text = "-->";
            this.addPathsButton.UseVisualStyleBackColor = true;
            this.addPathsButton.Click += new System.EventHandler(this.addPathsButton_Click);
            // 
            // removePathsButton
            // 
            this.removePathsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removePathsButton.Location = new System.Drawing.Point(112, 128);
            this.removePathsButton.Margin = new System.Windows.Forms.Padding(2);
            this.removePathsButton.Name = "removePathsButton";
            this.removePathsButton.Size = new System.Drawing.Size(30, 19);
            this.removePathsButton.TabIndex = 34;
            this.removePathsButton.Text = "<--";
            this.removePathsButton.UseVisualStyleBackColor = true;
            this.removePathsButton.Click += new System.EventHandler(this.removePathsButton_Click);
            // 
            // EndingGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 387);
            this.Controls.Add(this.unusedPathsListBox);
            this.Controls.Add(this.usedPathsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPathsButton);
            this.Controls.Add(this.removePathsButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.TierLabel);
            this.Controls.Add(this.tierComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndingGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EndingGenerator";
            this.Load += new System.EventHandler(this.EndingGenerator_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ComboBox attributeComboBox;
        private System.Windows.Forms.ComboBox comparitorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox tierPathsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addConditionButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.ListBox unusedPathsListBox;
        private System.Windows.Forms.ListBox usedPathsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPathsButton;
        private System.Windows.Forms.Button removePathsButton;
        private System.Windows.Forms.Button buttonListDownButton;
        private System.Windows.Forms.Button buttonListUpButton;
    }
}