using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace AionLegendaryLauncher.Source
{
    public class FileDownloader
    {
        private static int curFile;
        private static long lastBytes;
        private static long currentBytes;
        public static WebClient webClient;
        private static Stopwatch stopWatch = new Stopwatch();

        public static void DownloadFile()
        {
            if (Globals.OldFiles.Count <= 0)
            {
                Common.ChangeStatus("CHECKCOMPLETE");
                Common.UpdateCompleteProgress(100);
                Common.EnableStart();
                return;
            }

            if (curFile >= Globals.OldFiles.Count)
            {
                Common.ChangeStatus("DOWNLOADCOMPLETE");
                Common.UpdateDownloadSpeed(0);
                Common.UpdateCompleteProgress(100);
                Common.EnableStart();

                return;
            }
            string fl = Path.Combine(Properties.Settings.Default._Path, Path.GetDirectoryName(Globals.OldFiles[curFile])).Replace(" ", String.Empty);

            if (Globals.OldFiles[curFile].Contains("/"))
            {
                if (!Directory.Exists(fl))
                {
                    Directory.CreateDirectory(fl);
                }
            }

            webClient = new WebClient();

            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);

            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);

            stopWatch.Start();
            string df = Path.Combine(Properties.Settings.Default._Path, Globals.OldFiles[curFile]).Replace(" ", String.Empty);
            webClient.DownloadFileAsync(new Uri(Globals.ServerURL + Globals.OldFiles[curFile]), df);
        }

        private static void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            currentBytes = lastBytes + e.BytesReceived;

            Common.ChangeStatus("DOWNLOADFILE", Globals.OldFiles[curFile], Globals.ComputeDownloadSize(e.BytesReceived).ToString("0.00") + " MB ", Globals.ComputeDownloadSize(e.TotalBytesToReceive).ToString("0.00") + " MB");

            Common.UpdateCompleteProgress(Globals.Compute(Globals.completeSize + currentBytes));
            Common.UpdateDownloadSpeed(Globals.ComputeDownloadSpeed(e.BytesReceived, stopWatch));
        }

        private static void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lastBytes = currentBytes;
            curFile++;

            stopWatch.Reset();

            DownloadFile();
        }
    }
}
