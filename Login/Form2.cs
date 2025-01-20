using Login;
using Login.Models;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


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
            string course = cmbCourse.SelectedItem?.ToString() ?? "Seçilməyib";

            if (string.IsNullOrWhiteSpace(studentName) || cmbAttendanceStatus.SelectedIndex == -1 || cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Zəhmət olmasa bütün sahələri doldurun.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO students(studentName, attendanceStatus, attendanceDate, course) " +
                                   "VALUES(@Name, @Status, @Date, @Course); SELECT LAST_INSERT_ID();";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", studentName);
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Course", course);

                        int insertedId = Convert.ToInt32(command.ExecuteScalar());

                        dataGridView1.Rows.Add(insertedId, studentName, status, date.ToShortDateString(), course);
                    }

                    txtStudentName.Clear();
                    cmbAttendanceStatus.SelectedIndex = -1;
                    cmbCourse.SelectedIndex = -1;

                    MessageBox.Show("Tələbə uğurla əlavə edildi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadStudentsFromDatabase()
        {
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT studentId, studentName, attendanceStatus, attendanceDate, course FROM students";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("studentId");
                            string name = reader.GetString("studentName");
                            string status = reader.GetString("attendanceStatus");
                            DateTime date = reader.GetDateTime("attendanceDate");
                            string course = reader.GetString("course");

                            dataGridView1.Rows.Add(id, name, status, date.ToShortDateString(), course);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xəta Baş Verdi: " + ex.Message);
                }
            }
        }

        private void Form2_Load (object sender, EventArgs e)
        {
            LoadStudentsFromDatabase();
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
