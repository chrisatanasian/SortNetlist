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

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                TextBoxRawFile.Text = fileName;
            }
        }

        private void ButtonProcessRawFile_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBoxRawFile.Text)) {
                Program.convertRawToProcessed(TextBoxRawFile.Text);
            }
        }

        private void ButtonBrowse2_Click(object sender, EventArgs e) {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                string fileName = openFileDialog1.FileName;
                TextBoxSort.Text = fileName;
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(TextBoxSort.Text)) {
                Program.addToDictionary(TextBoxSort.Text);
                Program.sortNetlistAddDelta(TextBoxSort.Text.Replace(".txt", "_sorted.txt"));
            }
        }
    }
}
