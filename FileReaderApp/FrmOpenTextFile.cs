namespace FileReaderApp
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }
        private void DisplayToList()
        {
            try
            {
                openFileDialog1.InitialDirectory = @"C:\";
                openFileDialog1.Title = "Browse Text Files";
                openFileDialog1.DefaultExt = "txt";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;

                    // Clear existing items in ListView
                    lvShowText.Items.Clear();

                    using (StreamReader streamReader = File.OpenText(path))
                    {
                        string _getText = "";
                        while ((_getText = streamReader.ReadLine()) != null)
                        {
                            Console.WriteLine(_getText);
                            lvShowText.Items.Add(_getText);
                        }
                    }

                    MessageBox.Show("File loaded successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
