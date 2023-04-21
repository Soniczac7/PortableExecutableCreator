namespace PortableExecutable
{
    partial class CreatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            info = new RichTextBox();
            label1 = new Label();
            conversionFolder = new TextBox();
            browseButton1 = new Button();
            label2 = new Label();
            browseButton2 = new Button();
            fileOutput = new TextBox();
            label3 = new Label();
            folderBrowser = new FolderBrowserDialog();
            saveFileDialog = new SaveFileDialog();
            compressionLevel = new ComboBox();
            label4 = new Label();
            executeFile = new ComboBox();
            preExeMessage = new TextBox();
            label5 = new Label();
            startButton = new Button();
            progressBar = new BetterProgressBar();
            button1 = new Button();
            SuspendLayout();
            // 
            // info
            // 
            info.BackColor = Color.Black;
            info.BorderStyle = BorderStyle.None;
            info.ForeColor = Color.White;
            info.Location = new Point(12, 12);
            info.Name = "info";
            info.ReadOnly = true;
            info.Size = new Size(729, 37);
            info.TabIndex = 999;
            info.Text = "To create your potable executable, select a folder to convert, select an output directory and any other options.\nOnce you have finished click \"Start\" and your portable executable will start creating.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 1;
            label1.Text = "Conversion Folder";
            // 
            // conversionFolder
            // 
            conversionFolder.BackColor = Color.Black;
            conversionFolder.BorderStyle = BorderStyle.FixedSingle;
            conversionFolder.ForeColor = Color.White;
            conversionFolder.Location = new Point(12, 70);
            conversionFolder.Name = "conversionFolder";
            conversionFolder.Size = new Size(743, 23);
            conversionFolder.TabIndex = 1;
            conversionFolder.TextChanged += conversionFolder_TextChanged;
            // 
            // browseButton1
            // 
            browseButton1.FlatAppearance.BorderColor = Color.White;
            browseButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            browseButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            browseButton1.FlatStyle = FlatStyle.Flat;
            browseButton1.Location = new Point(761, 69);
            browseButton1.Name = "browseButton1";
            browseButton1.Size = new Size(27, 23);
            browseButton1.TabIndex = 2;
            browseButton1.Text = "...";
            browseButton1.UseVisualStyleBackColor = true;
            browseButton1.Click += browseButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Executable Output";
            // 
            // browseButton2
            // 
            browseButton2.FlatAppearance.BorderColor = Color.White;
            browseButton2.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            browseButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            browseButton2.FlatStyle = FlatStyle.Flat;
            browseButton2.Location = new Point(761, 170);
            browseButton2.Name = "browseButton2";
            browseButton2.Size = new Size(27, 23);
            browseButton2.TabIndex = 5;
            browseButton2.Text = "...";
            browseButton2.UseVisualStyleBackColor = true;
            browseButton2.Click += browseButton2_Click;
            // 
            // fileOutput
            // 
            fileOutput.BackColor = Color.Black;
            fileOutput.BorderStyle = BorderStyle.FixedSingle;
            fileOutput.ForeColor = Color.White;
            fileOutput.Location = new Point(12, 170);
            fileOutput.Name = "fileOutput";
            fileOutput.Size = new Size(743, 23);
            fileOutput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 203);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 7;
            label3.Text = "Compression Level";
            // 
            // folderBrowser
            // 
            folderBrowser.ShowNewFolderButton = false;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "exe";
            saveFileDialog.Filter = "Executable Files|*.exe";
            // 
            // compressionLevel
            // 
            compressionLevel.BackColor = Color.Black;
            compressionLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            compressionLevel.FlatStyle = FlatStyle.Flat;
            compressionLevel.ForeColor = Color.White;
            compressionLevel.FormattingEnabled = true;
            compressionLevel.Items.AddRange(new object[] { "0 - Store", "1 - Fastest", "3 - Fast", "5 - Normal", "7 - Maximum", "9 - Ultra" });
            compressionLevel.Location = new Point(12, 221);
            compressionLevel.Name = "compressionLevel";
            compressionLevel.Size = new Size(121, 23);
            compressionLevel.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "File to Execute";
            // 
            // executeFile
            // 
            executeFile.BackColor = Color.Black;
            executeFile.Enabled = false;
            executeFile.FlatStyle = FlatStyle.Flat;
            executeFile.ForeColor = Color.White;
            executeFile.FormattingEnabled = true;
            executeFile.Location = new Point(12, 120);
            executeFile.Name = "executeFile";
            executeFile.Size = new Size(776, 23);
            executeFile.TabIndex = 3;
            // 
            // preExeMessage
            // 
            preExeMessage.BackColor = Color.Black;
            preExeMessage.BorderStyle = BorderStyle.FixedSingle;
            preExeMessage.ForeColor = Color.White;
            preExeMessage.Location = new Point(139, 221);
            preExeMessage.Name = "preExeMessage";
            preExeMessage.Size = new Size(649, 23);
            preExeMessage.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 203);
            label5.Name = "label5";
            label5.Size = new Size(209, 15);
            label5.TabIndex = 11;
            label5.Text = "Pre-Execute Question (blank for none)";
            // 
            // startButton
            // 
            startButton.FlatAppearance.BorderColor = Color.White;
            startButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            startButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Location = new Point(12, 250);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 8;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(20, 20, 20);
            progressBar.Location = new Point(93, 250);
            progressBar.Maximum = 4;
            progressBar.Name = "progressBar";
            progressBar.ShowText = false;
            progressBar.Size = new Size(695, 23);
            progressBar.TabIndex = 15;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.settings;
            button1.Location = new Point(747, 12);
            button1.Name = "button1";
            button1.Size = new Size(41, 37);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 285);
            Controls.Add(button1);
            Controls.Add(progressBar);
            Controls.Add(startButton);
            Controls.Add(preExeMessage);
            Controls.Add(label5);
            Controls.Add(executeFile);
            Controls.Add(label4);
            Controls.Add(compressionLevel);
            Controls.Add(label3);
            Controls.Add(browseButton2);
            Controls.Add(fileOutput);
            Controls.Add(label2);
            Controls.Add(browseButton1);
            Controls.Add(conversionFolder);
            Controls.Add(label1);
            Controls.Add(info);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreatorForm";
            ShowIcon = false;
            Text = "Portable Executable Creator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox info;
        private Label label1;
        private TextBox conversionFolder;
        private Button browseButton1;
        private Label label2;
        private Button browseButton2;
        private TextBox fileOutput;
        private Label label3;
        private FolderBrowserDialog folderBrowser;
        private SaveFileDialog saveFileDialog;
        private ComboBox compressionLevel;
        private Label label4;
        private ComboBox executeFile;
        private TextBox preExeMessage;
        private Label label5;
        private Button startButton;
        private BetterProgressBar progressBar;
        private Button button1;
    }
}