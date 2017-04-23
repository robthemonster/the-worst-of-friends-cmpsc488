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
    public partial class DefineAttributeForm : Form
    {
        int scope; //0-global, 1-hub, 2-player
        List<String> dispScope;
        String currHub;
        bool scopeChange = false;
        const int GLOBAL = 0, HUB = 1, PLAYER = 2;


        public DefineAttributeForm()
        {
            InitializeComponent();
            dispScope = new List<string> { "Global", "Hub", "Player" };
            currHub = "";
            if (Game.hubs != null)
            {
                hubSelectionComboBox.DataSource = Game.hubs;
            }
            else
            {
                hubRadioButton.Enabled = false;
            }

        }

        private void DefineAttributeForm_Load(object sender, EventArgs e)
        {

            globalRadioButton.Checked = true;
        }

        private void globalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scope = DefineAttributeForm.GLOBAL;
            currHub = "";
            allHubCheckBox.Enabled = false;
            allHubCheckBox.Checked = false;
            hubSelectionComboBox.Enabled = false;
            scopeChange = true;
            updateScope();
        }

        private void hubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            allHubCheckBox.Enabled = true;
            hubSelectionComboBox.Enabled = true;
            if (hubSelectionComboBox.SelectedIndex >= 0)
            {
                currHub = (String)hubSelectionComboBox.SelectedItem;
            }
            scope = DefineAttributeForm.HUB;
            scopeChange = true;
            updateScope();

        }
        private void playerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            scope = DefineAttributeForm.PLAYER;
            allHubCheckBox.Enabled = false;
            allHubCheckBox.Checked = false;
            hubSelectionComboBox.Enabled = false;
            currHub = "";
            scopeChange = true;
            updateScope();
        }
        private void updateScope()
        {
            scopeTextBox.Text = dispScope[scope];

            scopeAttributesListBox.DataSource = null;
            scopeAttributesListBox.DataSource = Attributes.getScope(this.scope, this.currHub);
            scopeAttributesListBox.SelectedIndex = -1;
            scopeChange = false;


        }

        private void hubSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubSelectionComboBox.SelectedIndex != -1)
            {
                currHub = (String)hubSelectionComboBox.SelectedItem;
            }
            else
            {
                currHub = "";
            }
            updateScope();
            clearFields();
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addAttributeButton_Click(object sender, EventArgs e)
        {
            if (!nameTextBox.Text.Equals(""))
            {
                Attributes.Remove(nameTextBox.Text);

                if (allHubCheckBox.Enabled && !allHubCheckBox.Checked)
                {
                    Attributes.Add(scope, nameTextBox.Text, (int)initialValueNumericUpDown.Value, currHub);
                }
                else
                {
                    Attributes.Add(scope, nameTextBox.Text, (int)initialValueNumericUpDown.Value);
                }
            }
            updateScope();
            clearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (scopeAttributesListBox.SelectedIndex != -1)
            {
                if (Attributes.Remove(nameTextBox.Text))
                {
                    updateScope();
                    clearFields();
                }
                updateScope();
            }
        }

        private void clearFields()
        {
            nameTextBox.Text = "";
            initialValueNumericUpDown.Value = 0;
            allHubCheckBox.Checked = false;
        }

        private void scopeAttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (scopeAttributesListBox.SelectedIndex != -1 && !scopeChange)
            {
                Attrib a = Attributes.get((string)scopeAttributesListBox.SelectedItem);
                nameTextBox.Text = a.name;
                initialValueNumericUpDown.Value = a.value;
            }
        }
    }
}
