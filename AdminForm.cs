﻿using MySql.Data.MySqlClient;
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
    public partial class AdminForm : Form
    {
        private string administratorName;

        private int administratorUserID;

        public AdminForm(string name, int userID)
        {
            InitializeComponent();
            administratorName = name;
            administratorUserID = userID;
            InitializeForm();
            LoadRolesToComboBox();
            LoadDataToGrid_usersList("");
        }

        private void InitializeForm()
        {
            timer1.Start();
            label_hello.Text = "Hello, Admin!";
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            List<string> userRoles = new List<string> { "Participant", "Instructor" };
            comboBoxUserRole.DataSource = userRoles;
            LoadDataToGrid_events();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_currentDate.Text = DateTime.Now.ToLongDateString();

            label_currentTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void Btn_createUser_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string userRole = comboBoxUserRole.SelectedItem?.ToString();

            try
            {
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();
                    
                    string checkExistingUserQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    MySqlCommand checkExistingUserCmd = new MySqlCommand(checkExistingUserQuery, connection);
                    checkExistingUserCmd.Parameters.AddWithValue("@Email", email);

                    int existingUserCount = Convert.ToInt32(checkExistingUserCmd.ExecuteScalar());
                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Email already exists. Use a different email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string insertUserQuery = "INSERT INTO Users (Email, Password, UserRole) VALUES (@Email, @Password, @UserRole)";
                    MySqlCommand insertUserCmd = new MySqlCommand(insertUserQuery, connection);
                    insertUserCmd.Parameters.AddWithValue("@Email", email);
                    insertUserCmd.Parameters.AddWithValue("@Password", password);
                    insertUserCmd.Parameters.AddWithValue("@UserRole", userRole);

                    insertUserCmd.ExecuteNonQuery();

                    string getUserIdQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand getUserIdCmd = new MySqlCommand(getUserIdQuery, connection);
                    int userID = Convert.ToInt32(getUserIdCmd.ExecuteScalar());

                    if (userRole == "Participant")
                    {
                        string insertParticipantQuery = "INSERT INTO Participants (UserID, Name) VALUES (@UserID, @Name)";
                        MySqlCommand insertParticipantCmd = new MySqlCommand(insertParticipantQuery, connection);
                        insertParticipantCmd.Parameters.AddWithValue("@UserID", userID);
                        insertParticipantCmd.Parameters.AddWithValue("@Name", name);

                        insertParticipantCmd.ExecuteNonQuery();
                    }
                    else if (userRole == "Instructor")
                    {
                        string insertInstructorQuery = "INSERT INTO Instructors (UserID, Name) VALUES (@UserID, @Name)";
                        MySqlCommand insertInstructorCmd = new MySqlCommand(insertInstructorQuery, connection);
                        insertInstructorCmd.Parameters.AddWithValue("@UserID", userID);
                        insertInstructorCmd.Parameters.AddWithValue("@Name", name);

                        insertInstructorCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("User successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                    comboBoxUserRole.SelectedItem = null;
                    textBoxName.Text = "";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadRolesToComboBox()
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT DISTINCT UserRole FROM Users";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string role = reader["UserRole"].ToString();
                        Selection_roles.Items.Add(role); 
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Selection_roles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = Selection_roles.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedRole))
            {
                LoadDataToGrid_usersList(selectedRole);
                Console.WriteLine("Selected Role: " + selectedRole);
            }
        }

        private void LoadDataToGrid_usersList(string roles)
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT u.UserID AS 'User ID', u.Email, " +
                                   "CASE " +
                                   "WHEN u.UserRole = 'Participant' THEN p.Name " +
                                   "WHEN u.UserRole = 'Instructor' THEN i.Name " +
                                   "END AS 'User Name' " +
                                   "FROM Users u " +
                                   "LEFT JOIN Participants p ON u.UserID = p.UserID " +
                                   "LEFT JOIN Instructors i ON u.UserID = i.UserID " +
                                   "WHERE u.UserRole = @roles";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@roles", roles);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    Grid_usersList.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Grid_usersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Selection_attendHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadDataToGrid_events()
        {
            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT e.EventID AS 'ID', e.Name AS 'Class Name', e.StartDateTime, e.EndDateTime " +
                                   "FROM events e " +
                                   "ORDER BY e.StartDateTime";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    Grid_eventsList.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}