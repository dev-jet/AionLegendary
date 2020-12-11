
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class Globals
    {
        public static string ServerURL = "http://185.207.38.51/AionLegendary/";
        public static string iframeLink = "http://185.207.38.51/";
        public static string FullCheckList = "FullCheckList.txt";
        public static string VersionList = "Version.txt";
        public static string VersionKey = "e4c2e8edac362acab7123654b9e73432";
        public static string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        private static bool IsStarting = false;
        public static Main mainForm;

        public static List<FileHash> Files = new List<FileHash>();
        public static List<string> OldFiles = new List<string>();

        public static long fullSize { get; set; }
        public static long completeSize { get; set; }

        public struct FileHash
        {
            public string Name;
            public string Hash;
            public long Size;
        }
        public static void AddFile(string File)
        {
            string[] _File = File.Trim().Split(':');
            if (_File.Length == 3)
            {
                FileHash file = new FileHash();
                file.Name = _File[0];
                file.Hash = _File[1];
                file.Size = Convert.ToInt64(_File[2]);

                Files.Add(file);
            }
            else
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "FileInfo.txt cannot be read"));
                Application.Exit();
            }
            
        }
        public static long Compute(long Size)
        {
            return ((Size * 100) / fullSize);
        }

        public static double ComputeDownloadSize(double Size)
        {
            return (Size / 1024d / 1024d);
        }

        public static double ComputeDownloadSpeed(double Size, Stopwatch stopWatch)
        {
            return ((Size / 1024d / 1024d) / stopWatch.Elapsed.TotalSeconds);
        }
        private static string FileName()
        {
            string file = @"bin32\\aion_x86_en.exe";
            switch (Properties.Settings.Default._GameType)
            {
                case 32:
                    switch (Properties.Settings.Default._GameLang)
                    {
                        case "eng":
                            file = @"bin32\\aion_x86_en.exe";
                            break;
                        case "trk":
                            file = @"bin32\\aion_x86_tr.exe";
                            break;
                        default:
                            file = @"bin32\\aion_x86_en.exe";
                            break;
                    }
                    break;
                case 64:
                    switch (Properties.Settings.Default._GameLang)
                    {
                        case "eng":
                            file = @"bin64\\aion_x64_en.exe";
                            break;
                        case "trk":
                            file = @"bin64\\aion_x64_tr.exe";
                            break;
                        default:
                            file = @"bin64\\aion_x64_en.exe";
                            break;
                    }
                    break;
            }
            return file;
        }
        public static void PlayAion()
        {
            try
            {
                if (IsStarting)
                {
                    return;
                }
                IsStarting = true;
                mainForm.LockedButtons();
                string file_name = Path.Combine(Properties.Settings.Default._Path, FileName());
                if (File.Exists(file_name))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.Arguments = "/C start " + file_name;
                    startInfo.WorkingDirectory = Properties.Settings.Default._Path;
                    using (Process exeProcess = Process.Start(startInfo))
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show(Texts.GetText("MISSINGBINARY", file_name));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", e.ToString()));
            }
            finally
            {
                mainForm.UnLockedButtons();
                IsStarting = false;
            }
        }
    }
}
