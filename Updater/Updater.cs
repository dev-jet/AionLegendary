using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Updater
{
    public partial class Updater : Form
    {
        bool move = false;
        int moveX = 0;
        int moveY = 0;
        private static Stopwatch stopWatch = new Stopwatch();
        public static readonly string ServerURL = "http://185.207.38.51/AionLegendary/";
        public static readonly string Launcher = "AionLegendary.exe";
        public static long _Size = 0;
        public static Updater Main;
        private static string _base = AppDomain.CurrentDomain.BaseDirectory;
        public Updater()
        {
            InitializeComponent();
            Main = this;
        }

        private void Updater_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            moveX = e.X;
            moveY = e.Y;
        }

        private void Updater_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void Updater_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            Networking.CheckNetwork();
        }
        public static void DownLoadLauncher()
        {
            try
            {
                WebClient web = new WebClient();
                web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(web_DownloadProgressChanged);

                web.DownloadFileCompleted += new AsyncCompletedEventHandler(web_DownloadFileCompleted);

                stopWatch.Start();
                string df = Path.Combine(_base, Launcher).Replace(" ", String.Empty);
                web.DownloadFileAsync(new Uri(ServerURL + Launcher), df);
            }
            catch (WebException ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
        private static void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _Size = e.TotalBytesToReceive;
            Main.progressBar1.Value = Compute(e.BytesReceived);
            UpdateStatus(ComputeDownloadSpeed(e.BytesReceived, stopWatch));
        }
        private static void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            stopWatch.Reset();
            try
            {
                string file = Path.Combine(_base, Launcher).Replace(" ", String.Empty);
                if (File.Exists(file))
                {
                    Process.Start(file);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        public static int Compute(long Size)
        {
            return Convert.ToInt32(((Size * 100) / _Size));
        }

        public static double ComputeDownloadSize(double Size)
        {
            return (Size / 1024d / 1024d);
        }

        public static double ComputeDownloadSpeed(double Size, Stopwatch stopWatch)
        {
            return ((Size / 1024d / 1024d) / stopWatch.Elapsed.TotalSeconds);
        }

        public static void UpdateStatus(double Speed)
        {
            Main.labelStatus.Text = Speed.ToString("0.00") + "Mb/s";
        }

    }
}
