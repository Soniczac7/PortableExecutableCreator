using System.Diagnostics;
using System.Reflection;

namespace PortableExecutable
{
    public partial class CreatorForm : Form
    {
        public CreatorForm()
        {
            InitializeComponent();
            compressionLevel.SelectedIndex = 0;
        }

        private void browseButton1_Click(object sender, EventArgs e)
        {
            // Start folderBrowser and fill in result
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                conversionFolder.Text = folderBrowser.SelectedPath;
            }
        }

        private void conversionFolder_TextChanged(object sender, EventArgs e)
        {
            // Check if the folder exists, then enable and fill executeFile
            if (Directory.Exists(conversionFolder.Text))
            {
                executeFile.Items.Clear();
                string[] files = Directory.GetFiles(conversionFolder.Text, "*", SearchOption.TopDirectoryOnly);

                // Loop through each file
                foreach (string file in files)
                {
                    if (file.EndsWith(".exe"))
                    {
                        executeFile.Items.Add(file);
                    }
                    Application.DoEvents();
                }

                executeFile.Enabled = true;
            }
            else
            {
                executeFile.Enabled = false;
                executeFile.Text = "";
            }
        }

        private void browseButton2_Click(object sender, EventArgs e)
        {
            // Start saveFileDialog and fill in result
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileOutput.Text = saveFileDialog.FileName;
            }
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            // Set progress bar to marquee
            progressBar.Style = ProgressBarStyle.Marquee;

            // Disable elements
            SetActive(false);

