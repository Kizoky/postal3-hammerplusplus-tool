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
    public partial class FixPostalFGD : Form
    {
        public FixPostalFGD()
        {
            InitializeComponent();
        }
        static string[]? BracketRemoval(string[] array, string field)
        {
            string[]? temp = array;

            // Look for the last ] character
            char lastchar = ']';
            bool search = false;
            bool found = false;
            int[]? startIndexes = null;
            int[]? endIndexes = null;
            int startIndex = 0;
            int endIndex = 0;

            int index = 0;
            foreach (string s in temp)
            {
                string tscript = s.Replace("\t", "");
                tscript = tscript.Replace(" ", "");

                int printstart = tscript.IndexOf(field);
                if (printstart != -1)
                {
                    Console.WriteLine($"Found first index at {index + 1}");
                    Array.Resize(ref startIndexes, startIndex + 1);
                    startIndexes[startIndex] = index;
                    startIndex++;
                    search = true;
                    found = true;
                }

                if (search)
                {
                    if (tscript.Length == 1)
                    {
                        if (char.Parse(tscript) != lastchar)
                        {
                            lastchar = char.Parse(tscript);
                        }
                        else
                        {
                            Console.WriteLine($"Found last character at {index + 1}");
                            Array.Resize(ref endIndexes, endIndex + 1);
                            endIndexes[endIndex] = index;
                            endIndex++;
                            search = false;
                        }
                    }
                    else
                    {
                        // Let's also not forget we can have [] characters in a single line
                        int bracketstart = tscript.IndexOf("[");
                        int bracketend = tscript.IndexOf("]");
                        if (bracketstart != -1 && bracketend != -1)
                        {
                            lastchar = ']';
                        }
                    }
                }

                index++;
            }

            if (found)
            {
                for (int j = 0; j < endIndexes.Length; j++)
                {
                    for (int i = startIndexes[j]; i < endIndexes[j] + 1; i++)
                    {
                        temp[i] = "//" + temp[i];
                    }
                }
            }

            return temp;
        }
        private void FixFGDbutton_Click(object sender, EventArgs e)
        {
            string[]? fileContent = null;
            string fileName = null;
            string filePath = null;

            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "fgd files (*.fgd)|*.fgd";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        fileContent = File.ReadAllLines(openFileDialog.FileName);
                        fileName = openFileDialog.SafeFileName;
                        filePath = openFileDialog.FileName;
                        filePath = filePath.Replace(fileName, "");
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't read FGD file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (fileContent.Length <= 0)
            {
                MessageBox.Show("FGD file is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool alreadyGenerated;

            if (fileName.IndexOf("HPP") != -1)
            {
                alreadyGenerated = true;
            }

            foreach (string s in fileContent)
            {
                int generated = s.IndexOf("github");
                if (generated != -1)
                {
                    alreadyGenerated = true;
                }
            }

            DialogResult result = MessageBox.Show("Selected FGD file has been edited by this tool before, it is recommended to use the original FGD file.\n\nDo you wish to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            progressBar1.Visible = true;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 4;
            progressBar1.Value = 0;
            progressBar1.Step = 1;

            // This should be slow enough for the array to not be messed up
            string[] npc_prefab = BracketRemoval(fileContent, "npc_prefab");
            progressBar1.PerformStep();
            Task.Delay(750).Wait();
            string[] ammo_prefab = BracketRemoval(npc_prefab, "ammo_prefab");
            progressBar1.PerformStep();
            Task.Delay(750).Wait();
            string[] node_prefab = BracketRemoval(ammo_prefab, "node_prefab");
            progressBar1.PerformStep();
            Task.Delay(750).Wait();
            string[] item_prefab = BracketRemoval(node_prefab, "item_prefab");
            progressBar1.PerformStep();

            Task.Delay(750).Wait();
            progressBar1.Value = 0;

            using (StreamWriter sw = File.CreateText($"{filePath}HPP_{fileName}"))
            {
                sw.WriteLine("// Edited by Hammer++ Directory Linker (github.com/Kizoky/postal3-hammerplusplus-tool)");
                foreach (string s in item_prefab)
                {
                    sw.WriteLine(s);
                }
            }

            if (!File.Exists($"{filePath}HPP_{fileName}"))
            {
                MessageBox.Show($"FGD saved as 'HPP_{fileName}' in '{filePath}'.", "FGD File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"'HPP_{fileName}' updated in '{filePath}'.", "FGD File Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
