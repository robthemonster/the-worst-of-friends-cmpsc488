namespace GUI_Test2
{
    partial class EditPathForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPathForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dialogueList = new System.Windows.Forms.ListView();
            this.selectedDialogueText = new System.Windows.Forms.TextBox();
            this.selectDefaultPathImageButton = new System.Windows.Forms.Button();
            this.createNewDialogueButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.addImpactButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.defaultPathImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPathImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dialogueList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectedDialogueText, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 187);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dialogueList
            // 
            this.dialogueList.Location = new System.Drawing.Point(3, 3);
            this.dialogueList.Name = "dialogueList";
            this.dialogueList.Size = new System.Drawing.Size(281, 181);
            this.dialogueList.TabIndex = 1;
            this.dialogueList.UseCompatibleStateImageBehavior = false;
            // 
            // selectedDialogueText
            // 
            this.selectedDialogueText.Location = new System.Drawing.Point(290, 3);
            this.selectedDialogueText.Name = "selectedDialogueText";
            this.selectedDialogueText.Size = new System.Drawing.Size(281, 22);
            this.selectedDialogueText.TabIndex = 2;
            // 
            // selectDefaultPathImageButton
            // 
            this.selectDefaultPathImageButton.Location = new System.Drawing.Point(580, 234);
            this.selectDefaultPathImageButton.Name = "selectDefaultPathImageButton";
            this.selectDefaultPathImageButton.Size = new System.Drawing.Size(188, 23);
            this.selectDefaultPathImageButton.TabIndex = 4;
            this.selectDefaultPathImageButton.Text = "Select Default Image...";
            this.selectDefaultPathImageButton.UseVisualStyleBackColor = true;
            this.selectDefaultPathImageButton.Click += new System.EventHandler(this.selectDefaultPathImageButton_Click);
            // 
            // createNewDialogueButton
            // 
            this.createNewDialogueButton.Location = new System.Drawing.Point(106, 47);
            this.createNewDialogueButton.Name = "createNewDialogueButton";
            this.createNewDialogueButton.Size = new System.Drawing.Size(178, 23);
            this.createNewDialogueButton.TabIndex = 2;
            this.createNewDialogueButton.Text = "Create New Dialogue";
            this.createNewDialogueButton.UseVisualStyleBackColor = true;
            this.createNewDialogueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 266);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(562, 175);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addImpactButton
            // 
            this.addImpactButton.Location = new System.Drawing.Point(580, 389);
            this.addImpactButton.Name = "addImpactButton";
            this.addImpactButton.Size = new System.Drawing.Size(23, 23);
            this.addImpactButton.TabIndex = 7;
            this.addImpactButton.Text = "+";
            this.addImpactButton.UseVisualStyleBackColor = true;
            this.addImpactButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(580, 418);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(23, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "-";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // defaultPathImage
            // 
            this.defaultPathImage.Image = global::GUI_Test2.Properties.Resources.defaultPath;
            this.defaultPathImage.Location = new System.Drawing.Point(581, 73);
            this.defaultPathImage.Name = "defaultPathImage";
            this.defaultPathImage.Size = new System.Drawing.Size(291, 155);
            this.defaultPathImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPathImage.TabIndex = 5;
            this.defaultPathImage.TabStop = false;
            this.defaultPathImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addImpactButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.defaultPathImage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.createNewDialogueButton);
            this.Controls.Add(this.selectDefaultPathImageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditPathForm";
            this.Text = " Edit Path";
            this.Load += new System.EventHandler(this.EditPath_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPathImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView dialogueList;
        private System.Windows.Forms.Button createNewDialogueButton;
        private System.Windows.Forms.TextBox selectedDialogueText;
        private System.Windows.Forms.Button selectDefaultPathImageButton;
        private System.Windows.Forms.PictureBox defaultPathImage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addImpactButton;
        private System.Windows.Forms.Button deleteButton;
    }
}