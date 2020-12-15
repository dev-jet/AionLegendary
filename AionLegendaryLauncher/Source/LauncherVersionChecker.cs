using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class LauncherVersionChecker
    {
        private static BackgroundWorker updateLaucnher = new BackgroundWorker();
        private static Stopwatch stopwatch = new Stopwatch();
        private static bool Update = false;
        public static void UpdateLauncher()
        {
            string up = Path.Combine(Properties.Settings.Default._Path, Globals.Updater).Replace(" ", String.Empty);
            if (File.Exists(up))
            {
                File.Delete(up);
            }
            updateLaucnher.DoWork += updateLaucnher_DoWork;
            updateLaucnher.RunWorkerCompleted += updateLaucnher_RunWorkerCompleted;

            if (updateLaucnher.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "CheckVersion isBusy"));
                Application.Exit();
            }
            else
            {
                updateLaucnher.RunWorkerAsync();
            }
        }
        private static void updateLaucnher_DoWork(object sender, DoWorkEventArgs e)
        {
            string file = Path.Combine(Globals.ServerURL, Globals.LauncherList);
            try
            {
                WebClient web = new WebClient();
                Stream st = web.OpenRead(file);
                StreamReader sr = new StreamReader(st);
                while (!sr.EndOfStream)
                {

                    string[] _File = sr.ReadLine().Trim().Split(':');
                    string Name = _File[0];
                    string Hash = _File[1];
                    long Size = Convert.ToInt64(_File[2]);
                    string fl = Path.Combine(Properties.Settings.Default._Path, Name).Replace(" ", String.Empty);
                    if (Name == Globals.Launcher && (Common.CalculateMD5(fl) != Hash || Common.CalculateFileSize(fl) != Size))
                    {
                        Update = true;
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
        private static void updateLaucnher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (Update)
                {
                    DownLoadUpdater();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private static void DownLoadUpdater()
        {
            WebClient web = new WebClient();
            web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(web_DownloadProgressChanged);

            web.DownloadFileCompleted += new AsyncCompletedEventHandler(web_DownloadFileCompleted);

            stopwatch.Start();
            string df = Path.Combine(Properties.Settings.Default._Path, Globals.Updater).Replace(" ", String.Empty);
            web.DownloadFileAsync(new Uri(Globals.ServerURL + Globals.Updater), df);
        }
        private static void web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Common.ChangeStatus("DOWNLOADFILE", Globals.Updater, Globals.ComputeDownloadSize(e.BytesReceived).ToString("0.00") + " MB ", Globals.ComputeDownloadSize(e.TotalBytesToReceive).ToString("0.00") + " MB");

            Common.UpdateCompleteProgress((e.BytesReceived * 100) / e.TotalBytesToReceive);
            Common.UpdateDownloadSpeed(Globals.ComputeDownloadSpeed(e.BytesReceived, stopwatch));
        }
        private static void web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            stopwatch.Reset();
            Common.ChangeStatus("DOWNLOADCOMPLETE");
            Common.UpdateDownloadSpeed(0);
            Common.UpdateCompleteProgress(100);
            try
            {
                string up = Path.Combine(Properties.Settings.Default._Path, Globals.Updater).Replace(" ", String.Empty);
                if (File.Exists(up))
                {
                    Process.Start(up);
                    Application.Exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }
    }
}
