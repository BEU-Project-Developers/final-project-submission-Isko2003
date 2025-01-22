using MySql.Data.MySqlClient;

namespace Login
{
    partial class RegisterForm
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
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(30, 30);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(65, 15);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Tələbə ID:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(150, 27);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(200, 23);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(30, 70);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "İstifadəçi adı:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(40, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Şifrə:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 150);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(93, 15);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Şifrəni təsdiqlə:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(150, 147);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 23);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(150, 190);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 30);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Qeydiyyat";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentId);
            this.Name = "RegisterForm";
            this.Text = "Tələbə Qeydiyyat Formu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // Qeyri-mümkün məlumatlar üçün yoxlama
            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(username) 
                || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Tələbə ID və adı daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Şifrələr uyğun deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bu mərhələdə əvvəlcə studentId və studentName ilə students cədvəlini yoxlayırıq
            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Tələbənin students cədvəlində mövcudluğunu yoxlamaq üçün SQL sorğusu
                    string query = "SELECT COUNT(*) FROM students WHERE studentId = @StudentId AND studentName = @StudentName";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentId", studentId);
                        command.Parameters.AddWithValue("@StudentName", username);

                        int studentExists = Convert.ToInt32(command.ExecuteScalar());

                        if (studentExists == 0)
                        {
                            MessageBox.Show("Tələbə ID və ya ad düzgün deyil. Zəhmət olmasa düzgün məlumat daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // BCrypt ilə şifrəni hash edirik
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                        // Yeni istifadəçi məlumatlarını login cədvəlinə daxil edirik
                        string insertQuery = "INSERT INTO student_logins (studentId, username, password) VALUES (@StudentId, @StudentName, @Password)";

                        using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@StudentId", studentId);
                            insertCommand.Parameters.AddWithValue("@StudentName", username);
                            insertCommand.Parameters.AddWithValue("@Password", hashedPassword);

                            insertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Qeydiyyat uğurla tamamlandı.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Yeni qeydiyyat tamamlandıqdan sonra login ekranına yönləndiririk
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
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