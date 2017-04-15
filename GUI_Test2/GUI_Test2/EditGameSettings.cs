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
    public partial class EditGameSettings : Form
    {
        private int gameOverScope;
        private string currHub;
        private List<Requirement> gameOverReq;
        private string playSoundPath;
        private bool musicSelected;
        private bool musicLoading;
        private string defaultFontPath;
        private string SORPathGroupName;
        private string EORPathGroupName;

        public EditGameSettings()
        {
            InitializeComponent();

            gameOverReq = new List<Requirement>();
            playSoundPath = "";
            defaultFontPath = "";
            SORPathGroupName = "";
            EORPathGroupName = "";
        }

        public EditGameSettings(GameSettings gS)
        {
            InitializeComponent();

            gameOverReq = gS.gameOverRequirement;
            playSoundPath = gS.menuStartButtonSound;
            defaultFontPath = gS.defaultFontPath;
            SORPathGroupName = gS.startOfRoundNav;
            EORPathGroupName = gS.endOfRoundNav;
        }

        private void EditGameSettings_Load(object sender, EventArgs e)
        {
            gameOverScope = 0;
            currHub = "";
            musicSelected = false;
            musicLoading = false;

            playerAttributesBox.DataSource = Attributes.getScope(2, currHub);
            globalAttributesBox.DataSource = Attributes.getScope(0, currHub);
            comparitorComboBox.DataSource = new string[] { "<", "<=", "==", ">=", ">" };
            hubComboBox.DataSource = Game.hubs;

            //Causing them to select the same path
            roundStartNavBox.DataSource = Game.pathGroups;
            roundEndNavBox.DataSource = Game.pathGroups;
        }

        private void setAttributeComboBox()
        {
            attributeComboBox.DataSource = Attributes.getScope(gameOverScope, currHub);
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

        }

        private void GOGlobalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GOGlobalRadioButton.Enabled)
            {
                gameOverScope = 0;
                setAttributeComboBox();
            }
        }

        private void GOHubRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GOHubRadioButton.Checked)
            {
                gameOverScope = 1;
                hubLabel.Enabled = true;
                hubComboBox.Enabled = true;
                if (hubComboBox.SelectedIndex != -1)
                {
                    currHub = hubComboBox.SelectedItem.ToString();
                    setAttributeComboBox();
                }
                else
                {
                    attributeComboBox.DataSource = null;
                }
            }
            else
            {
                hubLabel.Enabled = false;
                hubComboBox.Enabled = false;
                currHub = "";
            }
        }

        private void GOPlayerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GOPlayerRadioButton.Enabled)
            {
                gameOverScope = 2;
                setAttributeComboBox();
            }
        }

        private void visiblePlayerAttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void visibleGlobalAttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GameOverReqsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addRequirementButton_Click(object sender, EventArgs e)
        {

        }

        private void removeRequirementButton_Click(object sender, EventArgs e)
        {

        }

        private void defaultFontButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Font files (*.otf, *.ttf) | *.otf; *.ttf;";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    defaultFontPath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void useMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (useMusic.Checked)
            {
                if (!musicLoading)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Audio files (*.ogg) | *.ogg";

                    try
                    {
                        if (DialogResult.OK == of.ShowDialog())
                        {
                            playSoundPath = of.FileName;
                            musicSelected = true;
                        }
                        else
                        {
                            musicSelected = false;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                    if (!musicSelected)
                    {
                        musicLoading = true;
                        useMusic.Checked = false;
                        musicLoading = false;
                    }
                }
            }
            else
            {
                musicSelected = false;
            }
        }

        private void hubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hubComboBox.SelectedIndex != -1)
            {
                GOPlayerRadioButton.Checked = true;
                GOHubRadioButton.Checked = true;
                attributeComboBox.DataSource = Attributes.getScope(1, currHub);
            }
        }

        private void chooseScrollSoundButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Audio files (*.ogg) | *.ogg";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    playSoundPath = of.FileName;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }

        }

        private void defaultDialoguePaneTextureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    defaultFontPath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException)
            {

            }
        }
    }
}
