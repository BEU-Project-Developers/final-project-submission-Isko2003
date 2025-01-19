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
            button1 = new Button();
            lblTitle = new Label();
            dataGridView1 = new DataGridView();
            StudentName = new DataGridViewTextBoxColumn();
            AttendanceStatus = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.ForeColor = SystemColors.ActiveCaption;
            textBox1.Location = new Point(85, 85);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "\u007fEnter student name";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.MenuText;
            button1.Location = new Point(118, 172);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentName, AttendanceStatus, Date });
            dataGridView1.Location = new Point(348, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(368, 150);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // StudentName
            // 
            StudentName.HeaderText = "StudentName";
            StudentName.Name = "StudentName";
            // 
            // AttendanceStatus
            // 
            AttendanceStatus.HeaderText = "AttendanceStatus";
            AttendanceStatus.Name = "AttendanceStatus";
            AttendanceStatus.Width = 120;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
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
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.programmer_quotes_3840x2160_10707;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitle);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label lblTitle;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn AttendanceStatus;
        private DataGridViewTextBoxColumn Date;
        private Button button2;
    }
}