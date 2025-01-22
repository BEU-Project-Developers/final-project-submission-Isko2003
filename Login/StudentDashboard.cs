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
        private int _studentId;

        public StudentDashboard(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
        }

        private void LoadStudentData()
        {
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT studentId, studentName, attendanceStatus, attendanceDate, course FROM students WHERE studentId = @StudentId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", _studentId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dgvStudentData.Rows.Clear();
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("studentId");
                                string name = reader.GetString("studentName");
                                string status = reader.GetString("attendanceStatus");
                                DateTime date = reader.GetDateTime("attendanceDate");
                                string course = reader.GetString("course");

                                dgvStudentData.Rows.Add(id, name, status, date.ToShortDateString(), course);
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

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }
    }
}
