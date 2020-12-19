using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Lister
{
    public partial class Lister : Form
    {
        string[] Files;
        string path = String.Empty;
        string launcher = String.Empty;
        public static Stopwatch stopwatch = new Stopwatch();
        public Lister()
        {
            InitializeComponent();
        }

        private void DisableButtons()
        {
            progressBar.Value = 0;
            txtResult.Clear();
            btn_Browse.Enabled = false;
        }

        private void EnableButtons()
        {
            btn_Browse.Enabled = true;
        }
        private void btn_Browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                DisableButtons();
                labelFilePath.Text = folderBrowserDialog.SelectedPath.Replace(@"\", "/");
                path = folderBrowserDialog.SelectedPath.Replace(@"\", "/") + "/";
                stopwatch.Start();
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync(folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Files = GetFiles(e.Argument);

            for (int i = 0; i < Files.Length; i++)
            {
                backgroundWorker.ReportProgress(i + 1, GetFileData(Files[i]));
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateResult(e.UserState);

            UpdateProgressBar(ComputeProgress(e.ProgressPercentage));
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableButtons();
            Debug.WriteLine("Total ms :" + stopwatch.ElapsedMilliseconds);
            stopwatch.Stop();
            SaveList();
        }

        public string[] GetFiles(object Path)
        {
            return Directory.GetFiles(Path.ToString(), "*.*", System.IO.SearchOption.AllDirectories);
        }

        public int GetFilesCount(string[] Files)
        {
            return Files.Length;
        }

        public string GetFileData(string File)
        {
            FileInfo fileInfo = new FileInfo(File);

            return File + ":" + generateHashMD5(File) + ":" + fileInfo.Length;
        }

        private string generateHashMD5(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                using (var bufferedStream = new BufferedStream(stream, 1024 * 32))
                {
                    var sha = new MD5CryptoServiceProvider();
                    byte[] checksum = sha.ComputeHash(bufferedStream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }
            }
        }

        private void UpdateResult(object Data)
        {
            if (!txtResult.IsDisposed)
            {
                string str = Data.ToString().Replace(@"\", "/");
                string str2 = str.Replace(this.path, String.Empty);
                string[] files = str2.Split(':');
                string f = files[0];
                if (f == "AionLegendary.exe")
                {
                    launcher = str2;
                }
                else
                {
                    txtResult.AppendText(str2 + Environment.NewLine);
                }
            }
        }

        private int ComputeProgress(int Percent)
        {
            return (100 * Percent) / Files.Length;
        }

        private void UpdateProgressBar(int Percent)
        {
            if (Percent < 0 || Percent > 100)
                return;

            if (!progressBar.IsDisposed)
            {
                progressBar.Value = Percent;
            }
        }

        private void SaveList()
        {
            using (StreamWriter streamWriter = new StreamWriter("FullCheckList.txt"))
            {
                streamWriter.Write(txtResult.Text);
            }
            using (StreamWriter streamWriter = new StreamWriter("Launcher.txt"))
            {
                streamWriter.Write(launcher);
            }
        }
    }
}