            // Ensure 7-Zip is installed
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\7-Zip\\7z.exe"))
            {
                progressBar.Style = ProgressBarStyle.Blocks;
                MessageBox.Show("7-Zip is not installed!\nEnsure 7-Zip is installed in your Program Files directory and try again.", "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                return;
            }

            // Validate input
            if (conversionFolder.Text == "" || conversionFolder.Text == " ")
            {
                MessageBox.Show("Folder to convert is blank. Input a folder to convert.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                progressBar.Style = ProgressBarStyle.Blocks;
                return;
            }

            if (executeFile.Text == "" || executeFile.Text == " ")
            {
                MessageBox.Show("File to execute is blank. Input a file to execute.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                progressBar.Style = ProgressBarStyle.Blocks;
                return;
            }

            if (fileOutput.Text == "" || fileOutput.Text == " ")
            {
                MessageBox.Show("Output file is blank. Input a file output location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                progressBar.Style = ProgressBarStyle.Blocks;
                return;
            }

            CompressionLevel? level = null;

            // Convert int to CompressionLevel
            if (compressionLevel.SelectedIndex == 0)
            {
                level = CompressionLevel.Store;
            }
            else if (compressionLevel.SelectedIndex == 1)
            {
                level = CompressionLevel.Fastest;
            }
            else if (compressionLevel.SelectedIndex == 2)
            {
                level = CompressionLevel.Fast;
            }
            else if (compressionLevel.SelectedIndex == 3)
            {
                level = CompressionLevel.Normal;
            }
            else if (compressionLevel.SelectedIndex == 4)
            {
                level = CompressionLevel.Maximum;
            }
            else if (compressionLevel.SelectedIndex == 5)
            {
                level = CompressionLevel.Ultra;
            }

            if (level == null)
            {
                MessageBox.Show("Invalid CompressionLevel.", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                progressBar.Style = ProgressBarStyle.Blocks;
                return;
            }

            progressBar.Value = 0;
            progressBar.Style = ProgressBarStyle.Blocks;

            // Setup
            string executeFileName = Path.GetFileName(executeFile.Text);
            string compiledFileName = Path.GetFileName(fileOutput.Text);
            string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Create config.txt
            string[] configContents;

            if (preExeMessage.Text != "")
            {
                configContents = new string[]
                {
                    ";!@Install@!UTF-8!",
                    "Title=\"Portable Executable\"",
                    $"BeginPrompt=\"{preExeMessage.Text}\"",
                    $"RunProgram=\"{executeFileName}\"",
                    ";!@InstallEnd@!"
                };
            }
            else
            {
                configContents = new string[]
                {
                    ";!@Install@!UTF-8!",
                    "Title=\"Portable Executable\"",
                    $"RunProgram=\"{executeFileName}\"",
                    ";!@InstallEnd@!"
                };
            }


            try
            {
                FileStream fs = File.Create(Path.GetTempPath() + "config.txt");
                fs.Close();
                await File.WriteAllLinesAsync(Path.GetTempPath() + "config.txt", configContents);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create configuration file:\n" + ex.Message + " (" + ex.GetType().FullName + ")" + Environment.NewLine + ex.StackTrace, "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                progressBar.Value = 0;
                return;
            }

            progressBar.Value = 1;

            try
            {
                File.Delete(Path.GetTempPath() + "temp.7z");
            }
            catch { }

            // Create archive
            ProcessStartInfo createArchiveInfo = new ProcessStartInfo();
            createArchiveInfo.FileName = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\7-Zip\7z.exe";
            createArchiveInfo.Arguments = $"a -mx{((int?)level)} {Path.GetTempPath()}temp.7z \"{conversionFolder.Text}\\*\"";
            createArchiveInfo.UseShellExecute = false;
            createArchiveInfo.CreateNoWindow = true;
            createArchiveInfo.ErrorDialog = true;
            Process createArchive = new Process();
            createArchive.StartInfo = createArchiveInfo;
            createArchive.Start();
            await createArchive.WaitForExitAsync();

            if (createArchive.ExitCode != 0)
            {
                MessageBox.Show($"Received an ExitCode of {createArchive.ExitCode} and expected an ExitCode of 0!", "Error Creating Archive", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetActive(true);
                progressBar.Value = 0;
                return;
            }

            progressBar.Value = 2;

            try
            {
                File.Delete(Path.GetTempPath() + "\\7zS.sfx");
            }
            catch { }
            File.Copy(assemblyPath + "\\7zS.sfx", Path.GetTempPath() + "\\7zS.sfx");

            // Compile Executable
            string[] fileNames = new string[]
            {
                Path.GetTempPath() + @"\7zS.sfx",
                Path.GetTempPath() + @"\config.txt",
                Path.GetTempPath() + @"\temp.7z"
            };

            CompileExecutable(fileNames, Path.GetTempPath() + @"\" + compiledFileName);

            File.Move(Path.GetTempPath() + @"\" + compiledFileName, fileOutput.Text);


            progressBar.Value = 3;

            // Delete temporary files
            try
            {
                File.Delete(Path.GetTempPath() + "\\temp.7z");
            }
            catch { }

            try
            {
                File.Delete(Path.GetTempPath() + "\\config.txt");
            }
            catch { }

            try
            {
                File.Delete(Path.GetTempPath() + "\\7zS.sfx");
            }
            catch { }

            progressBar.Value = 4;

            MessageBox.Show("Finished making portable executable.", "Compile Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SetActive(true);
        }

        private static void CompileExecutable(string[] inputFilePaths, string outputFilePath)
        {
            Console.WriteLine("Number of files: {0}.", inputFilePaths.Length);
            using (var outputStream = File.Create(outputFilePath))
            {
                foreach (var inputFilePath in inputFilePaths)
                {
                    using (var inputStream = File.OpenRead(inputFilePath))
                    {
                        // Buffer size can be passed as the second argument.
                        inputStream.CopyTo(outputStream);
                    }
                    Console.WriteLine("The file {0} has been processed.", inputFilePath);
                }
            }
        }

        internal enum CompressionLevel
        {
            Store = 0,
            Fastest = 1,
            Fast = 3,
            Normal = 5,
            Maximum = 7,
            Ultra = 9
        }

        internal void SetActive(bool active)
        {
            if (active == true)
            {
                browseButton1.Enabled = true;
                browseButton2.Enabled = true;
                conversionFolder.Enabled = true;
                executeFile.Enabled = true;
                fileOutput.Enabled = true;
                compressionLevel.Enabled = true;
                preExeMessage.Enabled = true;
                startButton.Enabled = true;
            }
            else
            {
                browseButton1.Enabled = false;
                browseButton2.Enabled = false;
                conversionFolder.Enabled = false;
                executeFile.Enabled = false;
                fileOutput.Enabled = false;
                compressionLevel.Enabled = false;
                preExeMessage.Enabled = false;
                startButton.Enabled = false;
            }
        }
    }
}