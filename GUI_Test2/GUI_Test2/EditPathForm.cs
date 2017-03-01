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
        private List<String> dialogueNameList;
        private List <String> dialogueEntryList;
        private ProjectHomeForm parentForm;
        private String name;
        private String[] ops;
        

        public EditPathForm( ProjectHomeForm par, String n)
        {
            InitializeComponent();
            parentForm = par;
            name = n;
            this.Text = "Edit Path: "+name;
            this.AcceptButton = createNewDialogueButton;
            dialogueEntryList = new List<String>();
            dialogueNameList = new List<String>();
            ops = new String[] { "+", "-", "/", "*", "=" };
            updateListBoxes();
        }
        public EditPathForm(ProjectHomeForm par, Path p)
        {
            InitializeComponent();
            parentForm = par;
            name = p.name;
            this.Text = "Edit Path: " + name;
            this.AcceptButton = createNewDialogueButton;
            dialogueEntryList = p.dialogueContents;
            dialogueNameList = p.dialogueNames;
            updateListBoxes();

        }
            

        private void EditPath_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedDialogueTextBox.Text == ""||selectedDialogueTextBox==null||DialogueNameTextBox.Text=="")
            {

            }
            else
            {
                dialogueNameList.Add(DialogueNameTextBox.Text);
                dialogueEntryList.Add(selectedDialogueTextBox.Text);
                selectedDialogueTextBox.Text = null;
                DialogueNameTextBox.Text = null;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        

        private void selectedDialogueText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dialogueList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dialogueList.SelectedIndex != -1)
            {
                selectedDialogueTextBox.Text = dialogueEntryList[dialogueList.SelectedIndex];
                DialogueNameTextBox.Text = dialogueNameList[dialogueList.SelectedIndex];
            }
            else
            {
                selectedDialogueTextBox.Text = null;
                DialogueNameTextBox.Text = null;


            }
        }
        

        private void ShiftDialogueUpButton_Click(object sender, EventArgs e)
        {
            int index = dialogueList.SelectedIndex;
            if (index != -1&& index!=0)
            {
                swap(dialogueList.SelectedIndex, dialogueList.SelectedIndex - 1);
                updateListBoxes();
                dialogueList.SelectedIndex = index - 1;

            }
        }

        private void ShiftDialogueDownButton_Click(object sender, EventArgs e)
        {

            int index = dialogueList.SelectedIndex;
            if (index != -1 && index < dialogueNameList.Count-1 )
            {
                swap(dialogueList.SelectedIndex, dialogueList.SelectedIndex + 1);
                updateListBoxes();
                dialogueList.SelectedIndex = index + 1;

            }
        }
        private void swap(int from, int to) {
            String temp;
            if(to>=0&&to<dialogueNameList.Count)
            {
                temp=dialogueNameList[to];
                dialogueNameList[to] = dialogueNameList[from];
                dialogueNameList[from] = temp;

                temp = dialogueEntryList[to];
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
                    dialogueNameList.RemoveAt(index);
                    if (index == dialogueEntryList.Count)
                        index = index - 1;
                    dialogueList.DataSource = null;
                    dialogueList.DataSource = dialogueNameList;
                    dialogueList.SelectedIndex = index;

                }
                catch { }
        }

        private void createNewDialogueButton_Click(object sender, EventArgs e)
        {
            if (selectedDialogueTextBox.Text != "" && selectedDialogueTextBox != null && DialogueNameTextBox.Text != "")
            {
                try
                {
                    int index = dialogueList.SelectedIndex;
                    if (index == -1)
                    {
                        dialogueNameList.Add(DialogueNameTextBox.Text);
                        dialogueEntryList.Add(selectedDialogueTextBox.Text);
                    }
                    else if (index >=0)
                    {
                        dialogueNameList [index] =DialogueNameTextBox.Text;
                        dialogueEntryList[index] = selectedDialogueTextBox.Text;
                    }
                    updateListBoxes();
                }
                catch { }
            }
        }
        private void updateListBoxes() {
            dialogueList.DataSource = null;
            dialogueList.DataSource = dialogueNameList;
            dialogueList.SelectedIndex = -1;

            pathListBoxTab2.DataSource = null;
            pathListBoxTab2.DataSource = dialogueNameList;
            pathListBoxTab2.SelectedIndex = -1;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (parentForm.navIndex.ContainsKey(name))
                parentForm.navIndex[name] = new Path(name, dialogueNameList, dialogueEntryList);
            else
                parentForm.navIndex.Add(name, new Path(name, dialogueNameList, dialogueEntryList));
            parentForm.updateListBoxes();
            Close();
        }
    }
    
}
