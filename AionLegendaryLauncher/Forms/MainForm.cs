using AionLegendaryLauncher.Forms;
using AionLegendaryLauncher.Source;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace AionLegendaryLauncher
{
    public partial class Main : Form
    {
        bool move = false;
        int moveX = 0;
        int moveY = 0;
        public bool IsOpenSetting = false;
        public bool update = false;
        ToolTip toolTip1 = new ToolTip();
        public Main()
        {
            InitializeComponent();
            Globals.mainForm = this;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default._UILang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default._UILang);
            webBrowser1.Navigate(Globals.iframeLink);
            LoadToolTip();
            LauncherVersionChecker.UpdateLauncher();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            moveX = e.X;
            moveY = e.Y;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Status.Text = Texts.GetText("UPDATE_CANCELING");
            this.CancelUpdate();
            this.Close();
        }

        private void CancelUpdate()
        {
            if (FileDownloader.webClient != null)
            {
                FileDownloader.webClient.CancelAsync();
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            if (!update)
            {
                LockedButtons();
                Networking.CheckNetwork();
            }
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            if (!IsOpenSetting)
            {
                LauncherSettings st = new LauncherSettings();
                st.Show();
                IsOpenSetting = true;
                this.Enabled = false;

            }
        }

        public void ChangeLang(string uilang)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(uilang);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(uilang);
            LoadToolTip();
        }

        private void btn_Website_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://www.aionlegendary.com/");
            Process.Start(sInfo);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.aionlegendary.com/Account/Register");
            Process.Start(sInfo);
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.aionlegendary.com/Shop/Index");
            Process.Start(sInfo);
        }

        private void btn_Discord_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://discord.gg/NfxtFEk");
            Process.Start(sInfo);
        }

        private void btn_Youtube_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.youtube.com/channel/UCdj4KqaSZBhgk_4t7L8u3zw/");
            Process.Start(sInfo);
        }

        private void btn_Instagram_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.instagram.com/aion.legendary/");
            Process.Start(sInfo);
        }

        private void btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://aionlegendary.com/Account/ForgotPassword");
            Process.Start(sInfo);
        }

        private void btn_Facebook_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/Aion-Legendary-112634247265085/");
            Process.Start(sInfo);
        }
        private void LoadToolTip()
        {
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 200;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btn_Discord, "https://discord.gg/NfxtFEk");
            toolTip1.SetToolTip(this.btn_Youtube, "https://www.youtube.com/channel/UCdj4KqaSZBhgk_4t7L8u3zw/");
            toolTip1.SetToolTip(this.btn_Instagram, "https://www.instagram.com/aion.legendary/");
            toolTip1.SetToolTip(this.btn_Facebook, "https://www.facebook.com/Aion-Legendary-112634247265085/");
            toolTip1.SetToolTip(this.btn_Website, "http://www.aionlegendary.com");
            toolTip1.SetToolTip(this.btn_Register, "https://www.aionlegendary.com/Account/Register");
            toolTip1.SetToolTip(this.btn_ForgotPassword, "https://aionlegendary.com/Account/ForgotPassword");
            toolTip1.SetToolTip(this.btn_Shop, "https://www.aionlegendary.com/Shop/Index");
            toolTip1.SetToolTip(this.btn_Play, Texts.GetText("BTN_PLAY"));
            toolTip1.SetToolTip(this.btn_Settings, Texts.GetText("BTN_SETTINGS"));
            toolTip1.SetToolTip(this.btn_Exit, Texts.GetText("BTN_CLOSE"));
            toolTip1.SetToolTip(this.btn_Minimize, Texts.GetText("BTN_MINIMIZE"));
        }

        public void LockedButtons()
        {
            this.update = true;
            this.btn_Play.Enabled = false;
            this.btn_Settings.Enabled = false;
        }
        public void UnLockedButtons()
        {
            this.update = false;
            this.btn_Play.Enabled = true;
            this.btn_Settings.Enabled = true;
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default._IsFirst && !IsOpenSetting)
            {
                LauncherSettings settings = new LauncherSettings();
                settings.Show();
                IsOpenSetting = true;
                this.Enabled = false;
            }
        }
    }
}
