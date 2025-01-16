using MySql.Data.MySqlClient;

namespace Login
{
	public partial class Form1 : Form
	{
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			string password = txtPassword.Text;

			MessageBox.Show("Name: " + name + ", Password: " + password);

			string connectionString = "Server=localhost;Database=login;Uid=root;Pwd=;";

			using (MySqlConnection connection = new MySqlConnection(connectionString))
			{
				try
				{
					connection.Open();

					string query = "SELECT COUNT(*) FROM users WHERE name = @Name AND password = @Password";
					MySqlCommand cmd = new MySqlCommand(query, connection);
					cmd.Parameters.AddWithValue("@Name", name);
					cmd.Parameters.AddWithValue("@Password", password);

					int count = Convert.ToInt32(cmd.ExecuteScalar());

					MessageBox.Show("Count: " + count);

					if (count > 0)
					{
						MessageBox.Show("Login Successful!");
					}
					else
					{
						MessageBox.Show("Invalid name or password!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblName = new Label();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 0;
            txtName.Text = "Ismayil";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "ismail2003";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(150, 144);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(81, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(50, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // Form1
            // 
            BackgroundImage = Properties.Resources.nvidia_logo_3840x2160_19422;
            ClientSize = new Size(400, 200);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtName;
		private TextBox txtPassword;
		private Button btnLogin;
		private Label lblName;
		private Label lblPassword;
    }
}
