namespace GUI_Test2
{
    partial class CreateHubForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.hubNameLabel = new System.Windows.Forms.Label();
            this.hubNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(203, 39);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(122, 39);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // hubNameLabel
            // 
            this.hubNameLabel.AutoSize = true;
            this.hubNameLabel.Location = new System.Drawing.Point(5, 11);
            this.hubNameLabel.Name = "hubNameLabel";
            this.hubNameLabel.Size = new System.Drawing.Size(75, 17);
            this.hubNameLabel.TabIndex = 5;
            this.hubNameLabel.Text = "Hub Name";
            // 
            // hubNameTextBox
            // 
            this.hubNameTextBox.Location = new System.Drawing.Point(89, 11);
            this.hubNameTextBox.Name = "hubNameTextBox";
            this.hubNameTextBox.Size = new System.Drawing.Size(189, 22);
            this.hubNameTextBox.TabIndex = 4;
            // 
            // CreateHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 73);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.hubNameLabel);
            this.Controls.Add(this.hubNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateHubForm";
            this.Text = "Create Hub Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label hubNameLabel;
        private System.Windows.Forms.TextBox hubNameTextBox;
    }
}