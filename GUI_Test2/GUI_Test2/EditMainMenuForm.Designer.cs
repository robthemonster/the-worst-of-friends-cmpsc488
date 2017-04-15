namespace GUI_Test2
{
    partial class EditMainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMainMenuForm));
            this.mainMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.selectMainMenuImageButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.musicBox = new System.Windows.Forms.GroupBox();
            this.useMusic = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.defaultFontButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.FontBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.musicBox.SuspendLayout();
            this.FontBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPictureBox
            // 
            this.mainMenuPictureBox.Location = new System.Drawing.Point(6, 19);
            this.mainMenuPictureBox.Name = "mainMenuPictureBox";
            this.mainMenuPictureBox.Size = new System.Drawing.Size(230, 153);
            this.mainMenuPictureBox.TabIndex = 0;
            this.mainMenuPictureBox.TabStop = false;
            // 
            // selectMainMenuImageButton
            // 
            this.selectMainMenuImageButton.Location = new System.Drawing.Point(48, 177);
            this.selectMainMenuImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectMainMenuImageButton.Name = "selectMainMenuImageButton";
            this.selectMainMenuImageButton.Size = new System.Drawing.Size(136, 21);
            this.selectMainMenuImageButton.TabIndex = 12;
            this.selectMainMenuImageButton.Text = "Select Main Menu Image";
            this.selectMainMenuImageButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainMenuPictureBox);
            this.groupBox1.Controls.Add(this.selectMainMenuImageButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 205);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Menu Image";
            // 
            // musicBox
            // 
            this.musicBox.Controls.Add(this.checkBox1);
            this.musicBox.Controls.Add(this.useMusic);
            this.musicBox.Location = new System.Drawing.Point(12, 223);
            this.musicBox.Name = "musicBox";
            this.musicBox.Size = new System.Drawing.Size(148, 69);
            this.musicBox.TabIndex = 50;
            this.musicBox.TabStop = false;
            this.musicBox.Text = "Sounds (Optional)";
            // 
            // useMusic
            // 
            this.useMusic.AutoSize = true;
            this.useMusic.Location = new System.Drawing.Point(6, 19);
            this.useMusic.Name = "useMusic";
            this.useMusic.Size = new System.Drawing.Size(140, 17);
            this.useMusic.TabIndex = 1;
            this.useMusic.Text = "Use Background Sound";
            this.useMusic.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Use Play Button Sound";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // defaultFontButton
            // 
            this.defaultFontButton.Location = new System.Drawing.Point(7, 19);
            this.defaultFontButton.Name = "defaultFontButton";
            this.defaultFontButton.Size = new System.Drawing.Size(83, 20);
            this.defaultFontButton.TabIndex = 52;
            this.defaultFontButton.Text = "Choose Font";
            this.defaultFontButton.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(50, 298);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 54;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(131, 298);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 53;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // FontBox
            // 
            this.FontBox.Controls.Add(this.defaultFontButton);
            this.FontBox.Location = new System.Drawing.Point(164, 232);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(95, 50);
            this.FontBox.TabIndex = 55;
            this.FontBox.TabStop = false;
            this.FontBox.Text = "Font";
            // 
            // EditMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 335);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.musicBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMainMenuForm";
            this.Text = "Edit Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.musicBox.ResumeLayout(false);
            this.musicBox.PerformLayout();
            this.FontBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainMenuPictureBox;
        private System.Windows.Forms.Button selectMainMenuImageButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox musicBox;
        private System.Windows.Forms.CheckBox useMusic;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button defaultFontButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.GroupBox FontBox;
    }
}