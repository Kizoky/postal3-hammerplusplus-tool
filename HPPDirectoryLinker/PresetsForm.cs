using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPPDirectoryLinker
{
    public partial class PresetsForm : Form
    {
        string curSDK = "undefined", curP3 = "undefined";
        string[]? existingPresetNames = null;

        public HPPDirectoryLinker Main;

        public void UpdatePath(string SDK, string P3)
        {
            if (SDK[0] != '<' && P3[0] != '<')
            {
                curSDK = SDK;
                curP3 = P3;
                loadPathsButton.Enabled = true;
            }
        }

        public PresetsForm(string SDK, string P3, HPPDirectoryLinker app)
        {
            InitializeComponent();

            Main = app;

            if (SDK[0] != '<' && P3[0] != '<')
            {
                curSDK = SDK;
                curP3 = P3;
            }
            else
            {
                loadPathsButton.Enabled = false;
            }

            if (!File.Exists(Application.UserAppDataPath + "\\config.txt"))
            {
                using (StreamWriter sw = File.CreateText(Application.UserAppDataPath + "\\config.txt"))
                {
                    sw.WriteLine("");
                }
            }
            else
            {
                FillFromExistingPresets();
            }

            saveChangesButton.Enabled = false;
            loadOntoMainAppButton.Enabled = false;
        }

        void FillFromExistingPresets()
        {
            presetCombo.Items.Clear();
            existingPresetNames = null;

            string[] content = File.ReadAllLines(Application.UserAppDataPath + "\\config.txt");

            // Get the names of the presets first...
            string curPresetName = null;
            int index = -1;
            foreach (string s in content)
            {
                if (s.Length > 1)
                {
                    string tempname = "";
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == '.')
                        {
                            break;
                        }

                        tempname = tempname + s[i];
                    }

                    if (tempname != curPresetName)
                    {
                        curPresetName = tempname;
                        index++;

                        Array.Resize(ref existingPresetNames, index + 1);
                        existingPresetNames[index] = curPresetName;
                        presetCombo.Items.Add(curPresetName);
                    }
                }
            }

            if (presetCombo.Items.Count > 0)
            {
                if (presetCombo.Items[0] != null)
                {
                    presetCombo.SelectedIndex = 0;
                    loadOntoMainAppButton.Enabled = true;

                    if (Main != null)
                        Main.LoadFirstPresetOnStartup(SDKpathbox.Text, P3pathbox.Text);
                }
            }
            else
            {
                deletePresetButton.Enabled = false;
                loadOntoMainAppButton.Enabled = false;
            }
        }

        string GetPathFromName(string Name, string P3oSDK)
        {
            string[] content = File.ReadAllLines(Application.UserAppDataPath + "\\config.txt");
            string Path = "";

            foreach (string s in content)
            {
                int namestart = s.IndexOf(Name);
                int pathstart = s.IndexOf(P3oSDK);
                if (namestart != -1 && pathstart != -1)
                {
                    for (int i = s.IndexOf('=')+1; i < s.Length; i++)
                    {
                        Path = Path + s[i];
                    }
                }
            }

            return Path;
        }

        private void presetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SDKpathbox.Text = GetPathFromName($"{existingPresetNames[presetCombo.SelectedIndex]}", "SDKpath");
            P3pathbox.Text = GetPathFromName($"{existingPresetNames[presetCombo.SelectedIndex]}", "P3path");

            saveChangesButton.Enabled = false;

            if (SDKpathbox.Text.Length > 1 && P3pathbox.Text.Length > 1)
            {
                loadOntoMainAppButton.Enabled = true;
            }
        }

        private void deletePresetButton_Click(object sender, EventArgs e)
        {
            string[] content = File.ReadAllLines(Application.UserAppDataPath + "\\config.txt");
            string[] newcontent = null;
            int index = 0;
            foreach (string s in content)
            {
                int namestart = s.IndexOf($"{existingPresetNames[presetCombo.SelectedIndex]}");
                if (namestart == -1)
                {
                    Array.Resize(ref newcontent, index + 1);
                    newcontent[index] = s;
                    index++;
                }

                //Console.WriteLine($"{s} namestart: {namestart} Looking for: {existingPresetNames[presetCombo.SelectedIndex]}");
            }

            if (newcontent != null)
            {
                using (StreamWriter sw = File.CreateText(Application.UserAppDataPath + "\\config.txt"))
                {
                    foreach (string s in newcontent)
                    {
                        sw.WriteLine($"{s}");
                    }
                }
            }
            else
            {
                if (presetCombo.Items.Count == 1)
                {
                    using (StreamWriter sw = File.CreateText(Application.UserAppDataPath + "\\config.txt"))
                    {
                        sw.Write("");
                    }

                    presetCombo.Text = "<No Presets>";
                    SDKpathbox.Text = "<Empty>";
                    P3pathbox.Text = "<Empty>";
                }
            }

            // Refill...
            FillFromExistingPresets();
        }

        string ReplaceSDKtext = null;
        string ReplaceP3text = null;
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (ReplaceSDKtext == null)
            {
                ReplaceSDKtext = SDKpathbox.Text;
            }

            if (ReplaceP3text == null)
            {
                ReplaceP3text = P3pathbox.Text;
            }

            string[] content = File.ReadAllLines(Application.UserAppDataPath + "\\config.txt");
            string[] newcontent = null;

            int index = 0;
            foreach (string s in content)
            {
                string t = s;

                int namestart = t.IndexOf($"{existingPresetNames[presetCombo.SelectedIndex]}");
                if (namestart != -1)
                {
                    if (t.IndexOf("SDKpath") != -1)
                    {
                        t = t.Replace(ReplaceSDKtext, SDKpathbox.Text);
                    }

                    if (t.IndexOf("P3path") != -1)
                    {
                        t = t.Replace(ReplaceP3text, P3pathbox.Text);
                    }
                }

                Array.Resize(ref newcontent, index + 1);
                newcontent[index] = t;
                index++;
            }

            File.WriteAllLines(Application.UserAppDataPath + "\\config.txt", newcontent);

            saveChangesButton.Enabled = false;
            presetCombo.Enabled = true;
            deletePresetButton.Enabled = true;
            loadPathsButton.Enabled = true;
        }

        private void SDKeditButton_Click(object sender, EventArgs e)
        {
            ReplaceSDKtext = SDKpathbox.Text;

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

                SDKpathbox.Text = folderDlg.SelectedPath;
                saveChangesButton.Enabled = true;

                presetCombo.Enabled = false;
                deletePresetButton.Enabled = false;
                loadPathsButton.Enabled = false;
            }
        }

        private void P3editButton_Click(object sender, EventArgs e)
        {
            ReplaceP3text = P3pathbox.Text;

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
                P3pathbox.Text = folderDlg.SelectedPath;
                saveChangesButton.Enabled = true;

                presetCombo.Enabled = false;
                deletePresetButton.Enabled = false;
                loadPathsButton.Enabled = false;
            }
        }

        private void createNewPresetButton_Click(object sender, EventArgs e)
        {
            string[] content = File.ReadAllLines(Application.UserAppDataPath + "\\config.txt");

            bool identical = false;
            foreach (string s in content)
            {
                int namestart = s.IndexOf($"! {presetNameBox.Text}");
                if (namestart != -1)
                {
                    identical = true;
                }
            }

            if (identical)
            {
                string msg = "There's already a preset name called like that. Please use a different preset name.";
                string caption = "Identical Names";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamWriter sw = File.CreateText(Application.UserAppDataPath + "\\config.txt"))
            {
                foreach (string s in content)
                {
                    sw.WriteLine($"{s}");
                }

                // The ! and space is required so it's not always identical
                sw.WriteLine($"! {presetNameBox.Text}.SDKpath=<Path to your Source SDK Base 2013 SP/MP installation>");
                sw.WriteLine($"! {presetNameBox.Text}.P3path=<Path to your Postal III installation>");
            }

            // Refill...
            FillFromExistingPresets();

            if (presetCombo.Items[presetCombo.Items.Count-1] != null)
            {
                presetCombo.SelectedIndex = presetCombo.Items.Count-1;
            }
        }

        private void loadOntoMainAppButton_Click(object sender, EventArgs e)
        {
            Main.FillDataFromPresets(SDKpathbox.Text, P3pathbox.Text);
        }

        private void newPresetButton_Click(object sender, EventArgs e)
        {
            ReplaceSDKtext = SDKpathbox.Text;
            ReplaceP3text = P3pathbox.Text;

            SDKpathbox.Text = curSDK;
            P3pathbox.Text = curP3;

            saveChangesButton.Enabled = true;
        }
    }
}
