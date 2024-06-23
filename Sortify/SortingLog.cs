using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sortify
{
    public partial class SortingLog : Form
    {
        private Point startPoint;
        private bool drag;

        string directoryPath;
        List<string> directoryFiles;

        Dictionary<string, List<string>> directoryExtensions = new Dictionary<string, List<string>>
            {
                 { "Video", new List<string>
                     { ".mp4", ".mov", ".avi", ".mkv", ".wmv", ".3gp", ".3g2",
                       ".mpg", ".mpeg", ".m4v", ".h264", ".flv", ".rm", ".swf", ".vob",
                       ".mpe", ".mpv", ".mp2", ".m2v", ".ogv", ".qt", ".asf", ".avchd" } },

                 { "Audio", new List<string>
                     { ".mp3", ".wav", ".ogg", ".flac", ".aif", ".mid", ".midi",
                       ".mpa", ".wma", ".wpl", ".cda", ".aac", ".m4a", ".m3u",
                       ".pls", ".wv", ".aiff", ".ra", ".ram", ".mka", ".opus" } },

                 { "Image", new List<string>
                     { ".jpg", ".png", ".bmp", ".ai", ".psd", ".ico", ".jpeg",
                       ".ps", ".svg", ".tif", ".tiff", ".gif", ".eps",
                       ".raw", ".cr2", ".nef", ".orf", ".sr2", ".webp", ".heic",
                       ".dng", ".arw", ".rw2", ".rwl", ".raf" } },

                 { "Document", new List<string>
                     { ".pdf", ".txt", ".doc", ".docx", ".rtf", ".tex", ".wpd",
                       ".odt", ".md", ".wps", ".dot", ".dotx", ".pptx", ".ppt",
                       ".pps", ".key", ".odp", ".ppsx", ".potx", ".pot", ".pptm", ".ppsm" } },

                 { "Code_Data", new List<string>
                     { ".py", ".js", ".html", ".json", ".java", ".cpp", ".css",
                       ".php", ".cs", ".rb", ".pl", ".sh", ".swift", ".vb", ".r", ".go",
                       ".sql", ".sqlite", ".sqlite3", ".csv", ".dat", ".db", ".log",
                       ".mdb", ".sav", ".tar", ".xml", ".xlsx", ".xls", ".xlsm", ".ods",
                       ".json", ".dbf", ".tab", ".tsv", ".parquet", ".h5", ".hdf5",
                       ".feather", ".dta", ".sav", ".zsav", ".por" } },

                 { "Archive", new List<string>
                     { ".zip", ".rar", ".7z", ".z", ".gz", ".rpm", ".arj", ".pkg", ".jar",
                       ".deb", ".tar.gz", ".tar.bz2", ".iso", ".img", ".dmg", ".xz",
                       ".tgz", ".tbz2", ".txz", ".lz", ".tlz", ".s7z", ".cab", ".lha" } },

                 { "Installer", new List<string>
                     { ".torrent", ".msi", ".exe", ".deb", ".rpm", ".dmg", ".pkg", ".bin", ".apk", ".ipa" } }
            };

        public SortingLog()
        {
            InitializeComponent();
            startPoint = new Point(0, 0);
        }
        private void SortingLog_Load(object sender, EventArgs e)
        {
            TimerLoadForm.Start();
        }
        private void TimerLoadForm_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1 )
            {
                TimerLoadForm.Stop();
            }
        }
        private void SortingLog_Shown(object sender, EventArgs e)
        {
            ProcessSorting();
        }

        //
        //  Top panel
        //

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point position = PointToScreen(e.Location);
                this.Location = new Point(position.X - startPoint.X, position.Y - startPoint.Y);
            }
        }
        private void TopPanelCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TopPanelHideButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //
        //  Sorting
        //

        public string GetUserDirectoryPath()
        {
            if (sortingLogTextBox.Text != "")
            {
                sortingLogTextBox.AppendText(Environment.NewLine);
            }
            sortingLogTextBox.AppendText("# Select folder in opening window dialog" + Environment.NewLine);
            string path = "";
            var ofd = new FolderBrowserDialog
            {
                SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\"
            };

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                sortingLogTextBox.AppendText($"Error opening a dialog window" + Environment.NewLine
                    + ex + Environment.NewLine);
            }
            if (!Directory.Exists(path))
            {
                if (string.IsNullOrEmpty(path))
                {
                    sortingLogTextBox.ForeColor = Color.Orange;
                    sortingLogTextBox.AppendText("# Path is not selected" + Environment.NewLine);
                    sortingLogTextBox.ForeColor = Color.FromArgb(125, 137, 149);
                    return string.Empty;
                }
                else
                {
                    sortingLogTextBox.AppendText("# Path is not correct" + Environment.NewLine);
                }
                return GetUserDirectoryPath();
            }
            else
            {
                sortingLogTextBox.AppendText("# Path received successfully" + Environment.NewLine);
                sortingLogTextBox.AppendText($"~ Path: {path}" + Environment.NewLine);
                sortingLogTextBox.AppendText("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + Environment.NewLine);
            }
            return path;
        }
        public List<string> GetFilesInDirectory(string directoryPath)
        {
            List<string> directoryFiles = new List<string>();
            List<string> filesPathInDirectory = new List<string>(Directory.GetFiles(directoryPath));
            try
            {
                foreach (string file in filesPathInDirectory)
                {
                    if (File.Exists(file) && (Path.GetFileName(file) != "desktop.ini"))
                    {
                        directoryFiles.Add(Path.GetFileName(file));
                    }
                }
            }
            catch (Exception ex)
            {
                sortingLogTextBox.AppendText($"# File enumeration error" + ex.Message + Environment.NewLine);
                sortingLogTextBox.AppendText("~ Reselect directory ~" + Environment.NewLine);
                ProcessSorting();
            }

            if (directoryFiles.Count == 0)
            {
                sortingLogTextBox.AppendText("# Current directory is empty. . ." + Environment.NewLine);
                sortingLogTextBox.AppendText("~ Reselect directory ~" + Environment.NewLine);
                ProcessSorting();
            }
            else
            {
                ProgressBar.Increment(10);
            }
            return directoryFiles;
        }
        public void CreateDirectories(List<string> directoryFiles, Dictionary<string, List<string>> directoryExtensions, string directoryPath)
        {
            bool borderOut = false;
            foreach (string file in directoryFiles)
            {
                string extentionFile = Path.GetExtension(file);
                bool categoryForFileFind = false;
                foreach (var category in directoryExtensions)
                {
                    try
                    {
                        if (category.Value.Contains(extentionFile))
                        {
                            string newDirectory = Path.Combine(directoryPath, category.Key);
                            if (!Directory.Exists(newDirectory))
                            {
                                borderOut = true;
                                Directory.CreateDirectory(newDirectory);
                                sortingLogTextBox.AppendText($"~ create directory -- {category.Key}" + Environment.NewLine);
                            }
                            categoryForFileFind = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        sortingLogTextBox.AppendText($"Error in process creating derictory -- {category.Key}"
                            + Environment.NewLine + ex.Message + Environment.NewLine);
                    }
                }
                if (!categoryForFileFind)
                {
                    try
                    {
                        string newDirectory = Path.Combine(directoryPath, "Other");
                        if (!Directory.Exists(newDirectory))
                        {
                            borderOut = true;
                            Directory.CreateDirectory(newDirectory);
                            sortingLogTextBox.AppendText("~ create directory -- Other" + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        sortingLogTextBox.AppendText($"Error in process creating derictory -- Other"
                            + Environment.NewLine + ex.Message);
                    }
                }
            }
            if (borderOut)
            {
                sortingLogTextBox.AppendText("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + Environment.NewLine);
            }
            ProgressBar.Increment(10);
        }
        public void CategorizeFiles(List<string> directoryFiles, Dictionary<string, List<string>> directoryExtensions, string directoryPath)
        {
            foreach (var file in directoryFiles)
            {
                string extentionFile = Path.GetExtension(file);
                bool fileDirectoryFound = false;
                foreach (var category in directoryExtensions)
                {
                    if (category.Value.Contains(extentionFile))
                    {
                        try
                        {
                            fileDirectoryFound = true;
                            string newLocationFile = Path.Combine(directoryPath, category.Key, file);
                            string currentLocationFile = Path.Combine(directoryPath, file);
                            File.Move(currentLocationFile, newLocationFile);
                            sortingLogTextBox.AppendText($" - file {file} move to {category.Key}" + Environment.NewLine);
                            break;

                        }
                        catch (Exception ex)
                        {
                            sortingLogTextBox.ForeColor = Color.Red;
                            sortingLogTextBox.AppendText($"Error in process moving file -- {file} to {category.Key}"
                                + Environment.NewLine + ex.Message + Environment.NewLine);
                            sortingLogTextBox.ForeColor = Color.FromArgb(125, 137, 149);
                        }
                    }
                }
                if (!fileDirectoryFound)
                {
                    string newLocationFile = Path.Combine(directoryPath, "Other", file);
                    string currentLocationFile = Path.Combine(directoryPath, file);
                    File.Move(currentLocationFile, newLocationFile);
                    sortingLogTextBox.AppendText($" - file {file} move to Other" + Environment.NewLine);
                }
            }
            ProgressBar.Increment(10);
        }
        public void ProcessSorting()
        {
            directoryPath = GetUserDirectoryPath();
            if (string.IsNullOrEmpty(directoryPath))
            {
                this.Close();
                return;
            }
            directoryFiles = GetFilesInDirectory(directoryPath);
            CreateDirectories(directoryFiles, directoryExtensions, directoryPath);
            CategorizeFiles(directoryFiles, directoryExtensions, directoryPath);
        }
    }
}
