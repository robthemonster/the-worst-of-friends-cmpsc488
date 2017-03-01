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
            this.addSekectedPathsToPathGroup = new System.Windows.Forms.Button();
            this.removeSelectedPathsFromPathGroup = new System.Windows.Forms.Button();
            this.pathTiersListView = new System.Windows.Forms.ListView();
            this.conditionsListView = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.addConditionToSelectedPathInPathGroup = new System.Windows.Forms.Button();
            this.removeSelectedConditionFromPathInPathGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pathsNotInPathGroupListBox = new System.Windows.Forms.ListBox();
            this.pathsInPathGroupListBox = new System.Windows.Forms.ListBox();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addSekectedPathsToPathGroup
            // 
            this.addSekectedPathsToPathGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addSekectedPathsToPathGroup.Location = new System.Drawing.Point(164, 139);
            this.addSekectedPathsToPathGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addSekectedPathsToPathGroup.Name = "addSekectedPathsToPathGroup";
            this.addSekectedPathsToPathGroup.Size = new System.Drawing.Size(30, 19);
            this.addSekectedPathsToPathGroup.TabIndex = 2;
            this.addSekectedPathsToPathGroup.Text = "-->";
            this.addSekectedPathsToPathGroup.UseVisualStyleBackColor = true;
            // 
            // removeSelectedPathsFromPathGroup
            // 
            this.removeSelectedPathsFromPathGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeSelectedPathsFromPathGroup.Location = new System.Drawing.Point(164, 176);
            this.removeSelectedPathsFromPathGroup.Margin = new System.Windows.Forms.Padding(2);
            this.removeSelectedPathsFromPathGroup.Name = "removeSelectedPathsFromPathGroup";
            this.removeSelectedPathsFromPathGroup.Size = new System.Drawing.Size(30, 19);
            this.removeSelectedPathsFromPathGroup.TabIndex = 3;
            this.removeSelectedPathsFromPathGroup.Text = "<--";
            this.removeSelectedPathsFromPathGroup.UseVisualStyleBackColor = true;
            this.removeSelectedPathsFromPathGroup.Click += new System.EventHandler(this.removeSelectedPathsFromPathGroup_Click);
            // 
            // pathTiersListView
            // 
            this.pathTiersListView.Location = new System.Drawing.Point(352, 11);
            this.pathTiersListView.Margin = new System.Windows.Forms.Padding(2);
            this.pathTiersListView.Name = "pathTiersListView";
            this.pathTiersListView.Size = new System.Drawing.Size(418, 161);
            this.pathTiersListView.TabIndex = 4;
            this.pathTiersListView.UseCompatibleStateImageBehavior = false;
            // 
            // conditionsListView
            // 
            this.conditionsListView.Location = new System.Drawing.Point(352, 173);
            this.conditionsListView.Margin = new System.Windows.Forms.Padding(2);
            this.conditionsListView.Name = "conditionsListView";
            this.conditionsListView.Size = new System.Drawing.Size(219, 183);
            this.conditionsListView.TabIndex = 5;
            this.conditionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(648, 176);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 6;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(659, 197);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(41, 13);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            this.weightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addConditionToSelectedPathInPathGroup
            // 
            this.addConditionToSelectedPathInPathGroup.Location = new System.Drawing.Point(576, 340);
            this.addConditionToSelectedPathInPathGroup.Margin = new System.Windows.Forms.Padding(2);
            this.addConditionToSelectedPathInPathGroup.Name = "addConditionToSelectedPathInPathGroup";
            this.addConditionToSelectedPathInPathGroup.Size = new System.Drawing.Size(19, 19);
            this.addConditionToSelectedPathInPathGroup.TabIndex = 8;
            this.addConditionToSelectedPathInPathGroup.Text = "+";
            this.addConditionToSelectedPathInPathGroup.UseVisualStyleBackColor = true;
            // 
            // removeSelectedConditionFromPathInPathGroup
            // 
            this.removeSelectedConditionFromPathInPathGroup.Location = new System.Drawing.Point(575, 316);
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
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paths not in this Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 11);
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
            this.pathsNotInPathGroupListBox.Location = new System.Drawing.Point(9, 27);
            this.pathsNotInPathGroupListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathsNotInPathGroupListBox.Name = "pathsNotInPathGroupListBox";
            this.pathsNotInPathGroupListBox.Size = new System.Drawing.Size(151, 329);
            this.pathsNotInPathGroupListBox.TabIndex = 12;
            this.pathsNotInPathGroupListBox.SelectedIndexChanged += new System.EventHandler(this.pathsNotInPathGroupListBox_SelectedIndexChanged);
            // 
            // pathsInPathGroupListBox
            // 
            this.pathsInPathGroupListBox.AllowDrop = true;
            this.pathsInPathGroupListBox.FormattingEnabled = true;
            this.pathsInPathGroupListBox.Location = new System.Drawing.Point(198, 27);
            this.pathsInPathGroupListBox.Margin = new System.Windows.Forms.Padding(2);
            this.pathsInPathGroupListBox.Name = "pathsInPathGroupListBox";
            this.pathsInPathGroupListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.pathsInPathGroupListBox.Size = new System.Drawing.Size(151, 329);
            this.pathsInPathGroupListBox.Sorted = true;
            this.pathsInPathGroupListBox.TabIndex = 13;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(704, 333);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 15;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(625, 333);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 16;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            // 
            // EditPathGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 362);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.pathsInPathGroupListBox);
            this.Controls.Add(this.pathsNotInPathGroupListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeSelectedConditionFromPathInPathGroup);
            this.Controls.Add(this.addConditionToSelectedPathInPathGroup);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.conditionsListView);
            this.Controls.Add(this.pathTiersListView);
            this.Controls.Add(this.removeSelectedPathsFromPathGroup);
            this.Controls.Add(this.addSekectedPathsToPathGroup);
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

        private System.Windows.Forms.Button addSekectedPathsToPathGroup;
        private System.Windows.Forms.Button removeSelectedPathsFromPathGroup;
        private System.Windows.Forms.ListView pathTiersListView;
        private System.Windows.Forms.ListView conditionsListView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button addConditionToSelectedPathInPathGroup;
        private System.Windows.Forms.Button removeSelectedConditionFromPathInPathGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox pathsNotInPathGroupListBox;
        private System.Windows.Forms.ListBox pathsInPathGroupListBox;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button OKbutton;
    }
}