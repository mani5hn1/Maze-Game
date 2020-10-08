using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Maze_Game
{
    //This is the main screen where the user can start the game, see the current scores or exit the game.
    //Try Catch is used to prevent the Main screen from crashing.
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        //The Start button opens the game mode screen and the user can choose the game mode they want to play.
        //The main screen then closes.
        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var gameMode = new GameMode();
                gameMode.Show();
                this.Hide();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Start Game", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        //The Scores button opens a screen containing the records of users that have played the game.
        private void ScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Hide();
                 var scores = new ScoresScreen();
                 scores.Show();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to show Scores", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //The Exit button closes the application.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Logout button takes the user back to the Login screen
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = "Close Window";
                MessageBox.Show("You have Successfully Logged Out", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                var loginScreen = new LoginScreen();
                loginScreen.Show();
                this.Hide();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Logout", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}