using AttendanceSystem;
using MySql.Data.MySqlClient;

namespace Login
{
    partial class LoginForm
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
            lblStudentId = new Label();
            lblPassword = new Label();
            txtStudentId = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(50, 50);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(72, 15);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Tələbə ID-si:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(33, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifrə:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(150, 50);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(200, 23);
            txtStudentId.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 150);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Daxil ol";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtStudentId);
            Controls.Add(lblPassword);
            Controls.Add(lblStudentId);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tələbə Girişi";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentIdInput = txtStudentId.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentIdInput) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tələbə ID və ya şifrəni daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(studentIdInput, out int studentId))
            {
                MessageBox.Show("Tələbə ID yalnız rəqəm olmalıdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT password FROM student_logins WHERE studentId = @StudentId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        object result = command.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Tələbə mövcud deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string storedPasswordHash = result.ToString();

                        if (BCrypt.Net.BCrypt.Verify(password, storedPasswordHash))
                        {
                            MessageBox.Show("Giriş uğurla tamamlandı.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            StudentDashboard studentForm = new StudentDashboard(studentId);
                            studentForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Şifrə yanlışdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion
    }
}