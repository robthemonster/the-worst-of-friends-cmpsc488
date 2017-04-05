using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Test2
{
    public partial class EditHubForm : Form
    {
        private List<Button> buttonList;
        private List<string> buttonNameList;
        private ProjectHomeForm parentForm;

        public EditHubForm(String name)
        {
            InitializeComponent();
            this.Text = "Edit Hub: " + name;
            updateListBox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void useButtonSizeDefaults_CheckedChanged(object sender, EventArgs e)
        {
            if (useButtonSizeDefaults.Checked)
            {
                label12.Enabled = false;
                label13.Enabled = false;
                label14.Enabled = false;
                buttonHeightTextBox.Enabled = false;
                buttonWidthTextBox.Enabled = false;
            }
            else
            {
                label12.Enabled = true;
                label13.Enabled = true;
                label14.Enabled = true;
                buttonHeightTextBox.Enabled = true;
                buttonWidthTextBox.Enabled = true;

            }
        }

        private void useButtonLocationDefaults_CheckedChanged(object sender, EventArgs e)
        {
            if (!useButtonLocationDefaults.Checked)
            {
                label9.Enabled = true;
                label10.Enabled = true;
                label11.Enabled = true;
                buttonXLocTextBox.Enabled = true;
                buttonYLocTextBox.Enabled = true;
            }
            else
            {
                label9.Enabled = false;
                label10.Enabled = false;
                label11.Enabled = false;
                buttonXLocTextBox.Enabled = false;
                buttonYLocTextBox.Enabled = false;
            }
        }

        private void buttonListUpButton_Click(object sender, EventArgs e)
        {
            int index = buttonListBox.SelectedIndex;
            if (index != -1 && index != 0)
            {
                swap(buttonListBox.SelectedIndex, buttonListBox.SelectedIndex - 1);
                updateListBox();
                buttonListBox.SelectedIndex = index - 1;

            }
        }

        private void buttonListDownButton_Click(object sender, EventArgs e)
        {
            int index = buttonListBox.SelectedIndex;
            if (index != -1 && index < buttonList.Count - 1)
            {
                swap(buttonListBox.SelectedIndex, buttonListBox.SelectedIndex + 1);
                updateListBox();
                buttonListBox.SelectedIndex = index + 1;

            }
        }

        private void useButtonImage_CheckedChanged(object sender, EventArgs e)
        {
            if (useButtonImage.Checked)
            {
                buttonPictureBox.Enabled = true;
                setButtonImageButton.Enabled = true;
            }
            else {
                buttonPictureBox.Enabled = false;
                setButtonImageButton.Enabled = false;
            }
        }

        private void swap(int from, int to)
        {
            Button temp = new Button();

            if (to >= 0 && to < buttonList.Count)
            {
                temp = buttonList[to];
                buttonList[to] = buttonList[from];
                buttonList[from] = temp;
            }
        }

        private void updateListBox()
        {
            buttonListBox.DataSource = null;
            buttonListBox.DataSource = buttonNameList;
            buttonListBox.SelectedIndex = -1;
        }

        private void deleteButtonButton_Click(object sender, EventArgs e)
        {
            int index = buttonListBox.SelectedIndex;
            try
            {
                buttonList.RemoveAt(index);
                if (index == buttonList.Count)
                    index = index - 1;

                buttonListBox.SelectedIndex = index;

            }
            catch { }
        }
    }
}
