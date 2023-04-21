using PortableExecutable.Properties;

namespace PortableExecutable
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            DesktopWindowManager.SetImmersiveDarkMode(this.Handle, true);
            DesktopWindowManager.EnableMicaIfSupported(this.Handle);
            DesktopWindowManager.ExtendFrameIntoClientArea(this.Handle);

            szDirectory.Text = Settings.Default.szDirectory;
        }

        public static bool CheckSZInstallation(string path)
        {
            if (Directory.Exists(path))
            {
                if (File.Exists(path + "\\7z.exe"))
                {
                    return true;
                }
            }
            return false;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (szDirectory.Text != Settings.Default.szDirectory)
            {
                Settings.Default.szDirectory = szDirectory.Text;
            }

            if (!CheckSZInstallation(Settings.Default.szDirectory))
            {
                MessageBox.Show("No 7-Zip installation exists at specified directory.\nEnter a valid 7-Zip installation and try again.", "Setting Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            Settings.Default.Save();
        }

        private void browseButton1_Click(object sender, EventArgs e)
        {
            // Open folder browser dialog
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                // Set the text box to the selected path
                szDirectory.Text = folderBrowser.SelectedPath + @"\";
            }
        }
    }
}
