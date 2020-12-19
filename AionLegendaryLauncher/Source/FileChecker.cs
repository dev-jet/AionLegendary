using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class FileChecker
    {
        public static int count = 0;
        enum State
        {
            REPORT_NAME = 0,
            REPORT_PROGRESS = 1
        }

        private static BackgroundWorker FastCheckFile = new BackgroundWorker();
        private static BackgroundWorker FullCheckFile = new BackgroundWorker();

        public static void FullCheckFiles()
        {
            FullCheckFile.WorkerReportsProgress = true;

            FullCheckFile.DoWork += FullCheckFile_DoWork;
            FullCheckFile.ProgressChanged += FullCheckFile_ProgressChanged;
            FullCheckFile.RunWorkerCompleted += FullCheckFile_RunWorkerCompleted;

            if (FullCheckFile.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "FullCheckFiles isBusy"));
                Application.Exit();
            }
            else
            {
                FullCheckFile.RunWorkerAsync();
            }
        }
        private static void FullCheckFile_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (Globals.FileHash file in Globals.Files)
            {
                Globals.fullSize += file.Size;
                string fl = Path.Combine(Properties.Settings.Default._Path, file.Name).Replace(" ", String.Empty);
                FullCheckFile.ReportProgress((int)State.REPORT_NAME, Path.GetFileName(fl));
                if (!File.Exists(fl) || Common.CalculateMD5(fl) != file.Hash || Common.CalculateFileSize(fl) != file.Size)
                {
                    Globals.OldFiles.Add(file.Name);
                }
                else
                {
                    Globals.completeSize += file.Size;
                    FullCheckFile.ReportProgress((int)State.REPORT_PROGRESS);
                }

            }
        }
        private static void FullCheckFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == (int)State.REPORT_NAME)
            {
                Common.ChangeStatus("CHECKFILE", e.UserState.ToString());
            }
            else
            {
                count++;
                Common.UpdateCompleteProgress((count * 100) / Globals.Files.Count);
            }
        }
        private static void FullCheckFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileDownloader.DownloadFile();
        }
        public static void FastCheckFiles()
        {
            FastCheckFile.WorkerReportsProgress = true;

            FastCheckFile.DoWork += FastCheckFile_DoWork;
            FastCheckFile.ProgressChanged += FastCheckFile_ProgressChanged;
            FastCheckFile.RunWorkerCompleted += FastCheckFile_RunWorkerCompleted;

            if (FastCheckFile.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "FastCheckFiles isBusy"));
                Application.Exit();
            }
            else
            {
                FastCheckFile.RunWorkerAsync();
            }
        }
        private static void FastCheckFile_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (Globals.FileHash file in Globals.Files)
            {
                Globals.fullSize += file.Size;
                string fl = Path.Combine(Properties.Settings.Default._Path, file.Name).Replace(" ", String.Empty);
                FastCheckFile.ReportProgress((int)State.REPORT_NAME, Path.GetFileName(fl));
                if (!File.Exists(fl) || Common.CalculateFileSize(fl) != file.Size)
                {
                    Globals.OldFiles.Add(file.Name);
                }
                else
                {
                    Globals.completeSize += file.Size;
                    FastCheckFile.ReportProgress((int)State.REPORT_PROGRESS);
                }

            }
        }
        private static void FastCheckFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == (int)State.REPORT_NAME)
            {
                Common.ChangeStatus("CHECKFILE", e.UserState.ToString());
            }
            else
            {
                count++;
                Common.UpdateCompleteProgress((count * 100) / Globals.Files.Count);
            }
        }

        private static void FastCheckFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileDownloader.DownloadFile();
        }
    }
}
