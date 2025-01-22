namespace Login
{
    partial class StudentDashboard
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

        private Label lblTitle;
        private Label lblStudentName;
        private Label lblStudentId;
        private Label lblCourse;
        private Label lblAttendanceStatus;
        private Label lblAttendanceDate;
        private DataGridView dgvStudentData;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn AttendanceStatus;
        private DataGridViewTextBoxColumn attendanceDate;
        private DataGridViewTextBoxColumn Course;

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblStudentName = new Label();
            lblStudentId = new Label();
            lblCourse = new Label();
            lblAttendanceStatus = new Label();
            lblAttendanceDate = new Label();
            dgvStudentData = new DataGridView();
            studentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            AttendanceStatus = new DataGridViewTextBoxColumn();
            attendanceDate = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudentData).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(50, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(183, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tələbə Dashboard";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Microsoft Sans Serif", 10F);
            lblStudentName.Location = new Point(50, 60);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(84, 17);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Tələbə Adı: ";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Microsoft Sans Serif", 10F);
            lblStudentId.Location = new Point(50, 90);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(77, 17);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Tələbə ID: ";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Microsoft Sans Serif", 10F);
            lblCourse.Location = new Point(50, 120);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(45, 17);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Kurs: ";
            // 
            // lblAttendanceStatus
            // 
            lblAttendanceStatus.AutoSize = true;
            lblAttendanceStatus.Font = new Font("Microsoft Sans Serif", 10F);
            lblAttendanceStatus.Location = new Point(50, 150);
            lblAttendanceStatus.Name = "lblAttendanceStatus";
            lblAttendanceStatus.Size = new Size(89, 17);
            lblAttendanceStatus.TabIndex = 4;
            lblAttendanceStatus.Text = "Davamiyyət: ";
            // 
            // lblAttendanceDate
            // 
            lblAttendanceDate.AutoSize = true;
            lblAttendanceDate.Font = new Font("Microsoft Sans Serif", 10F);
            lblAttendanceDate.Location = new Point(50, 180);
            lblAttendanceDate.Name = "lblAttendanceDate";
            lblAttendanceDate.Size = new Size(127, 17);
            lblAttendanceDate.TabIndex = 5;
            lblAttendanceDate.Text = "Davamiyyət Tarixi: ";
            // 
            // dgvStudentData
            // 
            dgvStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentData.Columns.AddRange(new DataGridViewColumn[] { studentId, StudentName, AttendanceStatus, attendanceDate, Course });
            dgvStudentData.Location = new Point(50, 220);
            dgvStudentData.Name = "dgvStudentData";
            dgvStudentData.RowTemplate.Height = 30;
            dgvStudentData.Size = new Size(600, 200);
            dgvStudentData.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            studentId.Name = "Tələbə ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            StudentName.Name = "Tələbə Adı";
            // 
            // dataGridViewTextBoxColumn3
            // 
            Course.Name = "Kurs";
            // 
            // dataGridViewTextBoxColumn4
            // 
            AttendanceStatus.Name = "Davamiyyət Statusu";
            // 
            // dataGridViewTextBoxColumn5
            // 
            attendanceDate.Name = "Davamiyyət Tarixi";
            // 
            // StudentDashboard
            // 
            ClientSize = new Size(700, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentId);
            Controls.Add(lblCourse);
            Controls.Add(lblAttendanceStatus);
            Controls.Add(lblAttendanceDate);
            Controls.Add(dgvStudentData);
            Name = "StudentDashboard";
            Text = "Student Dashboard";
            Load += StudentDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}