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
        private string hubName;
        private int navType;

        public EditHubForm(String name)
        {
            InitializeComponent();
            this.Text = "Edit Hub: " + name;
            hubName = name;
            buttonList = new List<Button>();
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //if(Game.navIndex.ContainsKey())
        }

        private void createButtonButton_Click(object sender, EventArgs e)
        {
            string text, pic1path, pic2path, next;
            int sizeX, sizeY, posX, posY, highlight;


            if (useButtonSizeDefaults.Checked)
            {
                //1920,1080 screen size
                //-200,300 posL
                //200, 300 posR
                //300,100 size
                //CHANGE These are placeholder values
                sizeX = 300;
                sizeY = 100;
            }
            else
            {
                //PICK UP HERE
                //max width is 1920
                try
                {
                    sizeX = Int32.Parse(buttonWidthTextBox.Text);
                    sizeY = Int32.Parse(buttonHeightTextBox.Text);
                }
                catch(FormatException ex) {
                    MessageBox.Show("Width must be a positive number, less than 1920 \nHeight must be a positive number less than 1080");
                    buttonWidthTextBox.Text = "";
                    buttonHeightTextBox.Text = "";
                    return;
                }
                if (sizeX > 1920 || sizeX <= 0)
                {
                    MessageBox.Show("Size width needs positive number less than 1920.");
                    buttonWidthTextBox.Text = "";
                    return;
                }
                
                //sizeY check 0<Y<1080
            
                if (sizeY > 1080 || sizeY <= 0)
                {
                    MessageBox.Show("Size height needs positive number less than 1080.");
                    buttonHeightTextBox.Text = "";
                    return;
                }
            }

            if (useButtonLocationDefaults.Checked)
            {
                if (buttonNameList.Count == 0)
                {
                    posX = -200;
                    posY = 300;
                }
                else if(buttonNameList.Count == 1)
                {
                    posX = 200;
                    posY = 300;
                }
                else
                {
                    MessageBox.Show("Default positions not available for more than two buttons.");
                    return;
                }
            }
            else
            {
                try
                {
                    posX = Int32.Parse(buttonXLocTextBox.Text);
                    posY = Int32.Parse(buttonYLocTextBox.Text);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show("X and Y must be positive numbers.\n" +
                        "X must be less than 960.\n" +
                        "Y must be less than 540.");
                    buttonXLocTextBox.Text = "";
                    buttonYLocTextBox.Text = "";
                    return;
                }

                if (Math.Abs(posX) > 960)
                {
                    MessageBox.Show("X coordinate must be between -960 and 960.");
                    buttonXLocTextBox.Text = "";
                    return;
                }
                if(Math.Abs(posY) > 540)
                {
                    MessageBox.Show("Y coordinate must be between -540 and 540.");
                    buttonYLocTextBox.Text = "";
                    return;
                }
            }

            if (useButtonImage.Checked)
            {
            }
            else
            {
                pic1path = "";
                pic2path = "";
            }


            buttonWidthTextBox.Text = "";
            buttonHeightTextBox.Text = "";
            buttonXLocTextBox.Text = "";
            buttonYLocTextBox.Text = "";
        }

        private void EditHubForm_Load(object sender, EventArgs e)
        {
            buttonNameList = new List<string>();
        }
        private void setScope() {
            if (navType != -1)
            {
                navComboBox.DataSource = null;
                switch (navType) {
                    case 0:
                        navComboBox.DataSource = Game.paths;
                        break;
                    case 1:
                        navComboBox.DataSource = Game.pathGroups;
                        break;
                    case 2:
                        navComboBox.DataSource = Game.hubs;
                        break;
                }

            }
        }

        private void pathFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            navType = 0;
            setScope();
        }

        private void pathGroupFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            navType = 1;
            setScope();
        }

        private void hubFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            navType = 2;
            setScope();
        }
    }
}
