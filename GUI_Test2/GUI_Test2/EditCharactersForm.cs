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
    public partial class EditCharactersForm : Form
    {
        private List<String> nameList;
        private ProjectHomeForm parentForm;

        public EditCharactersForm(ProjectHomeForm par)
        {
            InitializeComponent();
            parentForm = par;
            nameList = Characters.getKeys();

        }

        private void chooseImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //Devam Mehta
            //97163
            //http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
  	 	    of.ShowDialog();

            try
            {
                characterImage.Image = Image.FromStream(of.OpenFile());
            }
            catch (IndexOutOfRangeException ex) { 
           
            
            }

        }

        private void characterImage_Click(object sender, EventArgs e)
        {

        }

        private void createNewCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterNameBox.Text != "" && characterNameBox != null)
            {
                string input = characterNameBox.Text;

                //Add if/else to handle duplicate naming
                if (!nameList.Contains(input))
                {
                    nameList.Add(input);
                    Characters.Add(input, new NPC(input));
                    characterNameBox.Text = "";
                    updateList();
                }

                else
                {
                    MessageBox.Show("Name Already Exists.");
                }
            }
        }

        private void deleteSelectedCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                int index = characterList.SelectedIndex;
                string nameToRemove = nameList[index];

                nameList.RemoveAt(index);
                Characters.Remove(nameToRemove);

                updateList();
            }

        }

        private void updateList()
        {
            characterList.DataSource = null;
            characterList.DataSource = nameList;
            characterList.SelectedIndex = -1;
        }
    }
}
