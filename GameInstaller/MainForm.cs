using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;
using NAudio;
using NAudio.Wave;

namespace GameInstaller
{
    public partial class MainForm : Form
    {
        List<string> apks = new List<string>();
        List<string> apksToInstall = new List<string>();

        string adbUrl = "https://dl.google.com/android/repository/platform-tools-latest-windows.zip";
        string adbDriverUrl = "http://epicserverlmao.ddns.net/Downloads/oculus-adb-driver-2.0.zip";

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(@"./apks"))
            {
                Directory.CreateDirectory(@"./apks");
            }
            apks = Directory.GetFiles(@".\apks", "*.apk").ToList();

            foreach (string apk in apks)
            {
                CheckboxList.Items.Add(apk);
            }
            InstallADB();
            InstallADBDriver();
        }

        async Task InstallADB()
        {
            if (!Directory.Exists(@"c:\adb"))
            {
                WebClient webClient = new WebClient();
                Uri downloadUri = new Uri(adbUrl, UriKind.Absolute);
                await webClient.DownloadFileTaskAsync(downloadUri, "adb.zip");

                string adbZIP = @".\adb.zip";

                ZipFile.ExtractToDirectory(adbZIP, @"c:\adb");
                File.Delete(adbZIP);
            }

            //if (!Environment.GetEnvironmentVariable("Path").Contains("platform-tools"))
            //{
            //    var name = "PATH";
            //    var scope = EnvironmentVariableTarget.Machine;
            //    var oldValue = Environment.GetEnvironmentVariable(name, scope);
            //    var newValue = oldValue + @";C:\adb\platform-tools\\";
            //    Environment.SetEnvironmentVariable(name, newValue, scope);
            //}
            //    Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("path") + @"C:\adb\platform-tools;", EnvironmentVariableTarget.User);


            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Environment", true);

            if (!key.GetValue("Path").ToString().Contains("platform-tools"))
            {
                string data = key.GetValue("Path").ToString();
                data += @"C:\adb\platform-tools\;";
                key.SetValue("Path", data);
            }

            key.Close();
            return;
        }

        async Task InstallADBDriver()
        {
            if (!Directory.Exists(@".\adbDriver"))
            {
                WebClient webClient = new WebClient();
                Uri downloadUri = new Uri(adbDriverUrl, UriKind.Absolute);
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                await webClient.DownloadFileTaskAsync(downloadUri, "adbDriver.zip");

                string adbDriverZIP = @".\adbDriver.zip";

                ZipFile.ExtractToDirectory(adbDriverZIP, @".\adbDriver");

                string driver = Path.GetFullPath(@".\adbDriver\oculus-go-adb-driver-2.0\usb_driver\android_winusb.inf");

                InstallDriver(driver);

                File.Delete(adbDriverZIP);

            }
            return;
        }


        private void InstallDriver(string path)
        {
            bool falsee = false;
            Devcon.Install(path, ref falsee);
        }

        private void InstallButton_Click(object sender, EventArgs e)
        {
            InstallSelectedGames();
        }

        async Task InstallSelectedGames()
        {
            apksToInstall.Clear();
            for (int i = 0; i < CheckboxList.Items.Count; i++){
                if (CheckboxList.GetItemChecked(i))
                {
                    apksToInstall.Add((string)CheckboxList.Items[i]);
                }
            }


            foreach(string apk in apksToInstall)
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.Arguments = @"/C adb install -r " + $"\"{apk}\"";
                cmd.Start();
                string apkName = apk.Substring(apk.LastIndexOf('\\') + 1);
                OutputTextBox.Text += $"Installing {apkName} \r\n";
                cmd.WaitForExit();
            }
                OutputTextBox.Text += $"Finished installing {apksToInstall.Count} apks " + System.Environment.NewLine;
        }

        private void Request_Button_Click(object sender, EventArgs e)
        {
            CheckForNewAPK();

            OutputTextBox.Text = "";
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Arguments = @"/C adb devices";
            cmd.Start();
            cmd.WaitForExit();

            string output = cmd.StandardOutput.ReadToEnd();
            OutputTextBox.Text += output;
        }

        private void MusicButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(@".\Resources\music.mp3"))
            {
                IWavePlayer waveOutDevice = new WaveOut();
                AudioFileReader audioFileReader = new AudioFileReader(@".\Resources\music.mp3");

                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
        }

        private void CheckForNewAPK()
        {
            List<string> newApks = new List<string>();
            newApks = Directory.GetFiles(@".\apks", "*.apk").ToList();

            for(int i = 0; i < newApks.Count; i++)
            {
                if(!apks.SequenceEqual(newApks))
                {
                    UpdateAPKS(newApks);
                }
            }
        }

        private void UpdateAPKS(List<string> newApks)
        {
            CheckboxList.Items.Clear();
            apksToInstall.Clear();
            apks = newApks;
            foreach (string apk in apks)
            {
                CheckboxList.Items.Add(apk);
            }
        }
    }
}
