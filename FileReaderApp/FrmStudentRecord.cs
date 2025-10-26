using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFileApplication;

namespace FileReaderApp
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Go back to FrmRegistration
            this.Hide();
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.Show();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = @"C:\";
                    openFileDialog.Title = "Browse Text Files";
                    openFileDialog.DefaultExt = "txt";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = openFileDialog.FileName;

                        // Clear existing items in ListView
                        listViewRecords.Items.Clear();

                        using (StreamReader streamReader = File.OpenText(path))
                        {
                            string _getText = "";
                            while ((_getText = streamReader.ReadLine()) != null)
                            {
                                Console.WriteLine(_getText);
                                listViewRecords.Items.Add(_getText);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Display success message
            MessageBox.Show("Successfully Uploaded!", "Upload Complete",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the ListView's existing content
            listViewRecords.Items.Clear();
        }
    }
}
