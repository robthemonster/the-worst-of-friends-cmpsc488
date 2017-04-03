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
        
        

        public EditPathForm( ProjectHomeForm par, String n)
        {
            InitializeComponent();
            parentForm = par;
            name = n;
            this.Text = "Edit Path: "+name;
            dialogueEntryList = new List<String>();
        }
        public EditPathForm(ProjectHomeForm par, Path p)
        {
            InitializeComponent();
            parentForm = par;
            name = p.name;
            this.Text = "Edit Path: " + name;
            dialogueEntryList = p.dialogueContents;

        }
            

        private void EditPath_Load(object sender, EventArgs e)
        {
            this.AcceptButton = createNewDialogueButton;
            ops = new String[] { "+", "-", "/", "*", "=" };
            opComboBox.DataSource = this.ops;
            scope = 0;
            currHub = "";


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
            }
            catch (IndexOutOfRangeException ex)
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
                swap(index, index - 1);
                updateListBoxes();
                dialogueList.SelectedIndex = index - 1;

            }
        }

        private void ShiftDialogueDownButton_Click(object sender, EventArgs e)
        {

            int index = dialogueList.SelectedIndex;
            if (index != -1 && index < dialogueEntryList.Count-1 )
            {
                swap(dialogueList.SelectedIndex, dialogueList.SelectedIndex + 1);
                updateListBoxes();
                dialogueList.SelectedIndex = index + 1;

            }
        }
        private void swap(int from, int to) {
            String temp;
            if(to>=0 && to< dialogueEntryList.Count)
            {
                temp= dialogueEntryList[to];
                dialogueEntryList[to] = dialogueEntryList[from];
                dialogueEntryList[from] = temp;
                
            }
         }

        private void DeleteSelectedDialogueButton_Click(object sender, EventArgs e)
        {
            int index = dialogueList.SelectedIndex;
                try
                {
                    dialogueEntryList.RemoveAt(index);
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
            pathListBoxTab2.SelectedIndex = -1;

            attributeComboBox.DataSource = null;
            attributeComboBox.DataSource = Attributes.getScope(scope,currHub);
            attributeComboBox.SelectedIndex = -1;





        }
        private void EditCreateImpact(object sender, EventArgs e) {
            if (attributeComboBox.SelectedIndex != -1 &&
                opComboBox.SelectedIndex != -1 )
            {
                string name = (string)attributeComboBox.SelectedValue;
                string op = (string)opComboBox.SelectedValue;
                int val = (int)valueNumericUpDown.Value;
            }

        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (parentForm.navIndex.ContainsKey(name))
            {
                parentForm.navIndex[name] = new Path(name, dialogueEntryList, dialogueEntryList, buttonList);
            }
            else
            {
                parentForm.paths.Add(name);
                parentForm.navIndex.Add(name, new Path(name, dialogueEntryList, dialogueEntryList, buttonList));
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
                swap(buttonListBox.SelectedIndex, buttonListBox.SelectedIndex - 1);
                updateListBoxes();
                buttonListBox.SelectedIndex = index - 1;

            }
        }

        private void buttonListDownButton_Click(object sender, EventArgs e)
        {

            int index = buttonListBox.SelectedIndex;
            if (index != -1 && index < dialogueEntryList.Count - 1)
            {
                swap(buttonListBox.SelectedIndex, buttonListBox.SelectedIndex + 1);
                updateListBoxes();
                buttonListBox.SelectedIndex = index + 1;

            }
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

        private void isHubSpecific_CheckedChanged(object sender, EventArgs e)
        {
            if (allHubCheckBox.Checked)
                hubSelectionComboBox.Enabled = true;
            else
                hubSelectionComboBox.Enabled = false;
        }

        private void useButtonImage_CheckedChanged(object sender, EventArgs e)
        {
            if (useButtonImage.Checked)
            {
                buttonPictureBox.Enabled = true;
                setButtonImageButton.Enabled = true;
            }
            else{
                buttonPictureBox.Enabled = false;
                setButtonImageButton.Enabled = false;
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
            allHubCheckBox.Enabled = false;
            allHubCheckBox.Checked = false;
            hubSelectionComboBox.Enabled = false;
            updateScope();
        }

        private void hubRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            allHubCheckBox.Enabled = true;
            hubSelectionComboBox.Enabled = true;
            if (hubSelectionComboBox.SelectedIndex >= 0)
            {
                currHub = (String)hubSelectionComboBox.SelectedItem;
            }
            if (hubSelectionComboBox.SelectedIndex >= 0)
            scope = 1;
            updateScope();

        }

        private void playerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scope = 2;
            currHub = "";
            allHubCheckBox.Enabled = false;
            allHubCheckBox.Checked = false;
            hubSelectionComboBox.Enabled = false;
            updateScope();

        }
        private void updateScope()
        {

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
    }
    
}
