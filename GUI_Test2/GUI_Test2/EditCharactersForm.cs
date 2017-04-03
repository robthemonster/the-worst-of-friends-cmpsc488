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
        private Dictionary<String, NPC> characters;
        private ProjectHomeForm parentForm;

        public EditCharactersForm(ProjectHomeForm par)
        {
            InitializeComponent();
            parentForm = par;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                nameList.Add(input);
                characters.Add(input, new NPC(input));
                characterNameBox.Text = "";
                //visual update
            }
        }

        private void updateList()
        {

        }
    }
}
