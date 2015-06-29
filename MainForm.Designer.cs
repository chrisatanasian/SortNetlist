namespace SortNetlist
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LabelFile = new System.Windows.Forms.Label();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.TextBoxFile = new System.Windows.Forms.TextBox();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.LabelGroups = new System.Windows.Forms.Label();
            this.TextBoxGroups = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFile
            // 
            this.LabelFile.AutoSize = true;
            this.LabelFile.Location = new System.Drawing.Point(24, 21);
            this.LabelFile.Name = "LabelFile";
            this.LabelFile.Size = new System.Drawing.Size(26, 13);
            this.LabelFile.TabIndex = 0;
            this.LabelFile.Text = "File:";
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(229, 41);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 1;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowseRaw_Click);
            // 
            // TextBoxFile
            // 
            this.TextBoxFile.Location = new System.Drawing.Point(27, 41);
            this.TextBoxFile.Name = "TextBoxFile";
            this.TextBoxFile.Size = new System.Drawing.Size(195, 20);
            this.TextBoxFile.TabIndex = 2;
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(27, 67);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(195, 23);
            this.ButtonSort.TabIndex = 3;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonRaw_Click);
            // 
            // LabelGroups
            // 
            this.LabelGroups.AutoSize = true;
            this.LabelGroups.Location = new System.Drawing.Point(24, 109);
            this.LabelGroups.Name = "LabelGroups";
            this.LabelGroups.Size = new System.Drawing.Size(44, 13);
            this.LabelGroups.TabIndex = 4;
            this.LabelGroups.Text = "Groups:";
            // 
            // TextBoxGroups
            // 
            this.TextBoxGroups.Location = new System.Drawing.Point(27, 128);
            this.TextBoxGroups.Name = "TextBoxGroups";
            this.TextBoxGroups.Size = new System.Drawing.Size(195, 20);
            this.TextBoxGroups.TabIndex = 5;
            this.TextBoxGroups.Text = "FMC_LA, FMC_HA, FMC_HB";
            this.TextBoxGroups.TextChanged += new System.EventHandler(this.TextBoxGroups_TextChanged);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(229, 128);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 172);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.TextBoxGroups);
            this.Controls.Add(this.LabelGroups);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.TextBoxFile);
            this.Controls.Add(this.ButtonBrowse);
            this.Controls.Add(this.LabelFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sort Netlist by Chris Atanasian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelFile;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.TextBox TextBoxFile;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Label LabelGroups;
        private System.Windows.Forms.TextBox TextBoxGroups;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button ButtonClear;
    }
}

