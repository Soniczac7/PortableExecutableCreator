namespace PortableExecutable
{
    partial class SettingsForm
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
            label1 = new Label();
            szDirectory = new TextBox();
            browseButton1 = new Button();
            folderBrowser = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 0;
            label1.Text = "7-Zip Installation Directory";
            // 
            // szDirectory
            // 
            szDirectory.BackColor = Color.Black;
            szDirectory.BorderStyle = BorderStyle.FixedSingle;
            szDirectory.ForeColor = Color.White;
            szDirectory.Location = new Point(12, 27);
            szDirectory.Name = "szDirectory";
            szDirectory.Size = new Size(368, 23);
            szDirectory.TabIndex = 2;
            // 
            // browseButton1
            // 
            browseButton1.FlatAppearance.BorderColor = Color.White;
            browseButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            browseButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            browseButton1.FlatStyle = FlatStyle.Flat;
            browseButton1.Location = new Point(386, 27);
            browseButton1.Name = "browseButton1";
            browseButton1.Size = new Size(27, 23);
            browseButton1.TabIndex = 3;
            browseButton1.Text = "...";
            browseButton1.UseVisualStyleBackColor = true;
            browseButton1.Click += browseButton1_Click;
            // 
            // folderBrowser
            // 
            folderBrowser.Description = "Select a valid 7-Zip installation folder...";
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowser.UseDescriptionForTitle = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(425, 450);
            Controls.Add(browseButton1);
            Controls.Add(szDirectory);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            ShowIcon = false;
            Text = "Portable Executable Creator Settings";
            FormClosing += SettingsForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox szDirectory;
        private Button browseButton1;
        private FolderBrowserDialog folderBrowser;
    }
}