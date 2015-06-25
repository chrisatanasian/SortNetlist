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

        public string FileName
        {
            get { return TextBoxRawFile.Text; }
            set { TextBoxRawFile.Text = value; }
        }

        private void Browse(TextBox sender) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                string fileName = openFileDialog1.FileName;
                sender.Text = fileName;
            }
        }

        private void ButtonBrowse_Click(object sender, EventArgs e) {
            Browse(TextBoxRawFile);
        }

        private void ButtonBrowse2_Click(object sender, EventArgs e) {
            Browse(TextBoxSort);
        }

        private void ButtonBrowse3_Click(object sender, EventArgs e) {
            Browse(TextBoxGroup);
        }

        private void ButtonProcessRawFile_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBoxRawFile.Text)) {
                Program.ConvertRawToProcessed(TextBoxRawFile.Text);
            }
        }
        private void ButtonSort_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBoxSort.Text)) {
                Program.AddToDictionary(TextBoxSort.Text);
                Program.SortNetlistAddDelta(TextBoxSort.Text.Replace(".txt", "_sorted.txt"));
                Program.ClearNetlist();
            }
        }

        private void ButtonGroup_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBoxGroup.Text)) {
                Program.AddToDictionary(TextBoxGroup.Text);
                Program.PrintGroups(TextBoxGroup.Text.Replace(".txt", "_groups.txt"));
                Program.ClearNetlist();
            }
        }

    }
}
