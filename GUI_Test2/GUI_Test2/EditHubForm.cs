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
    //Need to add a way to add 2nd button image
    public partial class EditHubForm : Form
    {
        private List<Button> buttonList;
        private List<string> buttonNameList;
        private int buttonCount;
        private ProjectHomeForm parentForm;
        private string hubName;
        private int navType;
        private string buttonImagePath1;
        private string buttonImagePath2;
        private string hubImagePath;

        public EditHubForm(ProjectHomeForm par, string name)
        {
            InitializeComponent();
            parentForm = par;
            hubName = name;
            buttonImagePath1 = "";
            buttonImagePath2 = "";
            hubImagePath = "";
            buttonList = new List<Button>();


            updateListBox();
        }
        public EditHubForm(ProjectHomeForm par, Hub that)
        {
            InitializeComponent();
            this.parentForm = par;
            this.hubName = that.name;
            this.hubImagePath = that.hubImage;
            this.buttonList = that.buttons;

            updateListBox();
        }

        private void EditHubForm_Load(object sender, EventArgs e)
        {
            this.Text = "Edit Hub: " + hubName;
            buttonNameList = new List<string>();
            for (int i = 1; i <= buttonCount; i++)
            {
                buttonNameList.Add("Button " + i);
            }
            hubImagePictureBox.ImageLocation = hubImagePath;
        }

        private void buttonListUpButton_Click(object sender, EventArgs e)
        {
            int index = buttonListBox.SelectedIndex;
            if (index != -1 && index != 0)
            {
                swap(index, index - 1);
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

        private void swap(int from, int to)
        {
            Button temp = new Button();

            if (to >= 0 && to < buttonList.Count)
            {
                temp = buttonList[to];
                buttonList[to] = buttonList[from];
                buttonList[from] = temp;

                string t = buttonNameList[to];
                buttonNameList[to] = buttonNameList[from];
                buttonNameList[from] = t;
            }
        }

        private void updateListBox()
        {
            buttonListBox.DataSource = null;
            buttonListBox.DataSource = buttonNameList;
            buttonListBox.SelectedIndex = -1;

        }

        private bool inButtonList(List<Button> bl, string s)
        {
            foreach (Button b in bl)
            {
                if (b.text == s)
                    return true;
            }

            return false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Game.navIndex.ContainsKey(hubName))
            {
                Game.navIndex[hubName] = new Hub(hubName, buttonList, hubImagePath);
            }
            else
            {
                Game.hubs.Add(hubName);
                Game.navIndex.Add(hubName, new Hub(hubName, buttonList, hubImagePath));
            }
            parentForm.updateListBoxes();
            Close();

        }

        private void setScope()
        {
            if (navType != -1)
            {
                navComboBox.DataSource = null;
                switch (navType)
                {
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

        private void createButtonButton_Click(object sender, EventArgs e)
        {
            string text, pic1path, pic2path, next;
            int sizeX, sizeY, posX, posY, highlight;

            if (buttonTextTextBox.Text == "")
            {
                MessageBox.Show("Button Text is required.");
                return;
            }
            else
            {
                text = buttonTextTextBox.Text;
            }

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
                //max width is 1920
                try
                {
                    sizeX = Int32.Parse(buttonWidthTextBox.Text);
                    sizeY = Int32.Parse(buttonHeightTextBox.Text);
                }
                catch (FormatException ex)
                {
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
                else if (buttonNameList.Count == 1)
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
                catch (FormatException ex)
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
                if (Math.Abs(posY) > 540)
                {
                    MessageBox.Show("Y coordinate must be between -540 and 540.");
                    buttonYLocTextBox.Text = "";
                    return;
                }
            }

            if (useButtonImage.Checked)
            {
                //Need to add a way to choose the 2nd button image
                pic1path = buttonImagePath1;
                pic2path = buttonImagePath1;
            }
            else
            {
                pic1path = "";
                pic2path = "";
            }

            if (navComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Target Navigable \nfor the Button to lead to.");
                return;
            }
            else
            {
                //Passes a string
                if (pathFromButtonRadio.Checked == true)
                    next = Game.paths[navComboBox.SelectedIndex];
                else if (pathGroupFromButtonRadio.Checked == true)
                    next = Game.pathGroups[navComboBox.SelectedIndex];
                else
                    next = Game.hubs[navComboBox.SelectedIndex];
            }

            //Need to add the option for what gets highlighted
            highlight = 0;

            if (inButtonList(buttonList, buttonTextTextBox.Text))
            {
                buttonList[buttonListBox.SelectedIndex] = new Button(text,sizeX,sizeY,posX,posY,pic1path,pic2path,highlight,next);
            }
            else
            {
                buttonList.Add(new Button(text, sizeX, sizeY, posX, posY, pic1path, pic2path, highlight, next));
                buttonCount++;
                buttonNameList.Add("Button " + buttonCount);
            }
            

            buttonWidthTextBox.Text = "";
            buttonHeightTextBox.Text = "";
            buttonXLocTextBox.Text = "";
            buttonYLocTextBox.Text = "";

            updateListBox();
    }

        private void deleteButtonButton_Click(object sender, EventArgs e)
        {
            int index = buttonListBox.SelectedIndex;
            try
            {
                buttonList.RemoveAt(index);
                buttonNameList.RemoveAt(index);
                if (index == buttonList.Count)
                    index = index - 1;

                updateListBox();
                buttonListBox.SelectedIndex = index;

            }
            catch { }
        }

        private void chooseHubImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            of.ShowDialog();

            try
            {
                hubImagePictureBox.Image = Image.FromStream(of.OpenFile());
                hubImagePath = of.FileName;
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void useButtonImage_CheckedChanged(object sender, EventArgs e)
        {
            if (useButtonImage.Checked)
            {
                buttonPictureBox.Enabled = true;
                chooseButtonImageButton.Enabled = true;
            }
            else {
                buttonPictureBox.Enabled = false;
                chooseButtonImageButton.Enabled = false;
            }
        }

        private void setButtonImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            of.ShowDialog();

            try
            {
                buttonPictureBox.Image = Image.FromStream(of.OpenFile());
                buttonImagePath1 = of.FileName;
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        //This was an accidental click, need to remove
        private void addButtonBox_Enter(object sender, EventArgs e)
        {

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

        private void buttonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load the selected button into the editor
            if (buttonListBox.SelectedIndex != -1)
            {
                //Text
                buttonTextTextBox.Text = buttonList[buttonListBox.SelectedIndex].text;

                //Type
                Button b = buttonList[buttonListBox.SelectedIndex];
                if (Game.navIndex[b.next].isPath())
                {
                    pathFromButtonRadio.Checked = true;
                }
                else if (Game.navIndex[b.next].isPathGroup())
                {
                    pathGroupFromButtonRadio.Checked = true;
                }
                else
                {
                    hubFromButtonRadio.Checked = true;
                }

                //Next
                navComboBox.SelectedIndex = navComboBox.FindStringExact(b.next);

                //Size
                if (b.sizeX == 300 && b.sizeY == 100)
                {
                    useButtonSizeDefaults.Checked = true;
                }
                else
                {
                    useButtonSizeDefaults.Checked = false;
                    buttonWidthTextBox.Text = b.sizeX.ToString();
                    buttonHeightTextBox.Text = b.sizeY.ToString();
                }

                //Position
                if (buttonNameList.Count < 2 && (b.posX == -200 || b.posX == 200) && b.posY == 300)
                {
                    useButtonLocationDefaults.Checked = true;
                }
                else
                {
                    useButtonLocationDefaults.Checked = false;
                    buttonXLocTextBox.Text = b.posX.ToString();
                    buttonYLocTextBox.Text = b.posY.ToString();
                }

                //Picture 1
                if (b.pic1path == "")
                {
                    useButtonImage.Checked = false;
                }
                else
                {
                    useButtonImage.Checked = true;
                    buttonImagePath1 = b.pic1path;
                    buttonImagePath2 = b.pic2path;
                    buttonPictureBox.Image = Image.FromFile(buttonImagePath1);
                }

            }
            else
            {
                buttonTextTextBox.Text = "";
                navComboBox.Text = null;
            }
        }
    }
}
