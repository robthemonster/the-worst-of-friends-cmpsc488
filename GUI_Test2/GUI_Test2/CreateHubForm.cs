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
    public partial class CreateHubForm : Form
    {
        public ProjectHomeForm parent;
        public CreateHubForm(ProjectHomeForm sender)
        {
            InitializeComponent();
            this.AcceptButton = OKButton;
            parent = sender;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (hubNameTextBox.Text == "") {
                MessageBox.Show("You Must Enter A Name For The Hub");
            }
            else
            {
                parent.navigableName = hubNameTextBox.Text;
                Close();
            }
        }

        private void hubNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
