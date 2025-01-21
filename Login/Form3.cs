using Login.Models;
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

namespace Login
{
    public partial class Form3 : Form
    {
        public Form3(List<Student> students)
        {
            InitializeComponent();
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

        private void Form3_Load(object sender, EventArgs e)
        {
            btnShowAllStudents.Visible = false;
            LoadStudentsFromDatabase();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Axtarış üçün tələbə adı daxil edin!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();


                    string query = "SELECT * FROM students WHERE studentName LIKE @searchName";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchName", "%" + searchName + "%");

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            dataGridView1.Rows.Clear();
                            bool hasResults = false;
                            btnShowAllStudents.Visible = false;
                            while (reader.Read())
                            {
                                hasResults = true;
                                dataGridView1.Rows.Add(
                                    reader["studentId"],
                                    reader["studentName"],
                                    reader["attendanceStatus"],
                                    Convert.ToDateTime(reader["attendanceDate"]).ToShortDateString(),
                                    reader["course"]
                                );
                            }

                            if (!hasResults)
                            {
                                MessageBox.Show("Axtarışınıza uyğun tələbə tapılmadı.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnShowAllStudents.Visible = true;
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

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            LoadStudentsFromDatabase();
            btnShowAllStudents.Visible = false;
        }
    }
}
