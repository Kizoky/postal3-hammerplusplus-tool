using System.Diagnostics;
using System.Media;
using System.Net;

namespace HPPDirectoryLinker
{
    public partial class HPPDirectoryLinker : Form
    {
        FixPostalFGD FGDWindow = new();
        public HPPDirectoryLinker()
        {
            InitializeComponent();

            // These should be on by default
            resourceFolders.SetItemChecked(0, true);
            resourceFolders.SetItemChecked(1, true);
            //resourceFolders.SetItemChecked(2, true);
        }

        private void SDKbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new()
            {
                ShowNewFolderButton = true
            };

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool ValidSDK = false;
                foreach (string dir in Directory.GetDirectories(folderDlg.SelectedPath, "sourcetest"))
                {
                    ValidSDK = true;
                }

                if (!ValidSDK)
                {
                    string msg = "Not a valid path to Source SDK 2013 installation.";
                    string caption = "Invalid Path";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SDKpathBox.Text = folderDlg.SelectedPath;
                POSTAL3button.Enabled = true;
            }
        }

        private void POSTAL3button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new()
            {
                ShowNewFolderButton = true
            };

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool ValidP3 = false;
                foreach (string dir in Directory.GetDirectories(folderDlg.SelectedPath, "p3"))
                {
                    ValidP3 = true;
                }

                foreach (string dir in Directory.GetDirectories(folderDlg.SelectedPath, "cr_base"))
                {
                    ValidP3 = true;
                }

                if (!ValidP3)
                {
                    string msg = "Not a valid path to Postal III installation.";
                    string caption = "Invalid Path";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                P3pathBox.Text = folderDlg.SelectedPath;
                FillGameFolderBox();
                LINKbutton.Enabled = true;
                gameFolders.Enabled = true;
                resourceFolders.Enabled = true;
            }
        }
        void FillGameFolderBox()
        {
            foreach (string dir in Directory.GetDirectories(P3pathBox.Text))
            {
                string nopath = dir.Replace(P3pathBox.Text, "");
                nopath = nopath.Replace("\\", "");

                // Exclude some unneeded folders
                if (nopath != "bin" &&
                    nopath != "config" &&
                    nopath != "platform" &&
                    nopath != "sdktools" &&
                    nopath != "sourcetest" &&
                    nopath != ".git"
                   )
                {
                    gameFolders.Items.Add(nopath);
                }
            }
        }
        string GatherConsoleCommands()
        {
            string commands = "";

            string cmdstart = "mklink /j \"";
            string quote = "\"";

            for (int i = 0; i < gameFolders.Items.Count; i++)
            {
                for (int j = 0; j < resourceFolders.Items.Count; j++)
                {
                    if (gameFolders.GetItemChecked(i) && resourceFolders.GetItemChecked(j))
                    {
                        // SDK
                        commands += String.Format($"{cmdstart}{SDKpathBox.Text}\\sourcetest\\custom\\{gameFolders.Items[i]}\\{resourceFolders.Items[j]}\\{quote} ");

                        // P3
                        commands += String.Format($"{quote}{P3pathBox.Text}\\{gameFolders.Items[i]}\\{resourceFolders.Items[j]}\\{quote}\n");
                    }
                }
            }

            return commands;
        }
        void CreateMissingFolders()
        {
            int index = 0;
            foreach (string folder in gameFolders.Items)
            {
                if (gameFolders.GetItemChecked(index))
                {
                    string combined = SDKpathBox.Text + "\\sourcetest\\custom\\" + folder;
                    if (!Directory.Exists(combined))
                    {
                        Directory.CreateDirectory(combined);
                    }
                }
                index++;
            }
        }
        private static async void WaitKillCMD(Process cmd)
        {
            await Task.Delay(2000);
            cmd.Kill();
            string msg = "Directories were linked.";
            string caption = "Linked Directories";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LINKbutton_Click(object sender, EventArgs e)
        {
            if (gameFolders.CheckedItems.Count == 0)
            {
                string gcaption = "Error";
                string gmsg = "You must select a game folder.";
                MessageBox.Show(gmsg, gcaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            if (resourceFolders.CheckedItems.Count == 0)
            {
                string gcaption = "Error";
                string gmsg = "You must select a resource folder.";
                MessageBox.Show(gmsg, gcaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            string caption = $"Confirmation";
            string msg = "This will execute the following console commands and create the following folders in Source SDK 2013:\n\n";
            msg += GatherConsoleCommands();

            DialogResult result;
            result = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                CreateMissingFolders();

                // Create a .bat file and then delete it quickly (so we can add arguments)
                using (StreamWriter sw = File.CreateText("HPPDirLink_latest.bat"))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine(GatherConsoleCommands());
                    sw.WriteLine($"del HPPDirLink_latest.bat");
                }

                Process cmd = new();
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = $"/K HPPDirLink_latest.bat";
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.Start();

                WaitKillCMD(cmd);
            }
        }
        private static void OpenUrl(string url)
        {
            // For whatever reason this doesn't work, so had to do this
            try
            {
                Process.Start(url);
            }
            catch
            {
                url = url.Replace("&", "^&");
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
        private void HammerPPLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("https://ficool2.github.io/HammerPlusPlus-Website/");
        }

        private void UPDATEbutton_Click(object sender, EventArgs e)
        {
            string latestVersion = "https://raw.githubusercontent.com/Kizoky/postal3-hammerplusplus-tool/main/version.p3hppt";
            using (WebClient client = new())
            {
                using var stream = client.OpenRead(latestVersion);
                StreamReader reader = new(stream);
                latestVersion = reader.ReadToEnd();
            }

            if (programVersion.Text != latestVersion)
            {
                string latestChangelog = "https://raw.githubusercontent.com/Kizoky/postal3-hammerplusplus-tool/main/LatestChangelog.txt";
                using (WebClient client = new())
                {
                    using var stream = client.OpenRead(latestChangelog);
                    StreamReader reader = new(stream);
                    latestChangelog = reader.ReadToEnd();
                }

                MessageBox.Show($"An update ({latestVersion}) is available:\n\n{latestChangelog}", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have the latest GitHub release.", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FGDbutton_Click(object sender, EventArgs e)
        {
            if (!FGDWindow.IsDisposed)
            {
                FGDWindow.Show();
            }
            else
            {
                FGDWindow = new FixPostalFGD();
                FGDWindow.Show();
            }
        }

        // Plainly obvious.... if you read the source code :(
        private SoundPlayer Player = new SoundPlayer();
        bool once = false;
        int clicks = 0;
        private void programVersion_Click(object sender, EventArgs e)
        {
            clicks++;

            if (Player.IsLoadCompleted && clicks > 20)
            {
                Player.PlaySync();
                clicks = 0;
                return;
            }

            if (!once)
            {
                Player.SoundLocation = "https://www.wavsource.com/snds_2020-10-01_3728627494378403/people/comedians/allen_arrogh.wav";
                Player.LoadAsync();
                once = true;
            }
        }

        private void HPPDirectoryLinker_Load(object sender, EventArgs e)
        {

        }
    }
}