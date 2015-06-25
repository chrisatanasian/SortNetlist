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
            this.LabelRaw = new System.Windows.Forms.Label();
            this.ButtonBrowseRaw = new System.Windows.Forms.Button();
            this.TextBoxRaw = new System.Windows.Forms.TextBox();
            this.ButtonRaw = new System.Windows.Forms.Button();
            this.LabelGroups = new System.Windows.Forms.Label();
            this.TextBoxGroups = new System.Windows.Forms.TextBox();
            this.ButonProcessed = new System.Windows.Forms.Button();
            this.TextBoxProcessed = new System.Windows.Forms.TextBox();
            this.ButtonBrowseProcessed = new System.Windows.Forms.Button();
            this.LabelProcessed = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
            // 
            // LabelRaw
            // 
            this.LabelRaw.AutoSize = true;
            this.LabelRaw.Location = new System.Drawing.Point(25, 19);
            this.LabelRaw.Name = "LabelRaw";
            this.LabelRaw.Size = new System.Drawing.Size(48, 13);
            this.LabelRaw.TabIndex = 0;
            this.LabelRaw.Text = "Raw File";
            // 
            // ButtonBrowseRaw
            // 
            this.ButtonBrowseRaw.Location = new System.Drawing.Point(173, 39);
            this.ButtonBrowseRaw.Name = "ButtonBrowseRaw";
            this.ButtonBrowseRaw.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseRaw.TabIndex = 1;
            this.ButtonBrowseRaw.Text = "browse";
            this.ButtonBrowseRaw.UseVisualStyleBackColor = true;
            this.ButtonBrowseRaw.Click += new System.EventHandler(this.ButtonBrowseRaw_Click);
            // 
            // TextBoxRaw
            // 
            this.TextBoxRaw.Location = new System.Drawing.Point(28, 41);
            this.TextBoxRaw.Name = "TextBoxRaw";
            this.TextBoxRaw.Size = new System.Drawing.Size(139, 20);
            this.TextBoxRaw.TabIndex = 2;
            // 
            // ButtonRaw
            // 
            this.ButtonRaw.Location = new System.Drawing.Point(28, 68);
            this.ButtonRaw.Name = "ButtonRaw";
            this.ButtonRaw.Size = new System.Drawing.Size(139, 23);
            this.ButtonRaw.TabIndex = 3;
            this.ButtonRaw.Text = "Process Raw File";
            this.ButtonRaw.UseVisualStyleBackColor = true;
            this.ButtonRaw.Click += new System.EventHandler(this.ButtonRaw_Click);
            // 
            // LabelGroups
            // 
            this.LabelGroups.AutoSize = true;
            this.LabelGroups.Location = new System.Drawing.Point(280, 19);
            this.LabelGroups.Name = "LabelGroups";
            this.LabelGroups.Size = new System.Drawing.Size(41, 13);
            this.LabelGroups.TabIndex = 4;
            this.LabelGroups.Text = "Groups";
            // 
            // TextBoxGroups
            // 
            this.TextBoxGroups.Location = new System.Drawing.Point(266, 42);
            this.TextBoxGroups.Name = "TextBoxGroups";
            this.TextBoxGroups.Size = new System.Drawing.Size(276, 20);
            this.TextBoxGroups.TabIndex = 5;
            this.TextBoxGroups.Text = "FMC_LA, FMC_HA, FMC_HB";
            this.TextBoxGroups.TextChanged += new System.EventHandler(this.TextBoxGroups_TextChanged);
            // 
            // ButonProcessed
            // 
            this.ButonProcessed.Location = new System.Drawing.Point(28, 152);
            this.ButonProcessed.Name = "ButonProcessed";
            this.ButonProcessed.Size = new System.Drawing.Size(139, 23);
            this.ButonProcessed.TabIndex = 9;
            this.ButonProcessed.Text = "Finsih Processed File";
            this.ButonProcessed.UseVisualStyleBackColor = true;
            this.ButonProcessed.Click += new System.EventHandler(this.ButonProcessed_Click);
            // 
            // TextBoxProcessed
            // 
            this.TextBoxProcessed.Location = new System.Drawing.Point(28, 125);
            this.TextBoxProcessed.Name = "TextBoxProcessed";
            this.TextBoxProcessed.Size = new System.Drawing.Size(139, 20);
            this.TextBoxProcessed.TabIndex = 8;
            // 
            // ButtonBrowseProcessed
            // 
            this.ButtonBrowseProcessed.Location = new System.Drawing.Point(173, 123);
            this.ButtonBrowseProcessed.Name = "ButtonBrowseProcessed";
            this.ButtonBrowseProcessed.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseProcessed.TabIndex = 7;
            this.ButtonBrowseProcessed.Text = "browse";
            this.ButtonBrowseProcessed.UseVisualStyleBackColor = true;
            this.ButtonBrowseProcessed.Click += new System.EventHandler(this.ButtonBrowseProcessed_Click);
            // 
            // LabelProcessed
            // 
            this.LabelProcessed.AutoSize = true;
            this.LabelProcessed.Location = new System.Drawing.Point(25, 103);
            this.LabelProcessed.Name = "LabelProcessed";
            this.LabelProcessed.Size = new System.Drawing.Size(76, 13);
            this.LabelProcessed.TabIndex = 6;
            this.LabelProcessed.Text = "Processed File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 188);
            this.Controls.Add(this.ButonProcessed);
            this.Controls.Add(this.TextBoxProcessed);
            this.Controls.Add(this.ButtonBrowseProcessed);
            this.Controls.Add(this.LabelProcessed);
            this.Controls.Add(this.TextBoxGroups);
            this.Controls.Add(this.LabelGroups);
            this.Controls.Add(this.ButtonRaw);
            this.Controls.Add(this.TextBoxRaw);
            this.Controls.Add(this.ButtonBrowseRaw);
            this.Controls.Add(this.LabelRaw);
            this.Name = "MainForm";
            this.Text = "Sort Netlist by Chris Atanasian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelRaw;
        private System.Windows.Forms.Button ButtonBrowseRaw;
        private System.Windows.Forms.TextBox TextBoxRaw;
        private System.Windows.Forms.Button ButtonRaw;
        private System.Windows.Forms.Label LabelGroups;
        private System.Windows.Forms.TextBox TextBoxGroups;
        private System.Windows.Forms.Button ButonProcessed;
        private System.Windows.Forms.TextBox TextBoxProcessed;
        private System.Windows.Forms.Button ButtonBrowseProcessed;
        private System.Windows.Forms.Label LabelProcessed;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

