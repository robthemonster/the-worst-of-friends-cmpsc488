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
            this.addButtonButton = new System.Windows.Forms.Button();
            this.deleteButtonButton = new System.Windows.Forms.Button();
            this.hubImagePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hubImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addButtonButton
            // 
            this.addButtonButton.Location = new System.Drawing.Point(760, 422);
            this.addButtonButton.Name = "addButtonButton";
            this.addButtonButton.Size = new System.Drawing.Size(101, 23);
            this.addButtonButton.TabIndex = 1;
            this.addButtonButton.Text = "Add Button";
            this.addButtonButton.UseVisualStyleBackColor = true;
            // 
            // deleteButtonButton
            // 
            this.deleteButtonButton.Location = new System.Drawing.Point(646, 422);
            this.deleteButtonButton.Name = "deleteButtonButton";
            this.deleteButtonButton.Size = new System.Drawing.Size(108, 23);
            this.deleteButtonButton.TabIndex = 2;
            this.deleteButtonButton.Text = "Delete Button";
            this.deleteButtonButton.UseVisualStyleBackColor = true;
            // 
            // hubImagePictureBox
            // 
            this.hubImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hubImagePictureBox.Image = global::GUI_Test2.Properties.Resources.defaultHub;
            this.hubImagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.hubImagePictureBox.Name = "hubImagePictureBox";
            this.hubImagePictureBox.Size = new System.Drawing.Size(848, 404);
            this.hubImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hubImagePictureBox.TabIndex = 0;
            this.hubImagePictureBox.TabStop = false;
            this.hubImagePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 453);
            this.Controls.Add(this.deleteButtonButton);
            this.Controls.Add(this.addButtonButton);
            this.Controls.Add(this.hubImagePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditHubForm";
            this.Text = "Edit Hub";
            ((System.ComponentModel.ISupportInitialize)(this.hubImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hubImagePictureBox;
        private System.Windows.Forms.Button addButtonButton;
        private System.Windows.Forms.Button deleteButtonButton;
    }
}