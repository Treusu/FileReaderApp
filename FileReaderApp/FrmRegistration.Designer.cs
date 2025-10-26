namespace TextFileApplication
{
    partial class FrmRegistration
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
            label2 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtMI = new TextBox();
            label6 = new Label();
            txtAge = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dateBirthday = new DateTimePicker();
            txtContactNo = new TextBox();
            label10 = new Label();
            btnRegister = new Button();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18.75F, FontStyle.Bold);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 35);
            label2.TabIndex = 1;
            label2.Text = "Registration";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Font = new Font("Segoe UI", 12F);
            txtStudentNo.Location = new Point(109, 50);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(210, 29);
            txtStudentNo.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 12F);
            txtLastName.Location = new Point(109, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(210, 29);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 12F);
            txtFirstName.Location = new Point(437, 94);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(210, 29);
            txtFirstName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(340, 97);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 7;
            label4.Text = "First Name";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(354, 53);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 5;
            label5.Text = "Program";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMI
            // 
            txtMI.Font = new Font("Segoe UI", 12F);
            txtMI.Location = new Point(703, 94);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(85, 29);
            txtMI.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(655, 97);
            label6.Name = "label6";
            label6.Size = new Size(34, 21);
            label6.TabIndex = 9;
            label6.Text = "M.I.";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 12F);
            txtAge.Location = new Point(109, 138);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(124, 29);
            txtAge.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(57, 141);
            label7.Name = "label7";
            label7.Size = new Size(37, 21);
            label7.TabIndex = 11;
            label7.Text = "Age";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ImageAlign = ContentAlignment.MiddleRight;
            label8.Location = new Point(354, 144);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 13;
            label8.Text = "Gender";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(22, 197);
            label9.Name = "label9";
            label9.Size = new Size(68, 21);
            label9.TabIndex = 15;
            label9.Text = "Birthday";
            // 
            // dateBirthday
            // 
            dateBirthday.Font = new Font("Segoe UI", 12F);
            dateBirthday.Location = new Point(109, 195);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(270, 29);
            dateBirthday.TabIndex = 16;
            // 
            // txtContactNo
            // 
            txtContactNo.Font = new Font("Segoe UI", 12F);
            txtContactNo.Location = new Point(505, 195);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(210, 29);
            txtContactNo.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(408, 198);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 17;
            label10.Text = "Contact No.";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(338, 260);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 43);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Segoe UI", 12F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Computer Science", "BS Information Systems", "BS in Accountancy", "BS in Hospitality Management" });
            cbProgram.Location = new Point(437, 50);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(351, 29);
            cbProgram.TabIndex = 20;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Segoe UI", 12F);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(437, 141);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(144, 29);
            cbGender.TabIndex = 21;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(655, 260);
            button2.Name = "button2";
            button2.Size = new Size(93, 43);
            button2.TabIndex = 23;
            button2.Text = "Records";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 359);
            Controls.Add(button2);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label10);
            Controls.Add(dateBirthday);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtAge);
            Controls.Add(label7);
            Controls.Add(txtMI);
            Controls.Add(label6);
            Controls.Add(txtFirstName);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtStudentNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label4;
        private Label label5;
        private TextBox txtMI;
        private Label label6;
        private TextBox txtAge;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dateBirthday;
        private TextBox txtContactNo;
        private Label label10;
        private Button btnRegister;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private Button button1;
        private Button button2;
    }
}