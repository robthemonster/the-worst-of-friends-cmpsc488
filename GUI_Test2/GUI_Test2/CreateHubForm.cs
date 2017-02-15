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
        public CreateHubForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            EditHubForm editHub = new EditHubForm();
            Close();
            editHub.ShowDialog();
        }
    }
}
