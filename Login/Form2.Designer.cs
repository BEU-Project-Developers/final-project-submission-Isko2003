namespace AttendanceSystem
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
            lblTitle = new Label();
            txtStudentName = new TextBox();
            cmbAttendanceStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            AttendanceStatus = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            button1 = new Button();
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
            txtStudentName.Text = "Ismayil";
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
            dateTimePicker1.Location = new Point(50, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.CadetBlue;
            btnAdd.Location = new Point(50, 190);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Əlavə Et";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Chartreuse;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentName, AttendanceStatus, Date });
            dataGridView1.Location = new Point(338, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(450, 150);
            dataGridView1.TabIndex = 5;
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
            // Date
            // 
            Date.HeaderText = "Tarix";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(338, 200);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(200, 30);
            button1.TabIndex = 6;
            button1.Text = "Axtarışa Keçid Et";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            BackgroundImage = Login.Properties.Resources.nvidia_logo_3840x2160_19422;
            ClientSize = new Size(800, 250);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbAttendanceStatus);
            Controls.Add(txtStudentName);
            Controls.Add(lblTitle);
            Name = "Form2";
            Text = "Tələbə İştirak Sistemi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ComboBox cmbAttendanceStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Button button1;
    }
}
