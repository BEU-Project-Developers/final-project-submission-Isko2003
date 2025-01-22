using AttendanceSystem;
using MySql.Data.MySqlClient;

namespace Login
{
	public partial class Form1 : Form
	{
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("E-poçt və ya şifrə boş ola bilməz.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT password FROM users WHERE email = @Email";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                string hashedPassword = reader.GetString("password");

                                
                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    MessageBox.Show("Giriş uğurludur!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form2 mainForm = new Form2();
                                    mainForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Şifrə yanlışdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bu e-poçt qeydiyyatda yoxdur.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Xəta baş verdi: {ex.Message}", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 72);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Your Email";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 115);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Your Password";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 168);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 118);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password:";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.BackColor = SystemColors.Window;
            lblHeader.Font = new Font("Arial", 17F, FontStyle.Bold);
            lblHeader.Location = new Point(150, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(84, 27);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "LOGIN";
            // 
            // Form1
            // 
            BackgroundImage = Properties.Resources.nvidia_logo_3840x2160_19422;
            ClientSize = new Size(400, 220);
            Controls.Add(lblHeader);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblHeader;
    }
}
