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
        private int buttonCount;
        private ProjectHomeForm parentForm;
        private string hubName;
        private int navType;
        private string buttonImagePath1;
        private string buttonImagePath2;
        private string hubImagePath;
        private string hubSoundPath;
        private int buttonImageState = 0;
        private bool musicSelected = false;
        private bool musicLoading = false;

        private const int NO_IMAGE_SELECTED = 0, ONE_IMAGE_SELECTED = 1, TWO_IMAGES_SELECTED = 2;

        public EditHubForm(ProjectHomeForm par, string name)
        {
            InitializeComponent();
            parentForm = par;
            hubName = name;
            buttonImagePath1 = "";
            buttonImagePath2 = "";
            hubImagePath = "";
            buttonList = new List<Button>();
            hubSoundPath = "";


            updateListBox();
        }
        public EditHubForm(ProjectHomeForm par, Hub that)
        {
            InitializeComponent();
            this.parentForm = par;
            this.hubName = that.name;
            this.hubImagePath = that.hubImage;
            this.buttonList = new List<Button>();
            foreach(Button b in that.buttons)
            {
                buttonList.Add(new Button(b));
            }
            buttonCount = buttonList.Count;
            buttonNameList = new List<string>();
            for (int i = 1; i <= buttonCount; i++)
            {
                buttonNameList.Add("Button " + i);
            }
            this.hubSoundPath = that.hubSound;
            if (!this.hubSoundPath.Equals(""))
            {
                musicLoading = true;
                useMusic.Checked = true;
                musicLoading = false;
            }

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

            pathFromButtonRadio.Checked = true;
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
                swap(index, index + 1);
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
                string THIS_SHOULD_BE_BUTTON_FONT = "";
                int THIS_SHOULD_BE_BUTTON_CHAR_SIZE = 30;
                Game.navIndex[hubName] = new Hub(hubName, buttonList, hubImagePath, hubSoundPath,THIS_SHOULD_BE_BUTTON_FONT, THIS_SHOULD_BE_BUTTON_CHAR_SIZE );
            }
            else
            {
                string THIS_SHOULD_BE_BUTTON_FONT = "";
                int THIS_SHOULD_BE_BUTTON_CHAR_SIZE = 30;
                Game.hubs.Add(hubName);
                Game.navIndex.Add(hubName, new Hub(hubName, buttonList, hubImagePath, hubSoundPath, THIS_SHOULD_BE_BUTTON_FONT, THIS_SHOULD_BE_BUTTON_CHAR_SIZE));
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
        
        
        private void createButtonButton_Click(object sender, EventArgs e)
        {
            string text, pic1path, pic2path, next;
            int sizeX, sizeY, posX, posY, highlight;

            
                text = buttonTextTextBox.Text;
            
            
            
            
            //max width is 1920
           
            sizeX = (int)buttonWidthNumericUpDown.Value;
            sizeY = (int)buttonHeightNumericUpDown.Value;
            
            
            
            
            
            
            posX = (int)buttonXLocNumericUpDown.Value;
            posY = (int)buttonYLocNumericUpDown.Value;
            
            

            if (useButton1Image.Checked)
            {
                if (buttonImagePath1 == "")
                {
                    MessageBox.Show("Please Select the Desired Button Image.");
                    return;
                }
                pic1path = buttonImagePath1;
            }
            else
            {
                pic1path = "";
            }

            if (useButton2Image.Checked)
            {
                if (buttonImagePath2 == "")
                {
                    MessageBox.Show("Please Select the Desired Highlight Image.");
                    return;
                }
                pic2path = buttonImagePath2;
            }
            else
            {
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
                if (pathFromButtonRadio.Checked)
                    next = Game.paths[navComboBox.SelectedIndex];
                else if (pathGroupFromButtonRadio.Checked)
                    next = Game.pathGroups[navComboBox.SelectedIndex];
                else
                    next = Game.hubs[navComboBox.SelectedIndex];
            }

            if (useButton2Image.Checked && HighlightTextButton.Checked)
            {
                MessageBox.Show("Please Select Either to Highlight the Button, \nthe Button Text, or Neither. Please Do Not Select Both.");
                return;
            }

            if (useButton2Image.Checked )
                highlight = Button.HIGHLIGHT_PICTURE;

            else if (HighlightTextButton.Checked )
                highlight = Button.HIGHLIGHT_TEXT;

            else
                highlight = Button.DO_NOTHING;


           
                buttonList.Add(new Button(text, sizeX, sizeY, posX, posY, pic1path, pic2path, highlight, next));
                buttonCount++;
                buttonNameList.Add("Button " + buttonCount);
            
           

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

            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    hubImagePictureBox.Image = Image.FromStream(of.OpenFile());
                    hubImagePath = of.FileName;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
        }

        private void useButton1Image_CheckedChanged(object sender, EventArgs e)
        {
            if (useButton1Image.Checked)
            {
                
                  
                    setButton1ImageButton_Click(sender, e);
                    if (buttonImageState == EditHubForm.ONE_IMAGE_SELECTED)
                    {
                        button1PictureBox.Visible = true;
                        useButton2Image.Enabled = true;
                    }else
                    {
                        useButton1Image.Checked = false;
                    }
                 
                
            }
            else
            {
                button1PictureBox.Visible = false;
                button2PictureBox.Visible = false;
                useButton2Image.Checked = false;
                useButton2Image.Enabled = false;
                buttonImageState = EditHubForm.NO_IMAGE_SELECTED;
            }
        }

        private void useButton2Image_CheckedChanged(object sender, EventArgs e)
        {
            if (useButton2Image.Checked)
            {
                    
                    setButton2ImageButton_Click(sender, e);
                    if (buttonImageState == EditHubForm.TWO_IMAGES_SELECTED)
                    {
                        button2PictureBox.Visible = true;
                    }else
                    {
                        useButton2Image.Checked = false;
                    }
                 
                
            }
            else
            {
                button2PictureBox.Visible = false;
                buttonImageState = EditHubForm.ONE_IMAGE_SELECTED;
            }
        }

        private void setButton1ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    button1PictureBox.Image = Image.FromStream(of.OpenFile());
                    buttonImagePath1 = of.FileName;
                    buttonImageState = EditHubForm.ONE_IMAGE_SELECTED;
                }
            }catch(IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }
