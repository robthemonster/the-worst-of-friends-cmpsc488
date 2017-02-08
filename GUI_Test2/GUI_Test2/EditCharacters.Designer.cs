namespace GUI_Test2
{
    partial class EditCharacters
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.createNewCharacterButton = new System.Windows.Forms.Button();
            this.deleteSelectedCharacterButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.NumberOfCharactersLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listView1);
            this.flowLayoutPanel1.Controls.Add(this.createNewCharacterButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteSelectedCharacterButton);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 334);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // createNewCharacterButton
            // 
            this.createNewCharacterButton.Location = new System.Drawing.Point(3, 311);
            this.createNewCharacterButton.Name = "createNewCharacterButton";
            this.createNewCharacterButton.Size = new System.Drawing.Size(156, 23);
            this.createNewCharacterButton.TabIndex = 1;
            this.createNewCharacterButton.Text = "Create New Character";
            this.createNewCharacterButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedCharacterButton
            // 
            this.deleteSelectedCharacterButton.Location = new System.Drawing.Point(165, 311);
            this.deleteSelectedCharacterButton.Name = "deleteSelectedCharacterButton";
            this.deleteSelectedCharacterButton.Size = new System.Drawing.Size(100, 23);
            this.deleteSelectedCharacterButton.TabIndex = 2;
            this.deleteSelectedCharacterButton.Text = "Delete Selected Character";
            this.deleteSelectedCharacterButton.UseVisualStyleBackColor = true;
            this.deleteSelectedCharacterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 302);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 340);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.NumberOfCharactersLabel);
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(15, 352);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(278, 184);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // NumberOfCharactersLabel
            // 
            this.NumberOfCharactersLabel.AutoSize = true;
            this.NumberOfCharactersLabel.Location = new System.Drawing.Point(3, 0);
            this.NumberOfCharactersLabel.Name = "NumberOfCharactersLabel";
            this.NumberOfCharactersLabel.Size = new System.Drawing.Size(147, 17);
            this.NumberOfCharactersLabel.TabIndex = 0;
            this.NumberOfCharactersLabel.Text = "Number of Characters";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.characterImage);
            this.flowLayoutPanel4.Controls.Add(this.chooseImageButton);
            this.flowLayoutPanel4.Controls.Add(this.textBox2);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(299, 12);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(273, 524);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(3, 210);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(140, 23);
            this.chooseImageButton.TabIndex = 1;
            this.chooseImageButton.Text = "Choose Image...";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 3;
            // 
            // characterImage
            // 
            this.characterImage.Location = new System.Drawing.Point(3, 3);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(270, 201);
            this.characterImage.TabIndex = 0;
            this.characterImage.TabStop = false;
            // 
            // EditCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 548);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "EditCharacters";
            this.Text = "EditCharacters";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button createNewCharacterButton;
        private System.Windows.Forms.Button deleteSelectedCharacterButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label NumberOfCharactersLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.TextBox textBox2;
    }
}