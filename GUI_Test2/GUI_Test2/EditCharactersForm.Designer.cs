namespace GUI_Test2
{
    partial class EditCharactersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCharactersForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.characterList = new System.Windows.Forms.ListView();
            this.createNewCharacterButton = new System.Windows.Forms.Button();
            this.deleteSelectedCharacterButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.characterNameBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.characterList);
            this.flowLayoutPanel1.Controls.Add(this.createNewCharacterButton);
            this.flowLayoutPanel1.Controls.Add(this.deleteSelectedCharacterButton);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 10);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(211, 271);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // characterList
            // 
            this.characterList.Location = new System.Drawing.Point(2, 2);
            this.characterList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(210, 246);
            this.characterList.TabIndex = 3;
            this.characterList.UseCompatibleStateImageBehavior = false;
            // 
            // createNewCharacterButton
            // 
            this.createNewCharacterButton.Location = new System.Drawing.Point(2, 252);
            this.createNewCharacterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createNewCharacterButton.Name = "createNewCharacterButton";
            this.createNewCharacterButton.Size = new System.Drawing.Size(117, 19);
            this.createNewCharacterButton.TabIndex = 1;
            this.createNewCharacterButton.Text = "Create New Character";
            this.createNewCharacterButton.UseVisualStyleBackColor = true;
            this.createNewCharacterButton.Click += new System.EventHandler(this.createNewCharacterButton_Click);
            // 
            // deleteSelectedCharacterButton
            // 
            this.deleteSelectedCharacterButton.Location = new System.Drawing.Point(123, 252);
            this.deleteSelectedCharacterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteSelectedCharacterButton.Name = "deleteSelectedCharacterButton";
            this.deleteSelectedCharacterButton.Size = new System.Drawing.Size(75, 19);
            this.deleteSelectedCharacterButton.TabIndex = 2;
            this.deleteSelectedCharacterButton.Text = "Delete Selected Character";
            this.deleteSelectedCharacterButton.UseVisualStyleBackColor = true;
            this.deleteSelectedCharacterButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 275);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(150, 81);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.characterNameLabel);
            this.flowLayoutPanel3.Controls.Add(this.characterNameBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(11, 286);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(208, 150);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Location = new System.Drawing.Point(2, 5);
            this.characterNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(87, 13);
            this.characterNameLabel.TabIndex = 0;
            this.characterNameLabel.Text = "Character Name:";
            // 
            // characterNameBox
            // 
            this.characterNameBox.Location = new System.Drawing.Point(93, 2);
            this.characterNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterNameBox.Name = "characterNameBox";
            this.characterNameBox.Size = new System.Drawing.Size(76, 20);
            this.characterNameBox.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.characterImage);
            this.flowLayoutPanel4.Controls.Add(this.chooseImageButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(224, 10);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(205, 426);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // characterImage
            // 
            this.characterImage.Image = global::GUI_Test2.Properties.Resources.character;
            this.characterImage.Location = new System.Drawing.Point(2, 2);
            this.characterImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(202, 162);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImage.TabIndex = 0;
            this.characterImage.TabStop = false;
            this.characterImage.Click += new System.EventHandler(this.characterImage_Click);
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(2, 168);
            this.chooseImageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(105, 19);
            this.chooseImageButton.TabIndex = 1;
            this.chooseImageButton.Text = "Choose Image...";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // EditCharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 445);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "EditCharactersForm";
            this.Text = "Edit Characters";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button createNewCharacterButton;
        private System.Windows.Forms.Button deleteSelectedCharacterButton;
        private System.Windows.Forms.ListView characterList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.TextBox characterNameBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.Button chooseImageButton;
    }
}