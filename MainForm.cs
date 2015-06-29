using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SortNetlist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TextBoxGroups_TextChanged(object sender, EventArgs e) {
            Program.ChangeGroups(TextBoxGroups.Text);
        }

        private void Browse(TextBox sender) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                string fileName = openFileDialog1.FileName;
                sender.Text = fileName;
            }
        }

        private void ButtonBrowseRaw_Click(object sender, EventArgs e) {
            Browse(TextBoxFile);
        }

        private void ButtonRaw_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBoxFile.Text)) {
                Program.ConvertRawToProcessed(TextBoxFile.Text);

                string fileName = TextBoxFile.Text.Replace(".txt", "_sorted.txt");

                Program.AddToDictionary(fileName);
                Program.SortNetlistAddDelta(fileName);
                Program.ClearDictionaries();
                Program.AddToDictionary(fileName);
                Program.FindGroupMaxs();
                Program.AddDeltaGroupMaxDiffs(fileName);
                Program.ClearDictionaries();
            }
        }
    }
}
