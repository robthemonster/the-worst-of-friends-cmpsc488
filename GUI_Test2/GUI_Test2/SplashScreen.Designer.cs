namespace GUI_Test2
{
    partial class SplashScreen
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
            this.createNewProjectButton = new System.Windows.Forms.Button();
            this.loadProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewProjectButton
            // 
            this.createNewProjectButton.Location = new System.Drawing.Point(88, 62);
            this.createNewProjectButton.Name = "createNewProjectButton";
            this.createNewProjectButton.Size = new System.Drawing.Size(75, 23);
            this.createNewProjectButton.TabIndex = 0;
            this.createNewProjectButton.Text = "create new project";
            this.createNewProjectButton.UseVisualStyleBackColor = true;
            this.createNewProjectButton.Click += new System.EventHandler(this.createNewProjectButton_Click);
            // 
            // loadProjectButton
            // 
            this.loadProjectButton.Location = new System.Drawing.Point(88, 121);
            this.loadProjectButton.Name = "loadProjectButton";
            this.loadProjectButton.Size = new System.Drawing.Size(75, 23);
            this.loadProjectButton.TabIndex = 1;
            this.loadProjectButton.Text = "load project";
            this.loadProjectButton.UseVisualStyleBackColor = true;
            this.loadProjectButton.Click += new System.EventHandler(this.loadProjectButton_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.loadProjectButton);
            this.Controls.Add(this.createNewProjectButton);
            this.Name = "SplashScreen";
            this.RightToLeftLayout = true;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNewProjectButton;
        private System.Windows.Forms.Button loadProjectButton;
    }
}

