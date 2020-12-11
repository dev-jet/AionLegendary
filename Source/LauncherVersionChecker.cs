using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class LauncherVersionChecker
    {
        private static BackgroundWorker backgroundWorker = new BackgroundWorker();

        public static void CheckVersion()
        {
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "CheckVersion isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }
        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string file = Path.Combine(Globals.ServerURL, Globals.VersionList);
            try
            {
                WebClient web = new WebClient();
                Stream st = web.OpenRead(file);
                StreamReader sr = new StreamReader(st);
                while (!sr.EndOfStream)
                {
                    if (sr.ReadLine().Trim() != Globals.VersionKey)
                    {
                        if(MessageBox.Show(Texts.GetText("LAUNCHER_NEW_VERSION"), "Launcher Version", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("https://www.aionlegendary.com/Home/Download");
                            Application.Exit();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Exit();
            }
        }
        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListDownloader.DownloadList();
        }
    }
}
