﻿namespace AttendanceSystem
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lblTitle = new Label();
            txtStudentName = new TextBox();
            cmbAttendanceStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            studentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            AttendanceStatus = new DataGridViewTextBoxColumn();
            attendanceDate = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            cmbCourse = new ComboBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(112, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tələbə İştirak Sistemi";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(50, 70);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.PlaceholderText = "Tələbə Adı";
            txtStudentName.Size = new Size(200, 23);
            txtStudentName.TabIndex = 1;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // cmbAttendanceStatus
            // 
            cmbAttendanceStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAttendanceStatus.FormattingEnabled = true;
            cmbAttendanceStatus.Items.AddRange(new object[] { "Gecikib", "Hazırdır", "Yoxdur" });
            cmbAttendanceStatus.Location = new Point(50, 110);
            cmbAttendanceStatus.Name = "cmbAttendanceStatus";
            cmbAttendanceStatus.Size = new Size(200, 23);
            cmbAttendanceStatus.Sorted = true;
            cmbAttendanceStatus.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(50, 236);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Əlavə Et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(338, 236);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 6;
            button1.Text = "Axtarışa Keçid Et";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Olive;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentId, StudentName, AttendanceStatus, attendanceDate, Course });
            dataGridView1.Location = new Point(268, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 44;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(628, 150);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // studentId
            // 
            studentId.HeaderText = "studentId";
            studentId.Name = "studentId";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Tələbə Adı";
            StudentName.MinimumWidth = 6;
            StudentName.Name = "StudentName";
            StudentName.Width = 125;
            // 
            // AttendanceStatus
            // 
            AttendanceStatus.HeaderText = "İştirak Statusu";
            AttendanceStatus.MinimumWidth = 6;
            AttendanceStatus.Name = "AttendanceStatus";
            AttendanceStatus.Width = 125;
            // 
            // attendanceDate
            // 
            attendanceDate.HeaderText = "Tarix";
            attendanceDate.MinimumWidth = 6;
            attendanceDate.Name = "attendanceDate";
            attendanceDate.Width = 125;
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.Name = "Course";
            // 
            // cmbCourse
            // 
            cmbCourse.AccessibleName = "";
            cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Items.AddRange(new object[] { "Computer Science", "Information and Technologies", "Math", "Science" });
            cmbCourse.Location = new Point(50, 200);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(200, 23);
            cmbCourse.Sorted = true;
            cmbCourse.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Yellow;
            btnUpdate.Location = new Point(50, 287);
            btnUpdate.Margin = new Padding(0);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 30);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Yenilə";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(50, 337);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 30);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form2
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 376);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(cmbCourse);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbAttendanceStatus);
            Controls.Add(txtStudentName);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Tələbə İştirak Sistemi";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox cmbCourse;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn AttendanceStatus;
        private DataGridViewTextBoxColumn attendanceDate;
        private DataGridViewTextBoxColumn Course;
        private Button btnDelete;
    }
}