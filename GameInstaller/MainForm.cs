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

namespace GameInstaller
{
    public partial class MainForm : Form
    {
        List<string> apks = new List<string>();

        string adbUrl = "https://dl.google.com/android/repository/platform-tools-latest-windows.zip";
        string adbDriverUrl = "http://epicserverlmao.ddns.net/Downloads/oculus-adb-driver-2.0.zip";

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists(@"./apks"))
            {
                Directory.CreateDirectory("@./apks");
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
            }



            return;
        }

        async Task InstallADBDriver()
        {
            if (!Directory.Exists(@".\adbDriver"))
            {
                WebClient webClient = new WebClient();
                Uri downloadUri = new Uri(adbDriverUrl, UriKind.Absolute);
                await webClient.DownloadFileTaskAsync(downloadUri, "adbDriver.zip");

                string adbZIP = @".\adbDriver.zip";

                ZipFile.ExtractToDirectory(adbZIP, @".\adbDriver");

                string driver = Path.GetFullPath(@".\adbDriver\oculus-go-adb-driver-2.0\usb_driver\android_winusb.inf");

                InstallDriver(driver);

            }
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
            List<string> apksToInstall = new List<string>();
            for(int i = 0; i < CheckboxList.Items.Count; i++){
                if (CheckboxList.GetItemChecked(i))
                {
                    apksToInstall.Add(CheckboxList.GetItemText(i));
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
                cmd.StartInfo.Arguments = @"/C adb install " + apk;
                cmd.Start();

                cmd.WaitForExit();
                string output = cmd.StandardOutput.ReadToEnd();
                string apkName = apk.Substring(apk.LastIndexOf('\\') + 1);
                //OutputTextBox.Text += $"Installing {apkName}";
                OutputTextBox.Text += apk;
                OutputTextBox.Text += output;
            }
        }
    }
}
