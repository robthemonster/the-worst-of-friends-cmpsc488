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
    public partial class EditMainMenuForm : Form
    {
        public string mainMenuImagePath;
        public string mainMenuSoundPath;
        public string playButtonSoundPath;
        public string fontImagePath;
        public bool mainMenuSoundLoading;
        public bool mainMenuSoundSelected;
        public bool playButtonSoundLoading;
        public bool playButtonSoundSelected;

        public EditMainMenuForm()
        {
            InitializeComponent();
            mainMenuImagePath = "";
            mainMenuSoundPath = "";
            playButtonSoundPath = "";
            fontImagePath = "";
            
        }

        public EditMainMenuForm(MainMenu mM)
        {
            InitializeComponent();
            mainMenuImagePath = mM.mainMenuImagePath;
            mainMenuSoundPath = mM.mainMenuSoundPath;
            playButtonSoundPath = mM.playButtonSoundPath;
            fontImagePath = mM.fontImagePath;
        }

        private void EditMainMenuForm_Load(object sender, EventArgs e)
        {
            mainMenuSoundSelected = false;
            mainMenuSoundLoading = false;
            playButtonSoundLoading = false;
            playButtonSoundSelected = false;

            mainMenuPictureBox.Image = Image.FromFile(mainMenuImagePath);
        }

        private void selectMainMenuImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            
            of.ShowDialog();
            try
            {
                mainMenuPictureBox.Image = Image.FromStream(of.OpenFile());
                mainMenuImagePath = of.FileName;
            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void useMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (useBackgroundSound.Checked)
            {
                if (!mainMenuSoundLoading)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Audio files (*.ogg) | *.ogg";

                    try
                    {
                        if (DialogResult.OK == of.ShowDialog())
                        {
                            mainMenuSoundPath = of.FileName;
                            mainMenuSoundSelected = true;
                        }
                        else
                        {
                            mainMenuSoundSelected = false;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                    }
                    if (!mainMenuSoundSelected)
                    {
                        mainMenuSoundLoading = true;
                        useBackgroundSound.Checked = false;
                        mainMenuSoundLoading = false;
                    }
                }
            }
            else
            {
                mainMenuSoundSelected = false;
            }
        }

        private void usePlayButtonSound_CheckedChanged(object sender, EventArgs e)
        {
            if (usePlayButtonSound.Checked)
            {
                if (!playButtonSoundLoading)
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.Filter = "Audio files (*.ogg) | *.ogg";

                    try
                    {
                        if (DialogResult.OK == of.ShowDialog())
                        {
                            playButtonSoundPath = of.FileName;
                            playButtonSoundSelected = true;
                        }
                        else
                        {
                            playButtonSoundSelected = false;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                    }
                    if (!playButtonSoundSelected)
                    {
                        playButtonSoundLoading = true;
                        usePlayButtonSound.Checked = false;
                        playButtonSoundLoading = false;
                    }
                }
            }
            else
            {
                playButtonSoundSelected = false;
            }
        }

        private void defaultFontButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Font files (*.otf, *.ttf) | *.otf; *.ttf;";

            try
            {
                if (DialogResult.OK == of.ShowDialog())
                {
                    fontImagePath = of.FileName;
                }

            }
            catch (IndexOutOfRangeException)
            {
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Game.gameSettings.mainMenu = new MainMenu(mainMenuImagePath, mainMenuSoundPath, playButtonSoundPath, fontImagePath);
            this.Close();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
