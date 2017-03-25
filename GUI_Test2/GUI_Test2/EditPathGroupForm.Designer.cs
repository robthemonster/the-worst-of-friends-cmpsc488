namespace GUI_Test2
{
    partial class EditPathGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPathGroupForm));
            this.removePathsButton = new System.Windows.Forms.Button();
            this.addPathsButton = new System.Windows.Forms.Button();
            this.tierWeightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.addConditionToSelectedPathInPathGroup = new System.Windows.Forms.Button();
            this.removeSelectedConditionFromPathInPathGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathsNotInPathGroupListBox = new System.Windows.Forms.ListBox();
            this.pathsInPathGroupListBox = new System.Windows.Forms.ListBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.tierComboBox = new System.Windows.Forms.ComboBox();
            this.TierLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pathWeightTextBox = new System.Windows.Forms.TextBox();
            this.tierPathsListBox = new System.Windows.Forms.ListBox();
            this.editTierPathButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removePathsButton
            // 
            this.removePathsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removePathsButton.Location = new System.Drawing.Point(138, 153);
            this.removePathsButton.Margin = new System.Windows.Forms.Padding(2);
            this.removePathsButton.Name = "removePathsButton";
            this.removePathsButton.Size = new System.Drawing.Size(30, 19);
            this.removePathsButton.TabIndex = 2;
            this.removePathsButton.Text = "<--";
            this.removePathsButton.UseVisualStyleBackColor = true;
            this.removePathsButton.Click += new System.EventHandler(this.removePathsButton_Click);
            // 
            // addPathsButton
            // 
            this.addPathsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addPathsButton.Location = new System.Drawing.Point(138, 190);
            this.addPathsButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPathsButton.Name = "addPathsButton";
            this.addPathsButton.Size = new System.Drawing.Size(30, 19);
            this.addPathsButton.TabIndex = 3;
            this.addPathsButton.Text = "-->";
            this.addPathsButton.UseVisualStyleBackColor = true;
            this.addPathsButton.Click += new System.EventHandler(this.addPathsButton_Click);
            // 
            // tierWeightTextBox
            // 
            this.tierWeightTextBox.Location = new System.Drawing.Point(444, 122);
            this.tierWeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.tierWeightTextBox.Name = "tierWeightTextBox";
            this.tierWeightTextBox.ReadOnly = true;
            this.tierWeightTextBox.Size = new System.Drawing.Size(60, 20);
            this.tierWeightTextBox.TabIndex = 6;
            this.tierWeightTextBox.Text = "0";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(337, 106);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(66, 13);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Path Weight";
            this.weightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addConditionToSelectedPathInPathGroup
            // 
            this.addConditionToSelectedPathInPathGroup.Location = new System.Drawing.Point(591, 295);
            this.addConditionToSelectedPathInPathGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addConditionToSelectedPathInPathGroup.Name = "addConditionToSelectedPathInPathGroup";
            this.addConditionToSelectedPathInPathGroup.Size = new System.Drawing.Size(19, 19);
            this.addConditionToSelectedPathInPathGroup.TabIndex = 8;
            this.addConditionToSelectedPathInPathGroup.Text = "+";
            this.addConditionToSelectedPathInPathGroup.UseVisualStyleBackColor = true;
            // 
            // removeSelectedConditionFromPathInPathGroup
            // 
            this.removeSelectedConditionFromPathInPathGroup.Location = new System.Drawing.Point(591, 318);
            this.removeSelectedConditionFromPathInPathGroup.Margin = new System.Windows.Forms.Padding(2);
            this.removeSelectedConditionFromPathInPathGroup.Name = "removeSelectedConditionFromPathInPathGroup";
            this.removeSelectedConditionFromPathInPathGroup.Size = new System.Drawing.Size(19, 19);
            this.removeSelectedConditionFromPathInPathGroup.TabIndex = 9;
            this.removeSelectedConditionFromPathInPathGroup.Text = "-";
            this.removeSelectedConditionFromPathInPathGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paths not in this Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Paths in this Group";
            // 
            // pathsNotInPathGroupListBox
            // 
            this.pathsNotInPathGroupListBox.AllowDrop = true;
            this.pathsNotInPathGroupListBox.FormattingEnabled = true;
            this.pathsNotInPathGroupListBox.Location = new System.Drawing.Point(3, 30);
            this.pathsNotInPathGroupListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathsNotInPathGroupListBox.Name = "pathsNotInPathGroupListBox";
            this.pathsNotInPathGroupListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pathsNotInPathGroupListBox.Size = new System.Drawing.Size(131, 329);
            this.pathsNotInPathGroupListBox.TabIndex = 12;
            this.pathsNotInPathGroupListBox.SelectedIndexChanged += new System.EventHandler(this.pathsNotInPathGroupListBox_SelectedIndexChanged_1);
            // 
            // pathsInPathGroupListBox
            // 
            this.pathsInPathGroupListBox.AllowDrop = true;
            this.pathsInPathGroupListBox.FormattingEnabled = true;
            this.pathsInPathGroupListBox.Location = new System.Drawing.Point(178, 30);
            this.pathsInPathGroupListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathsInPathGroupListBox.Name = "pathsInPathGroupListBox";
            this.pathsInPathGroupListBox.Size = new System.Drawing.Size(125, 329);
            this.pathsInPathGroupListBox.TabIndex = 13;
            this.pathsInPathGroupListBox.SelectedIndexChanged += new System.EventHandler(this.pathsInPathGroupListBox_SelectedIndexChanged);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(544, 336);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(463, 336);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 16;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // tierComboBox
            // 
            this.tierComboBox.FormattingEnabled = true;
            this.tierComboBox.Location = new System.Drawing.Point(387, 66);
            this.tierComboBox.Name = "tierComboBox";
            this.tierComboBox.Size = new System.Drawing.Size(58, 21);
            this.tierComboBox.TabIndex = 17;
            this.tierComboBox.SelectedIndexChanged += new System.EventHandler(this.tierComboBox_SelectedIndexChanged);
            // 
            // TierLabel
            // 
            this.TierLabel.AutoSize = true;
            this.TierLabel.Location = new System.Drawing.Point(396, 46);
            this.TierLabel.Name = "TierLabel";
            this.TierLabel.Size = new System.Drawing.Size(25, 13);
            this.TierLabel.TabIndex = 18;
            this.TierLabel.Text = "Tier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Paths In Tier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tier Weight";
            // 
            // pathWeightTextBox
            // 
            this.pathWeightTextBox.Location = new System.Drawing.Point(340, 122);
            this.pathWeightTextBox.Name = "pathWeightTextBox";
            this.pathWeightTextBox.Size = new System.Drawing.Size(60, 20);
            this.pathWeightTextBox.TabIndex = 21;
            this.pathWeightTextBox.Text = "1";
            // 
            // tierPathsListBox
            // 
            this.tierPathsListBox.FormattingEnabled = true;
            this.tierPathsListBox.Location = new System.Drawing.Point(510, 30);
            this.tierPathsListBox.Name = "tierPathsListBox";
            this.tierPathsListBox.Size = new System.Drawing.Size(100, 264);
            this.tierPathsListBox.TabIndex = 22;
            this.tierPathsListBox.SelectedIndexChanged += new System.EventHandler(this.tierPathsListBox_SelectedIndexChanged);
            // 
            // editTierPathButton
            // 
            this.editTierPathButton.Location = new System.Drawing.Point(387, 177);
            this.editTierPathButton.Name = "editTierPathButton";
            this.editTierPathButton.Size = new System.Drawing.Size(62, 45);
            this.editTierPathButton.TabIndex = 23;
            this.editTierPathButton.Text = "Edit Path In Tier";
            this.editTierPathButton.UseVisualStyleBackColor = true;
            this.editTierPathButton.Click += new System.EventHandler(this.editTierPathButton_Click);
            // 
            // EditPathGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 362);
            this.Controls.Add(this.editTierPathButton);
            this.Controls.Add(this.tierPathsListBox);
            this.Controls.Add(this.pathWeightTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TierLabel);
            this.Controls.Add(this.tierComboBox);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.pathsInPathGroupListBox);
            this.Controls.Add(this.pathsNotInPathGroupListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeSelectedConditionFromPathInPathGroup);
            this.Controls.Add(this.addConditionToSelectedPathInPathGroup);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.tierWeightTextBox);
            this.Controls.Add(this.addPathsButton);
            this.Controls.Add(this.removePathsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EditPathGroupForm";
            this.Text = "Edit Path Group";
            this.Load += new System.EventHandler(this.EditPathGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removePathsButton;
        private System.Windows.Forms.Button addPathsButton;
        private System.Windows.Forms.TextBox tierWeightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button addConditionToSelectedPathInPathGroup;
        private System.Windows.Forms.Button removeSelectedConditionFromPathInPathGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox pathsNotInPathGroupListBox;
        private System.Windows.Forms.ListBox pathsInPathGroupListBox;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.ComboBox tierComboBox;
        private System.Windows.Forms.Label TierLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathWeightTextBox;
        private System.Windows.Forms.ListBox tierPathsListBox;
        private System.Windows.Forms.Button editTierPathButton;
    }
}