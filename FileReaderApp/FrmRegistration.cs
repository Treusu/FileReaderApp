using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileReaderApp;

namespace TextFileApplication
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string studentNo = txtStudentNo.Text;
                string program = cbProgram.Text;
                string lastName = txtLastName.Text;
                string firstName = txtFirstName.Text;
                string middleInitial = txtMI.Text;
                string age = txtAge.Text;
                string gender = cbGender.Text;
                string birthday = dateBirthday.Value.ToString("yyyy-MM-dd");
                string contactNo = txtContactNo.Text;
                string fullName = $"{lastName}, {firstName}, {middleInitial}";

                string[] registrationData = {
                    $"Student No.: {studentNo}",
                    $"Full Name: {fullName}",
                    $"Program: {program}",
                    $"Gender: {gender}",
                    $"Age: {age}",
                    $"Birthday: {birthday}",
                    $"Contact No.: {contactNo}"
                };

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(docPath, studentNo + ".txt");

                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    foreach (string line in registrationData)
                    {
                        outputFile.WriteLine(line);
                    }
                }

                MessageBox.Show($"Registration saved successfully!\nFile: {studentNo}.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] programs = {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management"
            };

            foreach (string program in programs)
            {
                cbProgram.Items.Add(program);
            }

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Other");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.Show();
        }
    }
}