using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class LoginScreen : Form
    {
        //This is a Login screen that allows users to create an account or login to an existing account.
        //Creating a public variable to use in Easy, Normal and Hard Screens.
        //Instead of creating a text box to insert the users name, it will take the username provided from the login form.

        public static string Username;
        
        public LoginScreen()
        {
            InitializeComponent();
        }

        //Create button will create an account for the user.
        //Both text fields must be filled in order to create an account.
        //Creating a connection to the local db to check if the account exists or not.
        //If the account exisits, click the Login button, if the account does not exist the data will
        //be stored in the database and can be used to Login with that new account.
        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                {
                    string title = "Close Window";
                    MessageBox.Show("Please Enter Username or Password", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connectionString = @"Data Source = (LocalDb)\MSSQLLocalDB;Initial catalog=MazeGame; Integrated Security=True";
                    SqlConnection cnn = new SqlConnection(connectionString);
                    cnn.Open();

                    string insertQuery = string.Format("Insert [Account] ([Username], [Password]) values ('{0}','{1}')", UsernameTextBox.Text, PasswordTextBox.Text);
                    string checker = "Select * from [Account] where [Username] = @UName";
                    SqlCommand command = new SqlCommand(insertQuery, cnn);
                    SqlCommand checkerCommand = new SqlCommand(checker, cnn);
                    checkerCommand.Parameters.AddWithValue("@UName", UsernameTextBox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(checkerCommand);

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;

                    if (count == 0)
                    {
                        SqlDataAdapter adapter1 = new SqlDataAdapter { InsertCommand = new SqlCommand(insertQuery, cnn) };
                        adapter1.InsertCommand.ExecuteNonQuery();
                        string title = "Close Window";
                        MessageBox.Show("You have Successfully Registered", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        string title = "Close Window";
                        MessageBox.Show("The Username provided already exists", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    command.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Create an account", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Login button will check if the credentials put in by the user exists.
        //Both text fields must be filled in order to Login.
        //Creating a connection to the local db to check if the account exists or not.
        //if the account exists, it will take you to the Main screen.
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
                {
                    string title = "Close Window";
                    MessageBox.Show("Please Enter Username or Password", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string connectionString = @"Data Source = (LocalDb)\MSSQLLocalDB;Initial catalog=MazeGame; Integrated Security=True";
                    SqlConnection cnn = new SqlConnection(connectionString);

                    string query = ("Select * from [Account] where [Username] = @UName and [Password] = @UPassword");

                    SqlCommand command = new SqlCommand(query, cnn);
                    command.Parameters.AddWithValue("@UName", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@UPassword", PasswordTextBox.Text);
                    cnn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        Username = UsernameTextBox.Text;
                        string title = "Close Window";
                        MessageBox.Show("You have Successfully Logged in", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        var mainScreen = new MainScreen();
                        mainScreen.Show();
                    }
                    else
                    {
                        string title = "Close Window";
                        MessageBox.Show("Please Check your Username and Password", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    command.Dispose();
                    cnn.Close();
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Login", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //End Application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Exit Application", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}