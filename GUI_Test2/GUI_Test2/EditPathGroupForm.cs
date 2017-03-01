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
    public partial class EditPathGroupForm : Form
    {
        public EditPathGroupForm(String name)
        {
            InitializeComponent();
            this.Text = "Edit PathGroup: "+name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditPathGroupForm_Load(object sender, EventArgs e)
        {
            ListViewItem item1 = new ListViewItem("item1", 0);
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            pathsNotInPathGroupListBox.Items.AddRange(new ListViewItem[] { item1, item2 });
        }

        private void removeSelectedPathsFromPathGroup_Click(object sender, EventArgs e)
        {

        }

        private void pathsNotInPathGroupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
