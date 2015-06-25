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
            this.SuspendLayout();
            // 
            // LabelRaw
            // 
            this.LabelRaw.AutoSize = true;
            this.LabelRaw.Location = new System.Drawing.Point(41, 41);
            this.LabelRaw.Name = "LabelRaw";
            this.LabelRaw.Size = new System.Drawing.Size(48, 13);
            this.LabelRaw.TabIndex = 0;
            this.LabelRaw.Text = "Raw File";
            // 
            // ButtonBrowseRaw
            // 
            this.ButtonBrowseRaw.Location = new System.Drawing.Point(196, 61);
            this.ButtonBrowseRaw.Name = "ButtonBrowseRaw";
            this.ButtonBrowseRaw.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseRaw.TabIndex = 1;
            this.ButtonBrowseRaw.Text = "browse";
            this.ButtonBrowseRaw.UseVisualStyleBackColor = true;
            this.ButtonBrowseRaw.Click += new System.EventHandler(this.ButtonBrowseRaw_Click);
            // 
            // TextBoxRaw
            // 
            this.TextBoxRaw.Location = new System.Drawing.Point(44, 63);
            this.TextBoxRaw.Name = "TextBoxRaw";
            this.TextBoxRaw.Size = new System.Drawing.Size(139, 20);
            this.TextBoxRaw.TabIndex = 2;
            // 
            // ButtonRaw
            // 
            this.ButtonRaw.Location = new System.Drawing.Point(44, 96);
            this.ButtonRaw.Name = "ButtonRaw";
            this.ButtonRaw.Size = new System.Drawing.Size(139, 23);
            this.ButtonRaw.TabIndex = 3;
            this.ButtonRaw.Text = "Process Raw File";
            this.ButtonRaw.UseVisualStyleBackColor = true;
            this.ButtonRaw.Click += new System.EventHandler(this.ButtonRaw_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 325);
            this.Controls.Add(this.ButtonRaw);
            this.Controls.Add(this.TextBoxRaw);
            this.Controls.Add(this.ButtonBrowseRaw);
            this.Controls.Add(this.LabelRaw);
            this.Name = "MainForm";
            this.Text = "Sort Netlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelRaw;
        private System.Windows.Forms.Button ButtonBrowseRaw;
        private System.Windows.Forms.TextBox TextBoxRaw;
        private System.Windows.Forms.Button ButtonRaw;
    }
}

