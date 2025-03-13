using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WooPharmacyPOS
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=KENSHIN;Initial Catalog=WooPharmacyDB;Integrated Security=True"; // server name: KENSHIN
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            RegisterCashier  registerForm = new RegisterCashier();
            registerForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = HASHBYTES('SHA2_256', @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int userExists = (int)cmd.ExecuteScalar();
                    if (userExists > 0)
                    {
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Dashboard dashboard = new Dashboard(); // New Dashboard Form
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
