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
            this.info = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.conversionFolder = new System.Windows.Forms.TextBox();
            this.browseButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.browseButton2 = new System.Windows.Forms.Button();
            this.fileOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.compressionLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.executeFile = new System.Windows.Forms.ComboBox();
            this.preExeMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.SystemColors.Control;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Size = new System.Drawing.Size(788, 37);
            this.info.TabIndex = 0;
            this.info.Text = "To create your potable executable, select a folder to convert, select an output d" +
    "irectory and any other options.\nOnce you have finished click \"Start\" and your po" +
    "rtable executable will start creating.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversion Folder";
            // 
            // conversionFolder
            // 
            this.conversionFolder.Location = new System.Drawing.Point(12, 70);
            this.conversionFolder.Name = "conversionFolder";
            this.conversionFolder.Size = new System.Drawing.Size(745, 23);
            this.conversionFolder.TabIndex = 2;
            this.conversionFolder.TextChanged += new System.EventHandler(this.conversionFolder_TextChanged);
            // 
            // browseButton1
            // 
            this.browseButton1.Location = new System.Drawing.Point(763, 69);
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Size = new System.Drawing.Size(25, 23);
            this.browseButton1.TabIndex = 3;
            this.browseButton1.Text = "...";
            this.browseButton1.UseVisualStyleBackColor = true;
            this.browseButton1.Click += new System.EventHandler(this.browseButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Executable Output";
            // 
            // browseButton2
            // 
            this.browseButton2.Location = new System.Drawing.Point(763, 170);
            this.browseButton2.Name = "browseButton2";
            this.browseButton2.Size = new System.Drawing.Size(25, 23);
            this.browseButton2.TabIndex = 6;
            this.browseButton2.Text = "...";
            this.browseButton2.UseVisualStyleBackColor = true;
            this.browseButton2.Click += new System.EventHandler(this.browseButton2_Click);
            // 
            // fileOutput
            // 
            this.fileOutput.Location = new System.Drawing.Point(12, 170);
            this.fileOutput.Name = "fileOutput";
            this.fileOutput.Size = new System.Drawing.Size(745, 23);
            this.fileOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compression Level";
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "exe";
            this.saveFileDialog.Filter = "Executable Files|*.exe";
            // 
            // compressionLevel
            // 
            this.compressionLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compressionLevel.FormattingEnabled = true;
            this.compressionLevel.Items.AddRange(new object[] {
            "0 - Store",
            "1 - Fastest",
            "3 - Fast",
            "5 - Normal",
            "7 - Maximum",
            "9 - Ultra"});
            this.compressionLevel.Location = new System.Drawing.Point(12, 221);
            this.compressionLevel.Name = "compressionLevel";
            this.compressionLevel.Size = new System.Drawing.Size(121, 23);
            this.compressionLevel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "File to Execute";
            // 
            // executeFile
            // 
            this.executeFile.Enabled = false;
            this.executeFile.FormattingEnabled = true;
            this.executeFile.Location = new System.Drawing.Point(12, 120);
            this.executeFile.Name = "executeFile";
            this.executeFile.Size = new System.Drawing.Size(776, 23);
            this.executeFile.TabIndex = 10;
            // 
            // preExeMessage
            // 
            this.preExeMessage.Location = new System.Drawing.Point(139, 221);
            this.preExeMessage.Name = "preExeMessage";
            this.preExeMessage.Size = new System.Drawing.Size(649, 23);
            this.preExeMessage.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pre-Execute Question (blank for none)";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(93, 250);
            this.progressBar.Maximum = 4;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(695, 23);
            this.progressBar.TabIndex = 13;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 250);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.preExeMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.executeFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.compressionLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.browseButton2);
            this.Controls.Add(this.fileOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseButton1);
            this.Controls.Add(this.conversionFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreatorForm";
            this.ShowIcon = false;
            this.Text = "Portable Executable Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ProgressBar progressBar;
        private Button startButton;
    }
}