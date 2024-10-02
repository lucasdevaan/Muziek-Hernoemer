namespace Music_Renamer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string selectedFolderPath = folderDialog.SelectedPath;
                    folderTextBox.Text = selectedFolderPath;

                    string[] musicFiles = Directory.GetFiles(selectedFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                                   .Where(file => file.EndsWith(".mp3") || file.EndsWith(".wav") || file.EndsWith(".flac"))
                                                   .ToArray();

                    if (musicFiles.Length > 0)
                    {
                        outputTextBox.SelectionColor = System.Drawing.Color.Green;
                        outputTextBox.AppendText("Gereed: ");
                        outputTextBox.SelectionColor = System.Drawing.Color.Black;
                        outputTextBox.AppendText("Muziek correct geladen. Druk op start..." + Environment.NewLine);
                        startButton.Enabled = true;
                    }
                    else
                    {
                        outputTextBox.SelectionColor = System.Drawing.Color.Red;
                        outputTextBox.AppendText("Fout: ");
                        outputTextBox.SelectionColor = System.Drawing.Color.Black;
                        outputTextBox.AppendText("Er zit geen muziek in deze map. " +
                            "Selecteer alsjeblieft een map met .mp3, .wav of .flac bestanden." + Environment.NewLine);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            string selectedFolderPath = folderTextBox.Text;

            string[] musicFiles = Directory.GetFiles(selectedFolderPath, "*.*", SearchOption.TopDirectoryOnly)
                                   .Where(file => file.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) ||
                                                  file.EndsWith(".wav", StringComparison.OrdinalIgnoreCase) ||
                                                  file.EndsWith(".flac", StringComparison.OrdinalIgnoreCase))
                                   .ToArray();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = musicFiles.Length * 20;
            progressBar1.Value = 0;

            foreach (string filePath in musicFiles)
            {
                try
                {
                    var file = TagLib.File.Create(filePath);
                    string newFileName = file.Tag.Title + Path.GetExtension(filePath);

                    if (!string.IsNullOrWhiteSpace(newFileName))
                    {
                        string newFilePath = Path.Combine(selectedFolderPath, newFileName);
                        File.Move(filePath, newFilePath);
                        outputTextBox.SelectionColor = System.Drawing.Color.Green;
                        outputTextBox.AppendText("Naam gewijzigd: ");
                        outputTextBox.SelectionColor = System.Drawing.Color.Black;
                        outputTextBox.AppendText($"{Path.GetFileName(filePath)} to {newFileName}" + Environment.NewLine);
                    }
                    else
                    {
                        outputTextBox.SelectionColor = System.Drawing.Color.Red;
                        outputTextBox.AppendText("Fout: ");
                        outputTextBox.SelectionColor = System.Drawing.Color.Black;
                        outputTextBox.AppendText($"{Path.GetFileName(filePath)} bestand heeft geen metadata." + Environment.NewLine);
                    }
                }
                catch (Exception ex)
                {
                    outputTextBox.SelectionColor = System.Drawing.Color.Red;
                    outputTextBox.AppendText($"Fout bij naam wijzigen van {Path.GetFileName(filePath)}: {ex.Message}" + Environment.NewLine);
                }

                for (int i = 0; i < 20; i++)
                {
                    if (progressBar1.Value < progressBar1.Maximum)
                    {
                        progressBar1.Value += 1;
                    }

                    await Task.Delay(1);
                }
            }

            if (progressBar1.Value == progressBar1.Maximum)
            {
                outputTextBox.AppendText("Klaar!" + Environment.NewLine);
                button2.Enabled = true; // Enable reset button
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            folderTextBox.Clear();
            outputTextBox.Clear();

            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}