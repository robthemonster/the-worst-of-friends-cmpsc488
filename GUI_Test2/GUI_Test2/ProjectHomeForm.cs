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
    public partial class ProjectHomeForm : Form
    {
        public ProjectHomeForm()
        {
            
            InitializeComponent();
        }

        private void ProjectHub_Load(object sender, EventArgs e)
        {
            
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.ShowDialog();
        }

        private void CreateNewPathButton_Click(object sender, EventArgs e)
        {
            CreatePathForm dialog = new CreatePathForm();
            dialog.ShowDialog();

        }

        private void charactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCharactersForm ec = new EditCharactersForm();
            ec.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePathForm dialog = new CreatePathForm();
            dialog.ShowDialog();
        }

        private void pathGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPathGroupForm editPathGroup = new EditPathGroupForm();
            editPathGroup.ShowDialog();
        }

        private void hubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateHubForm createHub = new CreateHubForm();
            createHub.ShowDialog();

        }
    }
}
