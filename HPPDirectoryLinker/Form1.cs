using System.Diagnostics;
using System.Media;
using System.Net;

namespace HPPDirectoryLinker
{
    public partial class HPPDirectoryLinker : Form
    {
        FixPostalFGD FGDWindow = new();
        AboutForm AboutWindow = new();
        PresetsForm PresetsWindow = new("<", "<", null);

        bool bShadersWarning;
        public HPPDirectoryLinker()
        {
            InitializeComponent();

            // These should be on by default
            resourceFolders.SetItemChecked(0, true);
            resourceFolders.SetItemChecked(1, true);

            // Preventing any memory leak.. lol
            PresetsWindow.Dispose();
            PresetsWindow = new PresetsForm(SDKpathBox.Text, P3pathBox.Text, this);
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
                // Source SDK 2013 Singleplayer or Multiplayer has sourcetest folder
                foreach (string dir in Directory.GetDirectories(folderDlg.SelectedPath, "sourcetest"))
                {
                    ValidSDK = true;
                }

                // Folder wasn't found
                if (!ValidSDK)
                {
                    string msg = "Not a valid path to Source SDK 2013 installation.";
                    string caption = "Invalid Path";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check for Hammer++
                string hpp = folderDlg.SelectedPath + "\\bin\\hammerplusplus.exe";
                if (!File.Exists(hpp))
                {
                    string msg = "Hammer++ was not detected in this SDK installation.";
                    string caption = "Hammer++ Not Detected";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Enable Postal 3 and clear button
                SDKpathBox.Text = folderDlg.SelectedPath;
                POSTAL3button.Enabled = true;
                CLEARbutton.Enabled = true;

                PresetsWindow.UpdatePath(SDKpathBox.Text, P3pathBox.Text);
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
                // p3 folder
                foreach (string dir in Directory.GetDirectories(folderDlg.SelectedPath, "p3"))
                {
                    ValidP3 = true;
                }

                // cr_base folder (Catharsis Reborn)
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

                // Fill the list, enable buttons
                P3pathBox.Text = folderDlg.SelectedPath;
                FillGameFolderBox();
                LINKbutton.Enabled = true;
                gameFolders.Enabled = true;
                resourceFolders.Enabled = true;

                PresetsWindow.UpdatePath(SDKpathBox.Text, P3pathBox.Text);
            }
        }
        void FillGameFolderBox()
        {
            // Clear game folders (so it won't fill the items twice or more)
            gameFolders.Items.Clear();

            foreach (string dir in Directory.GetDirectories(P3pathBox.Text))
            {
                // Remove full path to these folders
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
            // custom folder doesn't always exists
            string custom = SDKpathBox.Text + "\\sourcetest\\custom";
            if (!Directory.Exists(custom))
            {
                Directory.CreateDirectory(custom);
            }

            int index = 0;
            // create folders one by one, if not then mklink will screech about non-existent folders
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
            // People doesn't like when something is running in the background, I don't either
            await Task.Delay(2000);
            cmd.Kill();
            string msg = "Directories were linked.";
            string caption = "Linked Directories";
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LINKbutton_Click(object sender, EventArgs e)
        {
            // Dude, you can't link anything if you haven't checked anything
            if (gameFolders.CheckedItems.Count == 0)
            {
                string gcaption = "Error";
                string gmsg = "You must select a game folder.";
                MessageBox.Show(gmsg, gcaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                return;
            }

            // Same here
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
                // Create missing folders so mklink will not blow up
                CreateMissingFolders();

                // Create a .bat file and then delete it quickly
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

                // Kill the CMD after 2 seconds
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
                MessageBox.Show($"You have the latest GitHub release ({latestVersion}).", "No Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FGDbutton_Click(object sender, EventArgs e)
        {
            // Bring up the FGD Window
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

        private void CLEARbutton_Click(object sender, EventArgs e)
        {
            // Delete custom folder
            var directory = new DirectoryInfo(SDKpathBox.Text + "\\sourcetest\\custom");
            if (directory.Exists)
            {
                foreach (DirectoryInfo dir in directory.GetDirectories())
                {
                    // I can't do anything about unauthorized access error, so this is the best way to make it shut up
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        // stub intentionally
                    }
                }

                string msg = "Linked folders were cleaned from Source SDK 2013.";
                string caption = "Clear";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string msg = "Custom folder in sourcetest was not found. Link directories first with the tool.";
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resourceFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resourceFolders.GetItemChecked(3) && !bShadersWarning)
            {
                string msg = "It is not recommended to link 'shaders' folder, as it can cause black screen, and you'll be unable to work on maps.\n\nEven if 'shaders' will work now, there's no gurantee they'll always work.\n\nYou can try experimenting with it, but it's not really recommended to link.";
                string caption = "Warning";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bShadersWarning = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Bring up the FGD Window
            if (!AboutWindow.IsDisposed)
            {
                AboutWindow.Show();
            }
            else
            {
                AboutWindow = new AboutForm();
                AboutWindow.Show();
            }
        }

        private void presetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Bring up the Presets Window
            if (!PresetsWindow.IsDisposed)
            {
                //PresetsWindow.Dispose();
                //PresetsWindow = new PresetsForm(SDKpathBox.Text, P3pathBox.Text);
                PresetsWindow.Show();
            }
            else
            {
                PresetsWindow = new PresetsForm(SDKpathBox.Text, P3pathBox.Text, this);
                PresetsWindow.Show();
            }
        }

        public void FillDataFromPresets(string SDK, string P3)
        {
            if (SDK != null && P3 != null)
            {
                // Enable Postal 3 and clear button
                SDKpathBox.Text = SDK;
                POSTAL3button.Enabled = true;
                CLEARbutton.Enabled = true;

                // Fill the list, enable buttons
                P3pathBox.Text = P3;
                FillGameFolderBox();
                LINKbutton.Enabled = true;
                gameFolders.Enabled = true;
                resourceFolders.Enabled = true;

                PresetsWindow.UpdatePath(SDKpathBox.Text, P3pathBox.Text);
            }
        }

        bool hasLoadedOnce;
        public void LoadFirstPresetOnStartup(string SDK, string P3)
        {
            if (!hasLoadedOnce)
            {
                if (SDK[0] != '<' && P3[0] != '<')
                {
                    FillDataFromPresets(SDK, P3);
                }

                hasLoadedOnce = true;
            }
        }
    }
}