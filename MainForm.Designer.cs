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
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextBoxRawFile = new System.Windows.Forms.TextBox();
            this.ButtonProcessRawFile = new System.Windows.Forms.Button();
            this.LabelRawFile = new System.Windows.Forms.Label();
            this.LabelSort = new System.Windows.Forms.Label();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.TextBoxSort = new System.Windows.Forms.TextBox();
            this.ButtonBrowse2 = new System.Windows.Forms.Button();
            this.LabelGroup = new System.Windows.Forms.Label();
            this.ButtonGroup = new System.Windows.Forms.Button();
            this.TextBoxGroup = new System.Windows.Forms.TextBox();
            this.ButtonBrowse3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(215, 40);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(57, 23);
            this.ButtonBrowse.TabIndex = 0;
            this.ButtonBrowse.Text = "browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextBoxRawFile
            // 
            this.TextBoxRawFile.Location = new System.Drawing.Point(28, 43);
            this.TextBoxRawFile.Name = "TextBoxRawFile";
            this.TextBoxRawFile.Size = new System.Drawing.Size(181, 20);
            this.TextBoxRawFile.TabIndex = 1;
            // 
            // ButtonProcessRawFile
            // 
            this.ButtonProcessRawFile.Location = new System.Drawing.Point(28, 69);
            this.ButtonProcessRawFile.Name = "ButtonProcessRawFile";
            this.ButtonProcessRawFile.Size = new System.Drawing.Size(181, 23);
            this.ButtonProcessRawFile.TabIndex = 2;
            this.ButtonProcessRawFile.Text = "Process Raw File";
            this.ButtonProcessRawFile.UseVisualStyleBackColor = true;
            this.ButtonProcessRawFile.Click += new System.EventHandler(this.ButtonProcessRawFile_Click);
            // 
            // LabelRawFile
            // 
            this.LabelRawFile.AutoSize = true;
            this.LabelRawFile.Location = new System.Drawing.Point(25, 27);
            this.LabelRawFile.Name = "LabelRawFile";
            this.LabelRawFile.Size = new System.Drawing.Size(48, 13);
            this.LabelRawFile.TabIndex = 3;
            this.LabelRawFile.Text = "Raw File";
            // 
            // LabelSort
            // 
            this.LabelSort.AutoSize = true;
            this.LabelSort.Location = new System.Drawing.Point(25, 98);
            this.LabelSort.Name = "LabelSort";
            this.LabelSort.Size = new System.Drawing.Size(26, 13);
            this.LabelSort.TabIndex = 7;
            this.LabelSort.Text = "Sort";
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(28, 140);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(181, 23);
            this.ButtonSort.TabIndex = 6;
            this.ButtonSort.Text = "Sort Processed File";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // TextBoxSort
            // 
            this.TextBoxSort.Location = new System.Drawing.Point(28, 114);
            this.TextBoxSort.Name = "TextBoxSort";
            this.TextBoxSort.Size = new System.Drawing.Size(181, 20);
            this.TextBoxSort.TabIndex = 5;
            // 
            // ButtonBrowse2
            // 
            this.ButtonBrowse2.Location = new System.Drawing.Point(215, 111);
            this.ButtonBrowse2.Name = "ButtonBrowse2";
            this.ButtonBrowse2.Size = new System.Drawing.Size(57, 23);
            this.ButtonBrowse2.TabIndex = 4;
            this.ButtonBrowse2.Text = "browse";
            this.ButtonBrowse2.UseVisualStyleBackColor = true;
            this.ButtonBrowse2.Click += new System.EventHandler(this.ButtonBrowse2_Click);
            // 
            // LabelGroup
            // 
            this.LabelGroup.AutoSize = true;
            this.LabelGroup.Location = new System.Drawing.Point(25, 168);
            this.LabelGroup.Name = "LabelGroup";
            this.LabelGroup.Size = new System.Drawing.Size(36, 13);
            this.LabelGroup.TabIndex = 11;
            this.LabelGroup.Text = "Group";
            // 
            // ButtonGroup
            // 
            this.ButtonGroup.Location = new System.Drawing.Point(28, 210);
            this.ButtonGroup.Name = "ButtonGroup";
            this.ButtonGroup.Size = new System.Drawing.Size(181, 23);
            this.ButtonGroup.TabIndex = 10;
            this.ButtonGroup.Text = "Print Groups";
            this.ButtonGroup.UseVisualStyleBackColor = true;
            this.ButtonGroup.Click += new System.EventHandler(this.ButtonGroup_Click);
            // 
            // TextBoxGroup
            // 
            this.TextBoxGroup.Location = new System.Drawing.Point(28, 184);
            this.TextBoxGroup.Name = "TextBoxGroup";
            this.TextBoxGroup.Size = new System.Drawing.Size(181, 20);
            this.TextBoxGroup.TabIndex = 9;
            // 
            // ButtonBrowse3
            // 
            this.ButtonBrowse3.Location = new System.Drawing.Point(215, 181);
            this.ButtonBrowse3.Name = "ButtonBrowse3";
            this.ButtonBrowse3.Size = new System.Drawing.Size(57, 23);
            this.ButtonBrowse3.TabIndex = 8;
            this.ButtonBrowse3.Text = "browse";
            this.ButtonBrowse3.UseVisualStyleBackColor = true;
            this.ButtonBrowse3.Click += new System.EventHandler(this.ButtonBrowse3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LabelGroup);
            this.Controls.Add(this.ButtonGroup);
            this.Controls.Add(this.TextBoxGroup);
            this.Controls.Add(this.ButtonBrowse3);
            this.Controls.Add(this.LabelSort);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.TextBoxSort);
            this.Controls.Add(this.ButtonBrowse2);
            this.Controls.Add(this.LabelRawFile);
            this.Controls.Add(this.ButtonProcessRawFile);
            this.Controls.Add(this.TextBoxRawFile);
            this.Controls.Add(this.ButtonBrowse);
            this.Name = "MainForm";
            this.Text = "Sort Netlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TextBoxRawFile;
        private System.Windows.Forms.Button ButtonProcessRawFile;
        private System.Windows.Forms.Label LabelRawFile;
        private System.Windows.Forms.Label LabelSort;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.TextBox TextBoxSort;
        private System.Windows.Forms.Button ButtonBrowse2;
        private System.Windows.Forms.Label LabelGroup;
        private System.Windows.Forms.Button ButtonGroup;
        private System.Windows.Forms.TextBox TextBoxGroup;
        private System.Windows.Forms.Button ButtonBrowse3;
    }
}

