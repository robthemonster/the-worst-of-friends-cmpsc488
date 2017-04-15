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
    public partial class EditPathForm : Form
    {
        private List <String> dialogueEntryList;
        private List <Button> buttonList;
        private ProjectHomeForm parentForm;
        private String name;
        private String[] ops;
        private int scope;
        private string currHub;
        private List<List<Impact>> dialogueImpactList;
        //Galen Additions
        private List<string> buttonNameList;
        private int buttonCount;
        private int navType;
        private string buttonImagePath1;
        private string buttonImagePath2;
        private string pathSoundPath;
        private string pathImagePath;
        private bool buttonLoading = false;
        private int buttonImageState = 0;
        private bool musicSelected = false;
        private bool musicLoading = false;

        public EditPathForm( ProjectHomeForm par, String n)
        {
            InitializeComponent();
            parentForm = par;
            name = n;
            this.Text = "Edit Path: "+name;
            dialogueEntryList = new List<String>();
            buttonList = new List<Button>();
            buttonNameList = new List<string>();
            dialogueImpactList = new List<List<Impact>>();
            buttonCount = buttonList.Count;
            buttonNameList = new List<string>();
            for (int i = 1; i <= buttonCount; i++)
            {
                buttonNameList.Add("Button " + i);
            }
            buttonImagePath1 = "";
            buttonImagePath2 = "";
            pathSoundPath = "";
            pathImagePath = "";
        }
        public EditPathForm(ProjectHomeForm par, Path p)
        {
            InitializeComponent();
            parentForm = par;
            name = p.name;
            this.Text = "Edit Path: " + name;
            dialogueEntryList = p.dialogueContents;
            buttonList = p.buttons;
            dialogueImpactList = p.dialogueImpactList;
            buttonCount = buttonList.Count;
            buttonNameList = new List<string>();
            for (int i = 1; i <= buttonCount; i++)
            {
                buttonNameList.Add("Button " + i);
            }

            pathImagePath = p.pathImagePath;
            pathSoundPath = p.pathSoundPath;

            updateButtonListBox();
        }
            

        private void EditPath_Load(object sender, EventArgs e)
        {
            this.AcceptButton = createNewDialogueButton;
            ops = new String[] { "=", "-", "+" };
            opComboBox.DataSource = this.ops;
            scope = 0;
            currHub = "";
           
            hubSelectionComboBox.DataSource = Game.hubs;
            pathFromButtonRadio.Checked = true;


            updateListBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dialogueTextBox.Text == ""||dialogueTextBox==null)
            {

            }
            else
            {
                dialogueEntryList.Add(dialogueTextBox.Text);
                dialogueTextBox.Text = null;
                updateListBoxes();
            }
        }
        private void selectDefaultPathImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            
            of.ShowDialog();
            try
            {
                defaultPathImage.Image = Image.FromStream(of.OpenFile());
                pathImagePath = of.FileName;
                
            }
            catch (IndexOutOfRangeException)
            {


            }
        }

        
        

        private void dialogueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialogueList.SelectedIndex != -1)
            {
                dialogueTextBox.Text = dialogueEntryList[dialogueList.SelectedIndex];
            }
            else
            {
                dialogueTextBox.Text = null;
            }
        }
        

        private void ShiftDialogueUpButton_Click(object sender, EventArgs e)
        {
            int index = dialogueList.SelectedIndex;
            if (index != -1 && index!=0)
            {
                swapImpact(index, index - 1);
                updateListBoxes();
                dialogueList.SelectedIndex = index - 1;

            }
        }

        private void ShiftDialogueDownButton_Click(object sender, EventArgs e)
        {

            int index = dialogueList.SelectedIndex;
            if (index != -1 && index < dialogueEntryList.Count-1 )
            {
                swapImpact(dialogueList.SelectedIndex, dialogueList.SelectedIndex + 1);
                updateListBoxes();
                dialogueList.SelectedIndex = index + 1;

            }
        }
        private void swapImpact(int from, int to) {

            String temp;
            List<Impact> tempI;
            if(to>=0 && to< dialogueEntryList.Count)
            {
                temp= dialogueEntryList[to];
                dialogueEntryList[to] = dialogueEntryList[from];
                dialogueEntryList[from] = temp;

                tempI = dialogueImpactList[to];
                dialogueImpactList[to] = dialogueImpactList[from];
                dialogueImpactList[from] = tempI;



            }
         }

        private void swapButton(int from, int to)
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

        private bool inButtonList(List<Button> bl, string s)
        {
            foreach (Button b in bl)
            {
                if (b.text == s)
                    return true;
            }

            return false;
        }

        private void updateButtonListBox()
        {
            buttonListBox.DataSource = null;
            buttonListBox.DataSource = buttonNameList;
            buttonListBox.SelectedIndex = -1;

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

        private void DeleteSelectedDialogueButton_Click(object sender, EventArgs e)
        {
            int index = dialogueList.SelectedIndex;
            try
            {
                dialogueEntryList.RemoveAt(index);
                dialogueImpactList.RemoveAt(index);
                if (index == dialogueEntryList.Count)
                    index = index - 1;
                dialogueList.DataSource = null;
                dialogueList.DataSource = dialogueEntryList;
                dialogueList.SelectedIndex = index;

            }
            catch { }
        }

        private void createNewDialogueButton_Click(object sender, EventArgs e)
        {
            if (dialogueTextBox.Text != "" && dialogueTextBox != null)
            {
                dialogueEntryList.Add(dialogueTextBox.Text);
                dialogueImpactList.Add(new List<Impact>());
                dialogueTextBox.Text = "";
                updateListBoxes();

            }
        }
        private void updateListBoxes() {
            dialogueList.DataSource = null;
            dialogueList.DataSource = dialogueEntryList;
            dialogueList.SelectedIndex = -1;

            pathListBoxTab2.DataSource = null;
            pathListBoxTab2.DataSource = dialogueEntryList;
            
        }
        private void EditCreateImpact(object sender, EventArgs e) {
            if (pathListBoxTab2.SelectedIndex!=-1
                && attributeComboBox.SelectedIndex != -1 
                && opComboBox.SelectedIndex != -1 
                && (hubSelectionComboBox.SelectedIndex!=-1||!hubRadioButton.Checked)
                &&(hubRadioButton.Checked||globalRadioButton.Checked||playerRadioButton.Checked))
            {
                
                string name = (string)attributeComboBox.SelectedValue;
                int op = opComboBox.SelectedIndex;
                int val = (int)valueNumericUpDown.Value;
                Impact i = new Impact(scope, name, currHub, op, val);
                if (dialogueImpactList.Count> pathListBoxTab2.SelectedIndex && dialogueImpactList[pathListBoxTab2.SelectedIndex].Contains(i))
                {
                    dialogueImpactList[pathListBoxTab2.SelectedIndex].Remove(i);
                }
                dialogueImpactList[pathListBoxTab2.SelectedIndex].Add(i);
                updateImpactList();
                
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (Game.navIndex.ContainsKey(name))
            {
                Game.navIndex[name] = new Path(name, dialogueEntryList, buttonList, dialogueImpactList, pathImagePath, pathSoundPath);
            }
            else
            {
                Game.paths.Add(name);
                Game.navIndex.Add(name, new Path(name, dialogueEntryList, buttonList, dialogueImpactList, pathImagePath,pathSoundPath));
            }
            parentForm.updateListBoxes();
            Close();
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

        private void useButtonSizeDefaults_CheckedChanged(object sender, EventArgs e)
        {
            if (useButtonSizeDefaults.Checked) {
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

        private void Buttons_Click(object sender, EventArgs e)
        {

        }

        private void buttonListUpButton_Click(object sender, EventArgs e)
        {

            int index = buttonListBox.SelectedIndex;
            if (index != -1 && index != 0)
            {
                swapButton(index, index - 1);
                updateButtonListBox();
                buttonListBox.SelectedIndex = index - 1;

            }
        }

        private void buttonListDownButton_Click(object sender, EventArgs e)
        {
            int index = buttonListBox.SelectedIndex;
            if (index != -1 && index < buttonList.Count - 1)
            {
                swapButton(index, index + 1);
                updateButtonListBox();
                buttonListBox.SelectedIndex = index + 1;
            }
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

                updateButtonListBox();
                buttonListBox.SelectedIndex = index;

            }
            catch { }
        }

     

        private void useButton1Image_CheckedChanged(object sender, EventArgs e)
        {
            if (useButton1Image.Checked)
            {
                button1PictureBox.Enabled = true;
                //chooseButton1ImageButton.Enabled = true;
                if (!buttonLoading)
                {
                    chooseButton1ImageButton_Click(sender, e);
                    if (buttonImageState == 1) {
                        useButton2Image.Enabled = true;
                    }
                }
            }
            else{
                buttonImageState = 0;
                button1PictureBox.Enabled = false;
                //chooseButton1ImageButton.Enabled = false;
                useButton2Image.Checked = false;
                useButton2Image.Enabled = false;
            }
        }

        private void editDialogueButton_Click(object sender, EventArgs e)
        {
            if (dialogueList.SelectedIndex == -1)
            {
                if (dialogueTextBox.Text != "" && dialogueTextBox != null)
                {
                    dialogueEntryList.Add(dialogueTextBox.Text);
                    dialogueTextBox.Text = "";
                    updateListBoxes();
                }
            }
            else
            {
                dialogueEntryList[dialogueList.SelectedIndex] = dialogueTextBox.Text;
                dialogueTextBox.Text = "";
                updateListBoxes();
            }
        }

        private void globalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scope = 0;
            currHub = "";
            hubSelectionComboBox.Enabled = false;
            updateScope();
        }

        private void hubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            hubSelectionComboBox.Enabled = true;
            if (hubSelectionComboBox.SelectedIndex >= 0)
            {
                currHub = (String)hubSelectionComboBox.SelectedItem;
            }
            else
            {
                currHub = "";
            }
            scope = 1;
            updateScope();

        }

        private void playerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scope = 2;
            currHub = "";
            hubSelectionComboBox.Enabled = false;
            updateScope();

        }
        private void updateScope()
        {
            attributeComboBox.DataSource = null;
            attributeComboBox.DataSource = Attributes.getScope(scope, currHub);

            opComboBox.SelectedIndex = 2;
            valueNumericUpDown.Value = 0;
        }

        private List<String> getImpacts(int index)
        {
            List<String> impacts = new List<String>();
            if (index > -1 && dialogueImpactList.Count>0)
            {
                foreach(Impact i in dialogueImpactList[index])
                {
                    impacts.Add(i.attribute);
                }
            }
            return impacts;
        }

     

        private void hubSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (hubSelectionComboBox.SelectedIndex != -1)
            {
                currHub = (String) hubSelectionComboBox.SelectedItem;
            }
            else
            {
                currHub = "";
            }
            updateScope();

        }

        private void createImpactButton_Click(object sender, EventArgs e)
        {
            if(opComboBox.SelectedIndex!=-1 && attributeComboBox.SelectedIndex != -1)
            {

            }
            updateScope();
        }
        private void impactsTab_Selected(object sender, EventArgs e)
        {
            //update
        }
        private void pathListBoxTab2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateImpactList();
        }
        private void updateImpactList()
        {
            if (pathListBoxTab2.SelectedIndex != -1)
            {
                impactAttributeListBox.DataSource = null;
                impactAttributeListBox.DataSource = getImpacts(pathListBoxTab2.SelectedIndex);
            }
            else
            {
                impactAttributeListBox.DataSource = null;
            }

        }

        private void impactAttributeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (impactAttributeListBox.SelectedIndex != -1&&pathListBoxTab2.SelectedIndex!=-1)
            {
                Impact i = dialogueImpactList[pathListBoxTab2.SelectedIndex][impactAttributeListBox.SelectedIndex];
                scope = i.scope;
                currHub = i.hub;
                updateScope();
                attributeComboBox.SelectedIndex = Attributes.getScope(scope, currHub).IndexOf(i.attribute);
                opComboBox.SelectedIndex = i.op;
                valueNumericUpDown.Value = i.val;

            }
        }

        private void deleteImpactButton_Click(object sender, EventArgs e)
        {
            if (pathListBoxTab2.SelectedIndex != -1 && impactAttributeListBox.SelectedIndex != -1)
            {
                dialogueImpactList[pathListBoxTab2.SelectedIndex].RemoveAt(impactAttributeListBox.SelectedIndex);
                updateImpactList();
            }
        }

        private void createButtonButton_Click(object sender, EventArgs e)
        {
            string text, pic1path, pic2path, next;
            int sizeX, sizeY, posX, posY, highlight;


            text = buttonTextTextBox.Text;


            //If the button isn't selected, button size is required
            if (!useButton1Image.Checked && !useButtonSizeDefaults.Checked && (buttonWidthTextBox.Text.Equals("") || buttonHeightTextBox.Text.Equals("")))
            {
                MessageBox.Show("Button Size Required if No Picture is Used.");
                return;
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
                    Console.Out.WriteLine(ex.StackTrace);
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
                    Console.Out.WriteLine(ex.StackTrace);
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

            if (navComboBox.SelectedItem != null)
            { 
                //Passes a string
                if (pathFromButtonRadio.Checked)
                    next = Game.paths[navComboBox.SelectedIndex];
                else if (pathGroupFromButtonRadio.Checked)
                    next = Game.pathGroups[navComboBox.SelectedIndex];
                else
                    next = Game.hubs[navComboBox.SelectedIndex];
            }else
            {
                next = "";
            }

            if (useButton2Image.Checked && HighlightTextButton.Checked)
            {
                MessageBox.Show("Please Select Either to Highlight the Button, \nthe Button Text, or Neither. Please Do Not Select Both.");
                return;
            }

            if (useButton2Image.Checked)
                highlight = 2;

            else if (HighlightTextButton.Checked)
                highlight = 1;

            else
                highlight = 0;



            buttonList.Add(new Button(text, sizeX, sizeY, posX, posY, pic1path, pic2path, highlight, next));
            buttonCount++;
            buttonNameList.Add("Button " + buttonCount);



            updateButtonListBox();
        }

        private void buttonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buttonListBox.SelectedIndex != -1)
            {
                buttonLoading = true;
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
                if (buttonNameList.Count <= 2 && b.sizeX == 300 && b.sizeY == 100)
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
                if (buttonNameList.Count <= 2 && (b.posX == -200 || b.posX == 200) && b.posY == 300)
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
                    useButton1Image.Checked = false;
                }
                else
                {
                    useButton1Image.Checked = true;
                    buttonImagePath1 = b.pic1path;
                    button1PictureBox.Image = Image.FromFile(buttonImagePath1);
                }

                //Picture 2
                if (b.pic2path == "")
                {
                    useButton2Image.Checked = false;
                }
                else
                {
                    useButton2Image.Checked = true;
                    buttonImagePath2 = b.pic2path;
                    button2PictureBox.Image = Image.FromFile(buttonImagePath2);
                }
                buttonLoading = false;

            }
            else
            {
                buttonTextTextBox.Text = "";
                useButtonSizeDefaults.Checked = true;
                useButtonLocationDefaults.Checked = true;
                buttonXLocTextBox.Text = "";
                buttonYLocTextBox.Text = "";
                useButton1Image.Checked = false;
                useButton2Image.Checked = false;
                buttonImagePath1 = "";
                buttonImagePath2 = "";
                
            }
        }

        private void chooseButton1ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            //of.ShowDialog();

            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    button1PictureBox.Image = Image.FromStream(of.OpenFile());
                    buttonImagePath1 = of.FileName;
                    buttonImageState = 1;
                }

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void chooseButton2ImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            //of.ShowDialog();

            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    button2PictureBox.Image = Image.FromStream(of.OpenFile());
                    buttonImagePath2 = of.FileName;
                    buttonImageState = 2;
                }
;
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void useButton2Image_CheckedChanged(object sender, EventArgs e)
        { 
            if (useButton2Image.Checked)
            {
                button2PictureBox.Enabled = true;
                //chooseButton2ImageButton.Enabled = true;
                if (!buttonLoading)
                {
                    chooseButton2ImageButton_Click(sender, e);
                    if (buttonImageState == 2)
                    {
                        button2PictureBox.Enabled = false;
                    }
                    else
                    {
                        buttonLoading = true;
                        useButton2Image.Checked = false;
                        buttonLoading = false;
                    }
                }
            }
            else {
                button2PictureBox.Enabled = false;
                //chooseButton2ImageButton.Enabled = false;
            }
        }

        private void pathFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pathFromButtonRadio.Checked)
            {
                navType = 0;
                setScope();
            }
        }

        private void pathGroupFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pathGroupFromButtonRadio.Checked)
            {
                navType = 1;
                setScope();
            }
        }

        private void hubFromButtonRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (hubFromButtonRadio.Checked)
            {
                navType = 2;
                setScope();
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
        }

        private void chooseMusicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Audio files (*.ogg) | *.ogg";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            //of.ShowDialog();

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    pathSoundPath = of.FileName;
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
