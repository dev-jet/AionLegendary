using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class ListDownloader
    {
        public static void DownloadList()
        {

            Globals.Files.Clear();
            Globals.OldFiles.Clear();
            Globals.fullSize = 0;
            Globals.completeSize = 0;
            FileChecker.count = 0;
            BackgroundWorker backgroundWorker = new BackgroundWorker();

            Common.ChangeStatus("LISTDOWNLOAD");

            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "DownloadList isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient webClient = new WebClient();
            try
            {
                Stream stream = webClient.OpenRead(Globals.ServerURL + Globals.FullCheckList);
                StreamReader streamReader = new StreamReader(stream);

                while (!streamReader.EndOfStream)
                {
                    Globals.AddFile(streamReader.ReadLine());
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
            if (!Properties.Settings.Default._FullFileCheck)
            {
                FileChecker.FastCheckFiles();
            }
            else
            {
                FileChecker.FullCheckFiles();
            }
        }
    }
}
