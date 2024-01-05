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

namespace AMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            input_password.PasswordChar = '*';
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string inputEmail = input_email.Text.Trim();
            string inputPassword = input_password.Text.Trim();

            if (string.IsNullOrEmpty(inputEmail) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter email and password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = $"SELECT COUNT(*), UserID, UserRole FROM users WHERE email = '{inputEmail}' AND password = '{inputPassword}'";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    int count = 0;
                    int userID = 0;
                    string userRole = null;

                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader[0]);
                        userID = Convert.ToInt32(reader[1]);
                        userRole = reader[2].ToString();
                    }

                    reader.Close();

                    if (count > 0)
                    {
                        string userNameQuery = $"SELECT Name FROM Participants WHERE UserID = '{userID}'";
                        MySqlCommand userNameCmd = new MySqlCommand(userNameQuery, connection);
                        string userName = userNameCmd.ExecuteScalar()?.ToString();

                        switch (userRole)
                        {
                            case "Admin":
                                AdminForm adminForm = new AdminForm(userName, userID);
                                this.Hide();
                                adminForm.Show();
                                break;
                            case "Instructor":
                                InstructorForm instructorForm = new InstructorForm(userName, userID);
                                this.Hide();
                                instructorForm.Show();
                                break;
                            case "Participant":
                                ParticipantForm participantForm = new ParticipantForm(userName, userID);
                                this.Hide();
                                participantForm.Show();
                                break;
                            default:
                                MessageBox.Show("Unknown user role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Check_showPass_CheckedChanged_1(object sender, EventArgs e)
        {
            input_password.PasswordChar = Check_showPass.Checked ? '\0' : '*';
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
    public static class DatabaseConnection
    {
        public static MySqlConnection GetConnection()
        {
            string server = "127.0.0.1";
            string database = "AMS";
            string uid = "root";
            string password = "";

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            return new MySqlConnection(connectionString);
        }
    }
}




