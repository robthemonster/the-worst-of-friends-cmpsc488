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
            nameList = Game.characters.Keys.ToList();
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
                this.AcceptButton = addImageToCharacterButton;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.Out.WriteLine(ex.StackTrace);
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
                    Game.characters.Add(characterName, new NPC(characterName));
                    updateCharacterList();
                    characterList.SelectedIndex = Game.characters.Count - 1;


                }

                else
                {
                    characterList.SelectedIndex = nameList.IndexOf(characterName);
                }
                this.AcceptButton = chooseImageButton;
                this.ActiveControl = imageNameTextBox;
            }
        }

        private void deleteSelectedCharacterButton_Click(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                Game.characters.Remove(nameList[characterList.SelectedIndex]);
                updateCharacterList();
            }
        }

        private void updateCharacterList()
        {
            characterList.DataSource = null;
            characterList.DataSource = Game.characters.Keys.ToList();
        }

        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            if (characterImageList.SelectedIndex != -1 && characterList.SelectedIndex != -1)
            {
                Game.characters[characterList.Text].removeImage(characterImageList.SelectedIndex);
                if (characterImageList.SelectedIndex == Game.characters[characterList.Text].imageNames.Count)
                {
                    --characterImageList.SelectedIndex;
                }

                updateImageList();
            }
        }

        private void addImageToCharacterButton_Click(object sender, EventArgs e)
        {
            if (imageNameTextBox.Text != "" && characterList.SelectedIndex != -1 && !imagePath.Equals("") && !Game.characters[characterList.Text].imageNames.Contains(imageNameTextBox.Text))
            {
                string imageName = imageNameTextBox.Text;
                Game.characters[characterList.Text].addImage(imageNameTextBox.Text, imagePath);
                updateImageList();
                characterImageList.SelectedIndex = characterImageList.FindString(imageName);
                this.ActiveControl = imageNameTextBox;
            }
        }

        private void characterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterList.SelectedIndex != -1)
            {
                characterImageList.SelectedIndexChanged -= characterImageList_SelectedIndexChanged;
                characterImageList.DataSource = null;
                characterImageList.DataSource = Game.characters[characterList.Text].imageNames;
                characterImageList.ClearSelected();
                characterImageList.SelectedIndexChanged += characterImageList_SelectedIndexChanged;
                imageNameTextBox.Text = "";
                characterImage.Image = GUI_Test2.Properties.Resources.defaultCharacter;
            }
        }

        private void characterImageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characterImageList.SelectedIndex != -1 && characterList.SelectedIndex != -1)
            {
                imageNameTextBox.Text = characterImageList.Text;
                imagePath = Game.characters[characterList.Text].imagePaths[characterImageList.SelectedIndex];
                characterImage.ImageLocation = imagePath;
            }
            else
            {
                characterImage.Image = GUI_Test2.Properties.Resources.defaultCharacter;
                imageNameTextBox.Text = "";
            }
        }
        private void updateImageList()
        {
            int i = characterList.SelectedIndex;
            characterList.SelectedIndex = -1;
            if (i != -1)
                characterList.SelectedIndex = i;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCharactersForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = createNewCharacterButton;
            this.ActiveControl = characterNameBox;
        }

        private void characterNameBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = createNewCharacterButton;
        }

        private void imageNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = chooseImageButton;
        }
    }
}
