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
            this.imageGroupBox = new System.Windows.Forms.GroupBox();
            this.soundGroupBox = new System.Windows.Forms.GroupBox();
            this.usePlayButtonSound = new System.Windows.Forms.CheckBox();
            this.useBackgroundSound = new System.Windows.Forms.CheckBox();
            this.defaultFontButton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.FontGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).BeginInit();
            this.imageGroupBox.SuspendLayout();
            this.soundGroupBox.SuspendLayout();
            this.FontGroupBox.SuspendLayout();
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
            this.selectMainMenuImageButton.Click += new System.EventHandler(this.selectMainMenuImageButton_Click);
            // 
            // imageGroupBox
            // 
            this.imageGroupBox.Controls.Add(this.mainMenuPictureBox);
            this.imageGroupBox.Controls.Add(this.selectMainMenuImageButton);
            this.imageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.imageGroupBox.Name = "imageGroupBox";
            this.imageGroupBox.Size = new System.Drawing.Size(242, 205);
            this.imageGroupBox.TabIndex = 13;
            this.imageGroupBox.TabStop = false;
            this.imageGroupBox.Text = "Main Menu Image";
            // 
            // soundGroupBox
            // 
            this.soundGroupBox.Controls.Add(this.usePlayButtonSound);
            this.soundGroupBox.Controls.Add(this.useBackgroundSound);
            this.soundGroupBox.Location = new System.Drawing.Point(12, 223);
            this.soundGroupBox.Name = "soundGroupBox";
            this.soundGroupBox.Size = new System.Drawing.Size(148, 69);
            this.soundGroupBox.TabIndex = 50;
            this.soundGroupBox.TabStop = false;
            this.soundGroupBox.Text = "Sounds (Optional)";
            // 
            // usePlayButtonSound
            // 
            this.usePlayButtonSound.AutoSize = true;
            this.usePlayButtonSound.Location = new System.Drawing.Point(6, 42);
            this.usePlayButtonSound.Name = "usePlayButtonSound";
            this.usePlayButtonSound.Size = new System.Drawing.Size(136, 17);
            this.usePlayButtonSound.TabIndex = 1;
            this.usePlayButtonSound.Text = "Use Play Button Sound";
            this.usePlayButtonSound.UseVisualStyleBackColor = true;
            this.usePlayButtonSound.CheckedChanged += new System.EventHandler(this.usePlayButtonSound_CheckedChanged);
            // 
            // useBackgroundSound
            // 
            this.useBackgroundSound.AutoSize = true;
            this.useBackgroundSound.Location = new System.Drawing.Point(6, 19);
            this.useBackgroundSound.Name = "useBackgroundSound";
            this.useBackgroundSound.Size = new System.Drawing.Size(140, 17);
            this.useBackgroundSound.TabIndex = 1;
            this.useBackgroundSound.Text = "Use Background Sound";
            this.useBackgroundSound.UseVisualStyleBackColor = true;
            this.useBackgroundSound.CheckedChanged += new System.EventHandler(this.useMusic_CheckedChanged);
            // 
            // defaultFontButton
            // 
            this.defaultFontButton.Location = new System.Drawing.Point(7, 19);
            this.defaultFontButton.Name = "defaultFontButton";
            this.defaultFontButton.Size = new System.Drawing.Size(83, 20);
            this.defaultFontButton.TabIndex = 52;
            this.defaultFontButton.Text = "Choose Font";
            this.defaultFontButton.UseVisualStyleBackColor = true;
            this.defaultFontButton.Click += new System.EventHandler(this.defaultFontButton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(50, 298);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 54;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(131, 298);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 53;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // FontGroupBox
            // 
            this.FontGroupBox.Controls.Add(this.defaultFontButton);
            this.FontGroupBox.Location = new System.Drawing.Point(164, 232);
            this.FontGroupBox.Name = "FontGroupBox";
            this.FontGroupBox.Size = new System.Drawing.Size(95, 50);
            this.FontGroupBox.TabIndex = 55;
            this.FontGroupBox.TabStop = false;
            this.FontGroupBox.Text = "Font";
            // 
            // EditMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 335);
            this.Controls.Add(this.FontGroupBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.soundGroupBox);
            this.Controls.Add(this.imageGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMainMenuForm";
            this.Text = "Edit Main Menu";
            this.Load += new System.EventHandler(this.EditMainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).EndInit();
            this.imageGroupBox.ResumeLayout(false);
            this.soundGroupBox.ResumeLayout(false);
            this.soundGroupBox.PerformLayout();
            this.FontGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainMenuPictureBox;
        private System.Windows.Forms.Button selectMainMenuImageButton;
        private System.Windows.Forms.GroupBox imageGroupBox;
        private System.Windows.Forms.GroupBox soundGroupBox;
        private System.Windows.Forms.CheckBox useBackgroundSound;
        private System.Windows.Forms.CheckBox usePlayButtonSound;
        private System.Windows.Forms.Button defaultFontButton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.GroupBox FontGroupBox;
    }
}