;
         
        }

        private void setButton2ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
                
                
            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    button2PictureBox.Image = Image.FromStream(of.OpenFile());
                    buttonImagePath2 = of.FileName;
                    buttonImageState = EditHubForm.TWO_IMAGES_SELECTED;
                }
            }catch(IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
            }       
        }

        private void pathFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pathFromButtonRadio.Checked)
            {
                navType = Navigable.PATH;
                setScope();
            }
        }

        private void pathGroupFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pathGroupFromButtonRadio.Checked)
            {
                navType = Navigable.PATHGROUP;
                setScope();
            }
        }

        private void hubFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (hubFromButtonRadio.Checked)
            {
                navType = Navigable.HUB;
                setScope();
            }
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
                if (Game.navIndex[b.next].getNavType() == Navigable.PATH)
                {
                    pathFromButtonRadio.Checked = true;
                }
                else if (Game.navIndex[b.next].getNavType() == Navigable.PATHGROUP)
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
                buttonWidthNumericUpDown.Value = b.sizeX;
                buttonHeightNumericUpDown.Value = b.sizeY;

                //Position
                buttonXLocNumericUpDown.Value = b.posX;
                buttonYLocNumericUpDown.Value = b.posY;

                //Picture 1
                if (b.pic1path == "")
                {
                    useButton1Image.Checked = false;
                }
                else
                {
                    useButton1Image.CheckedChanged -= useButton1Image_CheckedChanged;
                    useButton1Image.Checked = true;
                    useButton1Image.CheckedChanged += useButton1Image_CheckedChanged;
                    buttonImagePath1 = b.pic1path;
                    button1PictureBox.ImageLocation = buttonImagePath1;
                    button1PictureBox.Visible = true;
                    useButton2Image.Enabled = true;

                    //Picture 2
                    if (b.pic2path == "")
                    {
                        useButton2Image.Checked = false;
                    }
                    else
                    {
                        useButton2Image.CheckedChanged -= useButton2Image_CheckedChanged;
                        useButton2Image.Checked = true;
                        useButton2Image.CheckedChanged += useButton2Image_CheckedChanged;
                        buttonImagePath2 = b.pic2path;
                        button2PictureBox.ImageLocation = buttonImagePath2;
                        button2PictureBox.Visible = true;
                    }
                }

                //Highlight
                if (b.highlight == 1)
                    HighlightTextButton.Checked = true;
                else
                    HighlightTextButton.Checked = false;

                buttonImageState = b.highlight;

                //Music

                //Target Navigable
                if (Game.paths.Contains(b.next))
                    pathFromButtonRadio.Checked = true;
                else if (Game.pathGroups.Contains(b.next))
                    pathGroupFromButtonRadio.Checked = true;
                else
                    hubFromButtonRadio.Checked = true;

                navComboBox.SelectedItem = b.next;

            }
            else
            {
                buttonTextTextBox.Text = "";
                buttonXLocNumericUpDown.Value = 0;
                buttonYLocNumericUpDown.Value = 0;
                useButton1Image.Checked = false;
                useButton2Image.Checked = false;
                HighlightTextButton.Checked = false;
                buttonImagePath1 = "";
                buttonImagePath2 = "";
                buttonImageState = 0;
            }
        }

        private void useMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (useMusic.Checked)
            {
                if (!musicLoading)
                {
                    chooseMusicButton_Click(sender, e);
                    if (!musicSelected)
                    {
                        musicLoading = true;
                        useMusic.Checked = false;
                        musicLoading = false;
                    }
                }
            }
            else
            {
                musicSelected = false;
            }
            // chooseMusicButton.Enabled = true;
            // chooseMusicButton.Enabled = false;
        }

        private void chooseMusicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Audio files (*.ogg, *.wav, *.flac, *.aiff) | *.ogg; *.wav; *.flac; *.aiff";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            //of.ShowDialog();

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    hubSoundPath = of.FileName;
                    musicSelected = true;
                }
                else
                {
                    musicSelected = false;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }
    }
}
