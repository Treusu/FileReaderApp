namespace FileReaderApp
{
    partial class FrmStudentRecord
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListView listViewRecords;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            listViewRecords = new ListView();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(505, 37);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(92, 34);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnFind
            // 
            btnFind.Font = new Font("Segoe UI", 12F);
            btnFind.Location = new Point(505, 77);
            btnFind.Margin = new Padding(4, 3, 4, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(92, 34);
            btnFind.TabIndex = 2;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI", 12F);
            btnUpload.Location = new Point(505, 117);
            btnUpload.Margin = new Padding(4, 3, 4, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(92, 35);
            btnUpload.TabIndex = 3;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // listViewRecords
            // 
            listViewRecords.Font = new Font("Segoe UI", 12F);
            listViewRecords.Location = new Point(14, 37);
            listViewRecords.Margin = new Padding(4, 3, 4, 3);
            listViewRecords.Name = "listViewRecords";
            listViewRecords.Size = new Size(483, 238);
            listViewRecords.TabIndex = 4;
            listViewRecords.UseCompatibleStateImageBehavior = false;
            listViewRecords.View = View.List;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(14, 10);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "View Record";
            // 
            // FrmStudentRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 290);
            Controls.Add(listViewRecords);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmStudentRecord";
            Text = "Student Records";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}