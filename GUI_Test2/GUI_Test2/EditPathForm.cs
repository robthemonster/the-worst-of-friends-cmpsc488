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
        public EditPathForm()
        {
            InitializeComponent();
        }

        private void EditPath_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
