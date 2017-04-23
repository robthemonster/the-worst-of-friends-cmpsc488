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
    public partial class CreateNavigableForm : Form
    {
        public ProjectHomeForm parent;
        public bool validClose = false;
        public string navigableName = "";
        public CreateNavigableForm(ProjectHomeForm sender)
        {
            InitializeComponent();
            AcceptButton = OKbutton;
            parent = sender;

            switch (parent.screenID)
            {
                case 1:
                    label1.Text = "Path Name:";
                    break;

                case 2:
                    label1.Text = "Path Group Name:";
                    break;

                case 3:
                    label1.Text = "Hub Name:";
                    break;
            }
        }

        private void navigableNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (navigableNameTextBox.Text.Contains("!") || navigableNameTextBox.Text.Contains("@")
                || navigableNameTextBox.Text.Contains("#") || navigableNameTextBox.Text.Contains("$")
                || navigableNameTextBox.Text.Contains("%") || navigableNameTextBox.Text.Contains("^")
                || navigableNameTextBox.Text.Contains("&") || navigableNameTextBox.Text.Contains("*")
                || navigableNameTextBox.Text.Contains("(") || navigableNameTextBox.Text.Contains(")")
                || navigableNameTextBox.Text.Contains("_") || navigableNameTextBox.Text.Contains("+")
                || navigableNameTextBox.Text.Contains("="))
            {
                MessageBox.Show("You May Not Use Characters '!', '@', '#', '$', '%', '^', '&', '*',\n '(', ')', '_', '+', or '='.");
            }

            else if (Game.navIndex.ContainsKey(navigableNameTextBox.Text))
            {
                MessageBox.Show("Name Already Exists.");
            }

            else
            {
                switch (parent.screenID)
                {
                    case 1:
                        if (navigableNameTextBox.Text == "")
                        {
                            MessageBox.Show("You Must Enter A Name For The Path.");
                        }

                        else
                        {
                            navigableName = navigableNameTextBox.Text;

                            validClose = true;
                            Close();
                        }
                        break;

                    case 2:
                        if (navigableNameTextBox.Text == "")
                        {
                            MessageBox.Show("You Must Enter A Name For The PathGroup.");
                        }

                        else
                        {

                            navigableName = navigableNameTextBox.Text;

                            validClose = true;
                            Close();
                        }
                        break;

                    case 3:
                        if (navigableNameTextBox.Text == "")
                        {
                            MessageBox.Show("You Must Enter A Name For The Hub");
                        }

                        else
                        {
                            navigableName = navigableNameTextBox.Text;

                            validClose = true;
                            Close();
                        }
                        break;
                }
            }


        }

        private void CreateNavigableForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateNavigableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!validClose)
            {
                parent.screenID = 0;
            }
        }
    }
}
