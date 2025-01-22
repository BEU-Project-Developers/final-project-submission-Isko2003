using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Login
{
    public partial class StudentDashboard : Form
    {
        private string studentId;

        public StudentDashboard(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // studentId əsasında tələbənin məlumatlarını əldə edirik
                    string query = "SELECT studentId, studentName, attendanceStatus, attendanceDate, course FROM students WHERE studentId = @StudentId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Label-lara məlumatları əlavə edirik
                                lblStudentName.Text = "Tələbə Adı: " + reader.GetString("studentName");
                                lblStudentId.Text = "Tələbə ID: " + reader.GetInt32("studentId");
                                lblCourse.Text = "Kurs: " + reader.GetString("course");
                                lblAttendanceStatus.Text = "Devamiyyət: " + reader.GetString("attendanceStatus");
                                lblAttendanceDate.Text = "Devamiyyət Tarixi: " + reader.GetDateTime("attendanceDate").ToShortDateString();

                                // DataGridView ilə tələbənin bütün məlumatlarını göstəririk
                                dgvStudentData.Rows.Clear();
                                dgvStudentData.Columns.Clear();

                                dgvStudentData.Columns.Add("StudentId", "Tələbə ID");
                                dgvStudentData.Columns.Add("StudentName", "Tələbə Adı");
                                dgvStudentData.Columns.Add("AttendanceStatus", "Devamiyyət");
                                dgvStudentData.Columns.Add("AttendanceDate", "Devamiyyət Tarixi");
                                dgvStudentData.Columns.Add("Course", "Kurs");

                                dgvStudentData.Rows.Add(
                                    reader.GetInt32("studentId"),
                                    reader.GetString("studentName"),
                                    reader.GetString("attendanceStatus"),
                                    reader.GetDateTime("attendanceDate").ToShortDateString(),
                                    reader.GetString("course")
                                );
                            }
                            else
                            {
                                MessageBox.Show("Tələbə məlumatları tapılmadı.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
