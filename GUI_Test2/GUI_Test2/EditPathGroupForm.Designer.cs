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
            this.SuspendLayout();
            // 
            // addSekectedPathsToPathGroup
            // 
            this.addSekectedPathsToPathGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addSekectedPathsToPathGroup.Location = new System.Drawing.Point(218, 171);
            this.addSekectedPathsToPathGroup.Name = "addSekectedPathsToPathGroup";
            this.addSekectedPathsToPathGroup.Size = new System.Drawing.Size(40, 23);
            this.addSekectedPathsToPathGroup.TabIndex = 2;
            this.addSekectedPathsToPathGroup.Text = "-->";
            this.addSekectedPathsToPathGroup.UseVisualStyleBackColor = true;
            // 
            // removeSelectedPathsFromPathGroup
            // 
            this.removeSelectedPathsFromPathGroup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeSelectedPathsFromPathGroup.Location = new System.Drawing.Point(218, 217);
            this.removeSelectedPathsFromPathGroup.Name = "removeSelectedPathsFromPathGroup";
            this.removeSelectedPathsFromPathGroup.Size = new System.Drawing.Size(40, 23);
            this.removeSelectedPathsFromPathGroup.TabIndex = 3;
            this.removeSelectedPathsFromPathGroup.Text = "<--";
            this.removeSelectedPathsFromPathGroup.UseVisualStyleBackColor = true;
            // 
            // pathTiersListView
            // 
            this.pathTiersListView.Location = new System.Drawing.Point(470, 13);
            this.pathTiersListView.Name = "pathTiersListView";
            this.pathTiersListView.Size = new System.Drawing.Size(390, 197);
            this.pathTiersListView.TabIndex = 4;
            this.pathTiersListView.UseCompatibleStateImageBehavior = false;
            // 
            // conditionsListView
            // 
            this.conditionsListView.Location = new System.Drawing.Point(470, 217);
            this.conditionsListView.Name = "conditionsListView";
            this.conditionsListView.Size = new System.Drawing.Size(291, 224);
            this.conditionsListView.TabIndex = 5;
            this.conditionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(768, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 22);
            this.textBox1.TabIndex = 6;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(783, 242);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(52, 17);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight";
            this.weightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addConditionToSelectedPathInPathGroup
            // 
            this.addConditionToSelectedPathInPathGroup.Location = new System.Drawing.Point(768, 418);
            this.addConditionToSelectedPathInPathGroup.Name = "addConditionToSelectedPathInPathGroup";
            this.addConditionToSelectedPathInPathGroup.Size = new System.Drawing.Size(25, 23);
            this.addConditionToSelectedPathInPathGroup.TabIndex = 8;
            this.addConditionToSelectedPathInPathGroup.Text = "+";
            this.addConditionToSelectedPathInPathGroup.UseVisualStyleBackColor = true;
            // 
            // removeSelectedConditionFromPathInPathGroup
            // 
            this.removeSelectedConditionFromPathInPathGroup.Location = new System.Drawing.Point(767, 389);
            this.removeSelectedConditionFromPathInPathGroup.Name = "removeSelectedConditionFromPathInPathGroup";
            this.removeSelectedConditionFromPathInPathGroup.Size = new System.Drawing.Size(25, 23);
            this.removeSelectedConditionFromPathInPathGroup.TabIndex = 9;
            this.removeSelectedConditionFromPathInPathGroup.Text = "-";
            this.removeSelectedConditionFromPathInPathGroup.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paths not in this Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Paths in this Group";
            // 
            // pathsNotInPathGroupListBox
            // 
            this.pathsNotInPathGroupListBox.AllowDrop = true;
            this.pathsNotInPathGroupListBox.FormattingEnabled = true;
            this.pathsNotInPathGroupListBox.ItemHeight = 16;
            this.pathsNotInPathGroupListBox.Location = new System.Drawing.Point(12, 33);
            this.pathsNotInPathGroupListBox.Name = "pathsNotInPathGroupListBox";
            this.pathsNotInPathGroupListBox.Size = new System.Drawing.Size(200, 404);
            this.pathsNotInPathGroupListBox.TabIndex = 12;
            // 
            // pathsInPathGroupListBox
            // 
            this.pathsInPathGroupListBox.AllowDrop = true;
            this.pathsInPathGroupListBox.FormattingEnabled = true;
            this.pathsInPathGroupListBox.ItemHeight = 16;
            this.pathsInPathGroupListBox.Location = new System.Drawing.Point(264, 33);
            this.pathsInPathGroupListBox.Name = "pathsInPathGroupListBox";
            this.pathsInPathGroupListBox.Size = new System.Drawing.Size(200, 404);
            this.pathsInPathGroupListBox.TabIndex = 13;
            // 
            // EditPathGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
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
            this.MaximizeBox = false;
            this.Name = "EditPathGroupForm";
            this.Text = "Edit Path Group";
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
    }
}