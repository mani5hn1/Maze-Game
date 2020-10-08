using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Maze_Game
{
    public partial class Room1 : Form
    {
        //This is the Room 1 screen where the boarders are thin and simple to play through.
        //Collection is a count of coins that are collected and Collision is the number of times the cursor hits the walls.
        //Stopwatch tracks the time taken to complete the game. A timer is also being used as well to visually show the time on the screen.
        public int collection = 0;
        public int collision = 0;
        readonly Stopwatch sw = new Stopwatch();
        public bool finishedGame = false;

        //As the screen launches, the time will start and it will set the cursor on where it needs to be placed.
        public Room1()
        {
            InitializeComponent();
            string title = "Close Window";
            MessageBox.Show("Rules of the Game:" + Environment.NewLine + "1. Use your Cursor to navigate through the Maze and reach the finish." +
                Environment.NewLine + "2. Collect Coins as you navigate through the Maze." + Environment.NewLine +
                "3. Reach the finish with the shortest Time and with the least Collisions.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Timer.Enabled = true;
            sw.Start();
            Cursor.Position = PointToScreen(panel2.Location);
        }

        //Once the user has got to the finish, it will tell the user on how many coins they colleced and how long they took to complete it.
        private void Finish_Click(object sender, EventArgs e)
        {
            try
            {
                Timer.Enabled = false;
                sw.Stop();
                MessageBox.Show("You did it! You collected: " + collection + " coins! " +
                    "your time was " + string.Format("{00}", sw.Elapsed.Seconds + " seconds"));
                finishedGame = true;
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Finishing Game", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method sets the cursor back to the start if the cursor hits any of the walls and it will increment the collision count.
        private void MouseStart(object sender, EventArgs e)
        {
            try
            {
                Cursor.Position = PointToScreen(panel2.Location);
                collision++;
                ActualCollisionLabel.Text = collision.ToString();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in setting Collision", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Methods CoinsCollect, CoinsCollect1, CoinsCollect2, CoinsCollect3, CoinsCollect4, CoinsCollect5, CoinsCollect6, CoinsCollect7, CoinsCollect8, CoinsCollect9
        //achieve the same outcome but to different coins.
        //When the user gets a coin, it will increment the collection count.
        private void CoinsCollect(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect1(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin1.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin1.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect2(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin2.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin2.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect3(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin3.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin3.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect4(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin4.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin4.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect5(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin5.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin5.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect6(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin6.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin6.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect7(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin7.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin7.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect8(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin8.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin8.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CoinsCollect9(object sender, EventArgs e)
        {
            try
            {
                if (Cursor.Clip.IntersectsWith(Coin9.Bounds))
                {
                    collection++;
                    ActualCoinsLabel.Text = collection.ToString();
                    Coin9.Visible = false;
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Error in Retrieving Coin", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This button will store the users game data into a local database and they can see their record in the Scores screen.
        private void SubmitScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source = (LocalDb)\MSSQLLocalDB;Initial catalog=MazeGame; Integrated Security=True";
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                if (LoginScreen.Username != null && finishedGame != false)
                {
                    string query = string.Format("Insert [MazeGame] ([Username], [Time], [CoinsCollected], [Room], [Collisions]) values ('{0}','{1}',N'{2}','{3}','{4}')", LoginScreen.Username, string.Format("{00}", sw.Elapsed.Seconds + " seconds"), collection, "Room 1", collision);

                    SqlCommand command = new SqlCommand(query, cnn);
                    SqlDataAdapter adapter = new SqlDataAdapter { InsertCommand = new SqlCommand(query, cnn) };
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    cnn.Close();

                    MessageBox.Show("Your Score was submitted!");
                }
                else
                {
                    if (finishedGame != true)
                    {
                        string title = "Close Window";
                        MessageBox.Show("Finish the Game!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Cursor.Position = PointToScreen(panel2.Location);
                    }
                    else
                    {
                        string title = "Close Window";
                        MessageBox.Show("Error in Saving Data", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Process Data", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //The Exit to main screen button will send the user back to the Main screen. 
        private void BackButton_Click(object sender, EventArgs e)
        {
            try
            {
                var mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to return to Main Screen :(", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Displays the time on screen.
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                ActualTimeLabel.Text = string.Format("{00}", sw.Elapsed.Seconds.ToString());
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Set Time", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //This method resets the game so that the user can have another go if they are not happy with their score.
        private void ResetGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                collision = 0;
                collection = 0;
                finishedGame = false;

                ActualCollisionLabel.Text = "0";
                ActualTimeLabel.Text = "00:00";
                ActualCoinsLabel.Text = "0";

                Coin.Visible = true;
                Coin1.Visible = true;
                Coin2.Visible = true;
                Coin3.Visible = true;
                Coin4.Visible = true;
                Coin5.Visible = true;
                Coin6.Visible = true;
                Coin7.Visible = true;
                Coin8.Visible = true;
                Coin9.Visible = true;

                sw.Restart();
                Timer.Enabled = true;
                sw.Start();

                Cursor.Position = PointToScreen(panel2.Location);
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Reset Game", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}