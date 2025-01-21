namespace Login
{
    partial class Form3
    {
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

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnSearch = new Button();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            studentId = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            AttendanceStatus = new DataGridViewTextBoxColumn();
            attendanceDate = new DataGridViewTextBoxColumn();
            Course = new DataGridViewTextBoxColumn();
            button2 = new Button();
            btnShowAllStudents = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.ForeColor = SystemColors.ActiveCaptionText;
            textBox1.Location = new Point(85, 85);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "\u007fEnter student name";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkOrange;
            btnSearch.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSearch.ForeColor = SystemColors.MenuText;
            btnSearch.Location = new Point(116, 150);
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(319, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 24);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Tələbə Axtarış Səhifəsi";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Chartreuse;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentId, StudentName, AttendanceStatus, attendanceDate, Course });
            dataGridView1.Location = new Point(297, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 44;
            dataGridView1.Size = new Size(573, 150);
            dataGridView1.TabIndex = 3;
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
            StudentName.Name = "StudentName";
            // 
            // AttendanceStatus
            // 
            AttendanceStatus.HeaderText = "İştirak Statusu";
            AttendanceStatus.Name = "AttendanceStatus";
            AttendanceStatus.Width = 120;
            // 
            // attendanceDate
            // 
            attendanceDate.HeaderText = "Tarix";
            attendanceDate.Name = "attendanceDate";
            // 
            // Course
            // 
            Course.HeaderText = "Course";
            Course.Name = "Course";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.ForeColor = SystemColors.MenuText;
            button2.Location = new Point(348, 259);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(168, 30);
            button2.TabIndex = 4;
            button2.Text = "Tələbə Əlavə Et Formu";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnShowAllStudents
            // 
            btnShowAllStudents.BackColor = Color.Fuchsia;
            btnShowAllStudents.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnShowAllStudents.ForeColor = SystemColors.MenuText;
            btnShowAllStudents.Location = new Point(102, 222);
            btnShowAllStudents.Margin = new Padding(0);
            btnShowAllStudents.Name = "btnShowAllStudents";
            btnShowAllStudents.Size = new Size(130, 30);
            btnShowAllStudents.TabIndex = 5;
            btnShowAllStudents.Text = "Show All Students";
            btnShowAllStudents.UseVisualStyleBackColor = false;
            btnShowAllStudents.Click += btnShowAllStudents_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.programmer_quotes_3840x2160_10707;
            ClientSize = new Size(882, 450);
            Controls.Add(btnShowAllStudents);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSearch;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn AttendanceStatus;
        private DataGridViewTextBoxColumn attendanceDate;
        private DataGridViewTextBoxColumn Course;
        private Button btnShowAllStudents;
    }
}