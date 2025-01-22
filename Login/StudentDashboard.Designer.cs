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

        private void InitializeComponent()
        {
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblAttendanceStatus = new System.Windows.Forms.Label();
            this.lblAttendanceDate = new System.Windows.Forms.Label();
            this.dgvStudentData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).BeginInit();
            this.SuspendLayout();

            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(30, 30);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(80, 13);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Tələbə Adı: ";

            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(30, 60);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(56, 13);
            this.lblStudentId.TabIndex = 1;
            this.lblStudentId.Text = "Tələbə ID:";

            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(30, 90);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(39, 13);
            this.lblCourse.TabIndex = 2;
            this.lblCourse.Text = "Kurs: ";

            // 
            // lblAttendanceStatus
            // 
            this.lblAttendanceStatus.AutoSize = true;
            this.lblAttendanceStatus.Location = new System.Drawing.Point(30, 120);
            this.lblAttendanceStatus.Name = "lblAttendanceStatus";
            this.lblAttendanceStatus.Size = new System.Drawing.Size(81, 13);
            this.lblAttendanceStatus.TabIndex = 3;
            this.lblAttendanceStatus.Text = "Devamiyyət: ";

            // 
            // lblAttendanceDate
            // 
            this.lblAttendanceDate.AutoSize = true;
            this.lblAttendanceDate.Location = new System.Drawing.Point(30, 150);
            this.lblAttendanceDate.Name = "lblAttendanceDate";
            this.lblAttendanceDate.Size = new System.Drawing.Size(89, 13);
            this.lblAttendanceDate.TabIndex = 4;
            this.lblAttendanceDate.Text = "Devamiyyət Tarixi:";

            // 
            // dgvStudentData
            // 
            this.dgvStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData.Location = new System.Drawing.Point(30, 180);
            this.dgvStudentData.Name = "dgvStudentData";
            this.dgvStudentData.Size = new System.Drawing.Size(800, 250);
            this.dgvStudentData.TabIndex = 5;

            // 
            // StudentDashboard
            // 
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.dgvStudentData);
            this.Controls.Add(this.lblAttendanceDate);
            this.Controls.Add(this.lblAttendanceStatus);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblStudentName);
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tələbə Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblAttendanceStatus;
        private System.Windows.Forms.Label lblAttendanceDate;
        private System.Windows.Forms.DataGridView dgvStudentData;

        #endregion
    }
}