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
    public partial class CreatePathGroupForm : Form
    {
        public ProjectHomeForm parent;
        public CreatePathGroupForm(ProjectHomeForm sender)
        {
            InitializeComponent();
            AcceptButton = OKbutton;
            parent = sender;
        }

        private void pathGroupNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {

            if (pathGroupNameTextBox.Text == "")
            {

                MessageBox.Show("You Must Enter A Name For The PathGroup.");
            }
            else
            {
                parent.pathGroupName = pathGroupNameTextBox.Text;

                Close();
            }
        }

        private void CreatePathGroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
