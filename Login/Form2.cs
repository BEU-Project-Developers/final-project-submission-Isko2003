using Login;
using Login.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace AttendanceSystem
{
    public partial class Form2 : Form
    {
        private List<Student> students = new List<Student>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string status = cmbAttendanceStatus.SelectedItem?.ToString() ?? "Seçilməyib";
            DateTime date = dateTimePicker1.Value;

            var student = new Student
            {
                Name = studentName,
                Status = status,
                Date = date,
            };
            students.Add(student);

            dataGridView1.Rows.Add(studentName, status, date.ToShortDateString());

            txtStudentName.Clear();
            cmbAttendanceStatus.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(students);
            form3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
