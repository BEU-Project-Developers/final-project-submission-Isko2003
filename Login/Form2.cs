using Login;
using System;
using System.Windows.Forms;

namespace AttendanceSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text;
            string status = cmbAttendanceStatus.SelectedItem?.ToString() ?? "Seçilməyib";
            DateTime date = dateTimePicker1.Value;

            dataGridView1.Rows.Add(studentName, status, date.ToShortDateString());

            txtStudentName.Clear();
            cmbAttendanceStatus.SelectedIndex = -1;
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
