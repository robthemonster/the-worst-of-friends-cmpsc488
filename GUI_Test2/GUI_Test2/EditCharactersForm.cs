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
        private string imagePath;

        public EditCharactersForm(ProjectHomeForm par)
        {
            InitializeComponent();
            parentForm = par;
            imagePath = "";
            nameList = Characters.getKeys();
            updateCharacterList();
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
                imagePath = of.FileName;
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
                string characterName = characterNameBox.Text;

                if (!nameList.Contains(characterName))
                {
                    nameList.Add(characterName);
                    new NPC(characterName);
                    updateCharacterList();
                    characterList.SelectedIndex = Characters.characters.Count - 1;
                }

                else
                {
                    characterList.SelectedIndex = nameList.IndexOf(characterName);
                }
            }
        }

        private void deleteSelectedCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                Characters.Remove(nameList[characterList.SelectedIndex]);
                updateCharacterList();
            }
        }

        private void updateCharacterList()
        {
            characterList.DataSource = null;
            characterList.DataSource = Characters.characters.Keys.ToList();
        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            if (characterImageList.SelectedIndex != -1 && characterList.SelectedIndex!=-1)
            {
                Characters.characters[(string)characterList.SelectedValue].removeImage(characterImageList.SelectedIndex);
                if (characterImageList.SelectedIndex == Characters.characters[characterList.Text].imageNames.Count)
                {
                    --characterImageList.SelectedIndex;
                }

                updateImageList();
            }
        }

        private void addImageToCharacterButton_Click(object sender, EventArgs e)
        {
            if (imageNameTextBox.Text != "" && !imagePath.Equals("")&& !Characters.characters[characterList.Text].imageNames.Contains(imageNameTextBox.Text)&&characterList.SelectedIndex!=-1)
            {
                Characters.characters[characterList.Text].addImage(imageNameTextBox.Text, imagePath);
                updateImageList();
            }
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                characterImageList.DataSource = null;
                characterImageList.DataSource = Characters.characters[characterList.Text].imageNames;
            }
        }

        private void characterImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterImageList.SelectedIndex != -1 && characterList.SelectedIndex != -1)
            {
                imageNameTextBox.Text = characterImageList.Text;
                imagePath = Characters.characters[characterList.Text].imagePaths[characterImageList.SelectedIndex];
                characterImage.ImageLocation = imagePath;
            }
            else {
                characterImage.Image = GUI_Test2.Properties.Resources.character;
            }
        }
        private void updateImageList()
        {
            int i = characterList.SelectedIndex;
            characterList.SelectedIndex = -1;
            characterList.SelectedIndex = i;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
