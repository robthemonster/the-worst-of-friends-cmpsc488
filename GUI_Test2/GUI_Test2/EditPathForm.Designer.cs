﻿namespace GUI_Test2
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
            this.pathDialogueTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultPathImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dialogueList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedDialogueTextBox = new System.Windows.Forms.TextBox();
            this.DeleteSelectedDialogueButton = new System.Windows.Forms.Button();
            this.createNewDialogueButton = new System.Windows.Forms.Button();
            this.DialogueContentLabel = new System.Windows.Forms.Label();
            this.DialogueNameTextBox = new System.Windows.Forms.TextBox();
            this.ShiftDialogueDownButton = new System.Windows.Forms.Button();
            this.ShiftDialogueUpButton = new System.Windows.Forms.Button();
            this.selectDefaultPathImageButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Buttons = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pathLabelT2 = new System.Windows.Forms.Label();
            this.pathListBoxTab2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pathDialogueTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPathImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathDialogueTab
            // 
            this.pathDialogueTab.Controls.Add(this.tabPage1);
            this.pathDialogueTab.Controls.Add(this.tabPage2);
            this.pathDialogueTab.Controls.Add(this.Buttons);
            this.pathDialogueTab.Location = new System.Drawing.Point(12, 12);
            this.pathDialogueTab.Name = "pathDialogueTab";
            this.pathDialogueTab.SelectedIndex = 0;
            this.pathDialogueTab.Size = new System.Drawing.Size(663, 398);
            this.pathDialogueTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.cancelButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.defaultPathImage);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.selectDefaultPathImageButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 372);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dialogues";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(476, 323);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(78, 25);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(560, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(83, 25);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Create Dialogues for the Path:";
            // 
            // defaultPathImage
            // 
            this.defaultPathImage.Image = global::GUI_Test2.Properties.Resources.defaultPath;
            this.defaultPathImage.Location = new System.Drawing.Point(436, 52);
            this.defaultPathImage.Margin = new System.Windows.Forms.Padding(2);
            this.defaultPathImage.Name = "defaultPathImage";
            this.defaultPathImage.Size = new System.Drawing.Size(218, 126);
            this.defaultPathImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.defaultPathImage.TabIndex = 12;
            this.defaultPathImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.4375F));
            this.tableLayoutPanel1.Controls.Add(this.dialogueList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 296);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dialogueList
            // 
            this.dialogueList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dialogueList.FormattingEnabled = true;
            this.dialogueList.HorizontalScrollbar = true;
            this.dialogueList.Location = new System.Drawing.Point(3, 3);
            this.dialogueList.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dialogueList.Name = "dialogueList";
            this.dialogueList.Size = new System.Drawing.Size(104, 290);
            this.dialogueList.TabIndex = 3;
            this.dialogueList.SelectedIndexChanged += new System.EventHandler(this.dialogueList_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.selectedDialogueTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DeleteSelectedDialogueButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.createNewDialogueButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.DialogueContentLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DialogueNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ShiftDialogueDownButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ShiftDialogueUpButton, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(113, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(314, 290);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dialogue Name:";
            // 
            // selectedDialogueTextBox
            // 
            this.selectedDialogueTextBox.Location = new System.Drawing.Point(100, 29);
            this.selectedDialogueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.selectedDialogueTextBox.Multiline = true;
            this.selectedDialogueTextBox.Name = "selectedDialogueTextBox";
            this.selectedDialogueTextBox.Size = new System.Drawing.Size(211, 207);
            this.selectedDialogueTextBox.TabIndex = 2;
            // 
            // DeleteSelectedDialogueButton
            // 
            this.DeleteSelectedDialogueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteSelectedDialogueButton.Location = new System.Drawing.Point(194, 267);
            this.DeleteSelectedDialogueButton.Name = "DeleteSelectedDialogueButton";
            this.DeleteSelectedDialogueButton.Size = new System.Drawing.Size(117, 20);
            this.DeleteSelectedDialogueButton.TabIndex = 3;
            this.DeleteSelectedDialogueButton.Text = "Delete Selected";
            this.DeleteSelectedDialogueButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedDialogueButton.Click += new System.EventHandler(this.DeleteSelectedDialogueButton_Click);
            // 
            // createNewDialogueButton
            // 
            this.createNewDialogueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewDialogueButton.Location = new System.Drawing.Point(194, 243);
            this.createNewDialogueButton.Margin = new System.Windows.Forms.Padding(2);
            this.createNewDialogueButton.Name = "createNewDialogueButton";
            this.createNewDialogueButton.Size = new System.Drawing.Size(118, 19);
            this.createNewDialogueButton.TabIndex = 2;
            this.createNewDialogueButton.Text = "Create/Edit Dialogue";
            this.createNewDialogueButton.UseVisualStyleBackColor = true;
            this.createNewDialogueButton.Click += new System.EventHandler(this.createNewDialogueButton_Click);
            // 
            // DialogueContentLabel
            // 
            this.DialogueContentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogueContentLabel.AutoSize = true;
            this.DialogueContentLabel.Location = new System.Drawing.Point(6, 35);
            this.DialogueContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.DialogueContentLabel.Name = "DialogueContentLabel";
            this.DialogueContentLabel.Size = new System.Drawing.Size(89, 13);
            this.DialogueContentLabel.TabIndex = 6;
            this.DialogueContentLabel.Text = "Dialogue Content";
            // 
            // DialogueNameTextBox
            // 
            this.DialogueNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.DialogueNameTextBox.Name = "DialogueNameTextBox";
            this.DialogueNameTextBox.Size = new System.Drawing.Size(210, 20);
            this.DialogueNameTextBox.TabIndex = 7;
            // 
            // ShiftDialogueDownButton
            // 
            this.ShiftDialogueDownButton.Location = new System.Drawing.Point(3, 267);
            this.ShiftDialogueDownButton.Name = "ShiftDialogueDownButton";
            this.ShiftDialogueDownButton.Size = new System.Drawing.Size(24, 20);
            this.ShiftDialogueDownButton.TabIndex = 9;
            this.ShiftDialogueDownButton.Text = "▼";
            this.ShiftDialogueDownButton.UseVisualStyleBackColor = true;
            this.ShiftDialogueDownButton.Click += new System.EventHandler(this.ShiftDialogueDownButton_Click);
            // 
            // ShiftDialogueUpButton
            // 
            this.ShiftDialogueUpButton.Location = new System.Drawing.Point(3, 241);
            this.ShiftDialogueUpButton.Name = "ShiftDialogueUpButton";
            this.ShiftDialogueUpButton.Size = new System.Drawing.Size(24, 19);
            this.ShiftDialogueUpButton.TabIndex = 8;
            this.ShiftDialogueUpButton.Text = "▲";
            this.ShiftDialogueUpButton.UseVisualStyleBackColor = true;
            this.ShiftDialogueUpButton.Click += new System.EventHandler(this.ShiftDialogueUpButton_Click);
            // 
            // selectDefaultPathImageButton
            // 
            this.selectDefaultPathImageButton.Location = new System.Drawing.Point(435, 183);
            this.selectDefaultPathImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.selectDefaultPathImageButton.Name = "selectDefaultPathImageButton";
            this.selectDefaultPathImageButton.Size = new System.Drawing.Size(141, 19);
            this.selectDefaultPathImageButton.TabIndex = 11;
            this.selectDefaultPathImageButton.Text = "Select Default Image...";
            this.selectDefaultPathImageButton.UseVisualStyleBackColor = true;
            this.selectDefaultPathImageButton.Click += new System.EventHandler(this.selectDefaultPathImageButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 372);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Impacts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Buttons
            // 
            this.Buttons.Location = new System.Drawing.Point(4, 22);
            this.Buttons.Name = "Buttons";
            this.Buttons.Padding = new System.Windows.Forms.Padding(3);
            this.Buttons.Size = new System.Drawing.Size(655, 372);
            this.Buttons.TabIndex = 2;
            this.Buttons.Text = "Buttons";
            this.Buttons.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pathLabelT2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pathListBoxTab2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 15);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.928572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.07143F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(113, 336);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pathLabelT2
            // 
            this.pathLabelT2.AutoSize = true;
            this.pathLabelT2.Location = new System.Drawing.Point(3, 0);
            this.pathLabelT2.Name = "pathLabelT2";
            this.pathLabelT2.Size = new System.Drawing.Size(34, 13);
            this.pathLabelT2.TabIndex = 0;
            this.pathLabelT2.Text = "Paths";
            // 
            // pathListBoxTab2
            // 
            this.pathListBoxTab2.FormattingEnabled = true;
            this.pathListBoxTab2.Location = new System.Drawing.Point(3, 33);
            this.pathListBoxTab2.Name = "pathListBoxTab2";
            this.pathListBoxTab2.Size = new System.Drawing.Size(107, 290);
            this.pathListBoxTab2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(381, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Op";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "Select an Attribute";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attribute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(469, 147);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 6;
            // 
            // EditPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 422);
            this.Controls.Add(this.pathDialogueTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "EditPathForm";
            this.Text = " Edit Path";
            this.Load += new System.EventHandler(this.EditPath_Load);
            this.pathDialogueTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultPathImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pathDialogueTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox defaultPathImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox dialogueList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedDialogueTextBox;
        private System.Windows.Forms.Button DeleteSelectedDialogueButton;
        private System.Windows.Forms.Button createNewDialogueButton;
        private System.Windows.Forms.Label DialogueContentLabel;
        private System.Windows.Forms.TextBox DialogueNameTextBox;
        private System.Windows.Forms.Button ShiftDialogueDownButton;
        private System.Windows.Forms.Button ShiftDialogueUpButton;
        private System.Windows.Forms.Button selectDefaultPathImageButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage Buttons;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label pathLabelT2;
        private System.Windows.Forms.ListBox pathListBoxTab2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}