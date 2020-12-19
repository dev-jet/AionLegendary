using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AionLegendaryLauncher.Source
{
    public class Common
    {
        public static void ChangeStatus(string Key, params string[] Arguments)
        {
            if (!Globals.mainForm.Status.Visible)
            {
                Globals.mainForm.Status.Visible = true;
            }
            Globals.mainForm.Status.Text = Texts.GetText(Key, Arguments);
        }

        public static void UpdateCompleteProgress(long Value)
        {
            if (Value < 0 || Value > 100)
            {
                return;
            }
            Globals.mainForm.progressBar.Value = Convert.ToInt32(Value);
            Globals.mainForm.progressBar.Text = Texts.GetText("COMPLETEPROGRESS", Value);
        }

        public static void UpdateDownloadSpeed(double Speed)
        {
            if (!Globals.mainForm.downloadSpeedText.Visible)
            {
                Globals.mainForm.downloadSpeedText.Visible = true;
            }
            Globals.mainForm.downloadSpeedText.Text = Texts.GetText("DOWNLOADSPEED", Speed.ToString("0.00"));
        }
        public static string CalculateMD5(string file)
        {
            using (FileStream stream = File.OpenRead(file))
            {
                using (var bufferedStream = new BufferedStream(stream, 1024 * 32))
                {
                    var sha = new MD5CryptoServiceProvider();
                    byte[] checksum = sha.ComputeHash(bufferedStream);
                    return BitConverter.ToString(checksum).Replace("-", String.Empty);
                }
            }
        }
        public static string CalculateMD5Hash(string Name)
        {
            if (Name == string.Empty)
                return null;

            MD5 md5 = MD5.Create();

            string Hash = string.Empty;

            try
            {
                using (FileStream fileStream = File.Open(Name, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    foreach (byte b in md5.ComputeHash(fileStream))
                    {
                        Hash += b.ToString("x2").ToLower();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cannot open file : " + Name);
            }

            return Hash;
        }
        public static long CalculateFileSize(string name)
        {
            if (name == String.Empty)
            {
                return 0;
            }
            try
            {
                using (FileStream file = File.Open(name, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return file.Length;
                }
            }
            catch (FileLoadException e)
            {
                MessageBox.Show(e.ToString());
            }
            return 0;
        }
        public static void EnableStart()
        {
            Globals.PlayAion();
        }
    }
}
