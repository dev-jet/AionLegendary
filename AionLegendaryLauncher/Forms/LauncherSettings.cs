using AionLegendaryLauncher.Source;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Forms
{
    public partial class LauncherSettings : Form
    {
        bool move = false;
        int moveX = 0;
        int moveY = 0;
        public static string path = Properties.Settings.Default._Path.Replace(" ", String.Empty);
        private static int gametype = Properties.Settings.Default._GameType;
        private static string gamelang = Properties.Settings.Default._GameLang;
        private static string uilang = Properties.Settings.Default._UILang;
        private static bool fullfilecheck = Properties.Settings.Default._FullFileCheck;
        public LauncherSettings()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LauncherSettings_MouseDown(object sender, MouseEventArgs e)
        {
            this.move = true;
            this.moveX = e.X;
            this.moveY = e.Y;
        }

        private void LauncherSettings_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void LauncherSettings_MouseUp(object sender, MouseEventArgs e)
        {
            this.move = false;
        }

        private void LauncherSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Globals.mainForm.IsOpenSetting = false;
            Globals.mainForm.Enabled = true;
        }
        private void btn_SetPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    labelGamePathShow.Text = fbd.SelectedPath;
                }
            }
        }
        public static void SettingsLoad()
        {
            path = Properties.Settings.Default._Path.Replace(" ", String.Empty);
            gametype = Properties.Settings.Default._GameType;
            gamelang = Properties.Settings.Default._GameLang;
            uilang = Properties.Settings.Default._UILang;
        }
        private void LauncherSettings_Load(object sender, EventArgs e)
        {
            SettingsLoad();
            labelGamePathShow.Text = Properties.Settings.Default._Path.Replace(" ", String.Empty);
            radioButton32.Checked = Properties.Settings.Default._GameType == 32 ? true : false;
            radioButton64.Checked = Properties.Settings.Default._GameType == 64 ? true : false;
            radioButtonTRK.Checked = Properties.Settings.Default._GameLang == "trk" ? true : false;
            radioButtonENG.Checked = Properties.Settings.Default._GameLang == "eng" ? true : false;
            radioButtonUILangEN.Checked = Properties.Settings.Default._UILang == "en" ? true : false;
            radioButtonUILangTR.Checked = Properties.Settings.Default._UILang == "tr" ? true : false;
            fullCheck.Checked = Properties.Settings.Default._FullFileCheck;

            labelGameLang.Text = Texts.GetText("GAME_LANG");
            labelGamePath.Text = Texts.GetText("FILE_PATH");
            labelGameType.Text = Texts.GetText("GAME_TYPE");
            labelUILang.Text = Texts.GetText("UI_LANG");
            labelSettings.Text = Texts.GetText("SETTINGS");
            fullCheck.Text = Texts.GetText("FULL_FILE_CHECK");

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 200;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btn_Cancel, Texts.GetText("BTN_CANCEL"));
            toolTip1.SetToolTip(this.btn_Close, Texts.GetText("BTN_CLOSE"));
            toolTip1.SetToolTip(this.btn_Save, Texts.GetText("BTN_SAVE"));
            toolTip1.SetToolTip(this.btn_SetPath, Texts.GetText("BTN_PATH"));
        }

        private void radioButtonENG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonENG.Checked)
            {
                gamelang = "eng";
            }
        }

        private void radioButtonTRK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTRK.Checked)
            {
                gamelang = "trk";
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton32.Checked)
            {
                gametype = 32;
            }
        }

        private void radioButton64_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton64.Checked)
            {
                gametype = 64;
            }
        }

        private void radioButtonUILangEN_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUILangEN.Checked)
            {
                uilang = "en";
            }
        }

        private void radioButtonUILangTR_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUILangTR.Checked)
            {
                uilang = "tr";
            }
        }
        private void fullCheck_CheckedChanged(object sender, EventArgs e)
        {
            fullfilecheck = fullCheck.Checked;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(uilang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(uilang);
            Globals.mainForm.ChangeLang(uilang);
            Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static void SaveSettings()
        {
            Properties.Settings.Default._Path = path.Replace(" ", String.Empty);
            Properties.Settings.Default._GameType = gametype;
            Properties.Settings.Default._GameLang = gamelang;
            Properties.Settings.Default._UILang = uilang;
            Properties.Settings.Default._FullFileCheck = fullfilecheck;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default._IsFirst)
            {
                Properties.Settings.Default._IsFirst = false;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

    }
}
