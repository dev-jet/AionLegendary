using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class Networking
    {
        public static void CheckNetwork()
        {
            Common.ChangeStatus("CONNECTING");

            BackgroundWorker backgroundWorker = new BackgroundWorker();

            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "CheckNetwork isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                client.OpenRead(Globals.ServerURL);

                e.Result = true;
            }
            catch
            {
                e.Result = false;
            }
        }

        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!Convert.ToBoolean(e.Result))
            {
                MessageBox.Show(Texts.GetText("NONETWORK"));
                Application.Exit();
            }
            else
            {
                ListDownloader.DownloadList();
            }
        }
    }
}
