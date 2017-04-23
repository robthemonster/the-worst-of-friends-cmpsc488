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
            this.characterNameBox = new System.Windows.Forms.TextBox();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.imageNamelabel = new System.Windows.Forms.Label();
            this.imageNameTextBox = new System.Windows.Forms.TextBox();
            this.characterImageList = new System.Windows.Forms.ListBox();
            this.characterList = new System.Windows.Forms.ListBox();
            this.deleteSelectedCharacterButton = new System.Windows.Forms.Button();
            this.createNewCharacterButton = new System.Windows.Forms.Button();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.addImageToCharacterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // characterNameBox
            // 
            this.characterNameBox.Location = new System.Drawing.Point(137, 26);
            this.characterNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.characterNameBox.Name = "characterNameBox";
            this.characterNameBox.Size = new System.Drawing.Size(125, 22);
            this.characterNameBox.TabIndex = 0;
            this.characterNameBox.TextChanged += new System.EventHandler(this.characterNameBox_TextChanged);
            // 
            // characterImage
            // 
            this.characterImage.Image = global::GUI_Test2.Properties.Resources.defaultCharacter;
            this.characterImage.Location = new System.Drawing.Point(4, 26);
            this.characterImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(119, 92);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImage.TabIndex = 0;
            this.characterImage.TabStop = false;
            this.characterImage.Click += new System.EventHandler(this.characterImage_Click);
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Location = new System.Drawing.Point(137, 55);
            this.chooseImageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(140, 28);
            this.chooseImageButton.TabIndex = 4;
            this.chooseImageButton.Text = "Choose Image...";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // imageNamelabel
            // 
            this.imageNamelabel.AutoSize = true;
            this.imageNamelabel.Location = new System.Drawing.Point(143, 27);
            this.imageNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageNamelabel.Name = "imageNamelabel";
            this.imageNamelabel.Size = new System.Drawing.Size(91, 17);
            this.imageNamelabel.TabIndex = 6;
            this.imageNamelabel.Text = "Image Name:";
            // 
            // imageNameTextBox
            // 
            this.imageNameTextBox.Location = new System.Drawing.Point(244, 23);
            this.imageNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imageNameTextBox.Name = "imageNameTextBox";
            this.imageNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.imageNameTextBox.TabIndex = 3;
            this.imageNameTextBox.TextChanged += new System.EventHandler(this.imageNameTextBox_TextChanged);
            // 
            // characterImageList
            // 
            this.characterImageList.FormattingEnabled = true;
            this.characterImageList.ItemHeight = 16;
            this.characterImageList.Location = new System.Drawing.Point(441, 31);
            this.characterImageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.characterImageList.Name = "characterImageList";
            this.characterImageList.Size = new System.Drawing.Size(129, 212);
            this.characterImageList.TabIndex = 9;
            this.characterImageList.SelectedIndexChanged += new System.EventHandler(this.characterImageList_SelectedIndexChanged);
            // 
            // characterList
            // 
            this.characterList.FormattingEnabled = true;
            this.characterList.ItemHeight = 16;
            this.characterList.Location = new System.Drawing.Point(303, 31);
            this.characterList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.characterList.Name = "characterList";
            this.characterList.Size = new System.Drawing.Size(129, 84);
            this.characterList.TabIndex = 7;
            this.characterList.SelectedIndexChanged += new System.EventHandler(this.characterList_SelectedIndexChanged);
            // 
            // deleteSelectedCharacterButton
            // 
            this.deleteSelectedCharacterButton.Location = new System.Drawing.Point(8, 57);
            this.deleteSelectedCharacterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteSelectedCharacterButton.Name = "deleteSelectedCharacterButton";
            this.deleteSelectedCharacterButton.Size = new System.Drawing.Size(131, 23);
            this.deleteSelectedCharacterButton.TabIndex = 8;
            this.deleteSelectedCharacterButton.TabStop = false;
            this.deleteSelectedCharacterButton.Text = "Delete Character";
            this.deleteSelectedCharacterButton.UseVisualStyleBackColor = true;
            this.deleteSelectedCharacterButton.Click += new System.EventHandler(this.deleteSelectedCharacterButton_Click);
            // 
            // createNewCharacterButton
            // 
            this.createNewCharacterButton.Location = new System.Drawing.Point(145, 57);
            this.createNewCharacterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNewCharacterButton.Name = "createNewCharacterButton";
            this.createNewCharacterButton.Size = new System.Drawing.Size(119, 23);
            this.createNewCharacterButton.TabIndex = 2;
            this.createNewCharacterButton.Text = "Create New Character";
            this.createNewCharacterButton.UseVisualStyleBackColor = true;
            this.createNewCharacterButton.Click += new System.EventHandler(this.createNewCharacterButton_Click);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Location = new System.Drawing.Point(15, 30);
            this.characterNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(115, 17);
            this.characterNameLabel.TabIndex = 12;
            this.characterNameLabel.Text = "Character Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.characterNameLabel);
            this.groupBox1.Controls.Add(this.createNewCharacterButton);
            this.groupBox1.Controls.Add(this.deleteSelectedCharacterButton);
            this.groupBox1.Controls.Add(this.characterNameBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(277, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Character";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.closeButton);
            this.groupBox2.Controls.Add(this.deleteImageButton);
            this.groupBox2.Controls.Add(this.addImageToCharacterButton);
            this.groupBox2.Controls.Add(this.characterImage);
            this.groupBox2.Controls.Add(this.chooseImageButton);
            this.groupBox2.Controls.Add(this.imageNamelabel);
            this.groupBox2.Controls.Add(this.imageNameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(16, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(416, 130);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Images";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(303, 91);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(105, 28);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Location = new System.Drawing.Point(303, 55);
            this.deleteImageButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(105, 28);
            this.deleteImageButton.TabIndex = 10;
            this.deleteImageButton.TabStop = false;
            this.deleteImageButton.Text = "Delete Image";
            this.deleteImageButton.UseVisualStyleBackColor = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // addImageToCharacterButton
            // 
            this.addImageToCharacterButton.Location = new System.Drawing.Point(137, 90);
            this.addImageToCharacterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addImageToCharacterButton.Name = "addImageToCharacterButton";
            this.addImageToCharacterButton.Size = new System.Drawing.Size(161, 28);
            this.addImageToCharacterButton.TabIndex = 5;
            this.addImageToCharacterButton.Text = "Add Character Image";
            this.addImageToCharacterButton.UseVisualStyleBackColor = true;
            this.addImageToCharacterButton.Click += new System.EventHandler(this.addImageToCharacterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Character Names:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Character Images:";
            // 
            // EditCharactersForm
            // 
            this.AcceptButton = this.createNewCharacterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(569, 238);

            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.characterList);
            this.Controls.Add(this.characterImageList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "EditCharactersForm";
            this.Text = "Edit Characters";
            this.Load += new System.EventHandler(this.EditCharactersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox characterNameBox;
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.Button chooseImageButton;
        private System.Windows.Forms.Label imageNamelabel;
        private System.Windows.Forms.TextBox imageNameTextBox;
        private System.Windows.Forms.ListBox characterImageList;
        private System.Windows.Forms.ListBox characterList;
        private System.Windows.Forms.Button deleteSelectedCharacterButton;
        private System.Windows.Forms.Button createNewCharacterButton;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addImageToCharacterButton;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}