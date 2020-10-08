using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Maze_Game
{
    //The Game Mode screen has two options: Load Config File and Random Button.
    //Clicking Load Config File will allow the user to select a config txt file and load that file in and it will set the room up based on the file.
    //Clicking Random Room Button will give the user a random room to play in. 
    //Try Catch is used to prevent the Difficulty screen from crashing.
    public partial class GameMode : Form
    {
        public GameMode()
        {
            InitializeComponent();
        }

        //Clicking on Back button takes the user to the main screen.
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
                MessageBox.Show("Unable to return to Main Screen", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This selects a random room for the user to play in.
        private void RandomRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int room = rnd.Next(1, 4);
                if (room == 1)
                {
                    var room1 = new Room1();
                    room1.Show();
                }
                if (room == 2)
                {
                    var room2 = new Room2();
                    room2.Show();
                }
                if (room == 3)
                {
                    var room3 = new Room3();
                    room3.Show();
                }

                this.Hide();
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to load room", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method loads the config file and sets the room up based on the contents of the file.
        private void LoadingConfigFile_Click(object sender, EventArgs e)
        {
            try
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;
              
                List<string> room = new List<string>();

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    try
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //Get the path of specified file
                            filePath = openFileDialog.FileName;

                            //Read the contents of the file into a stream
                            var fileStream = openFileDialog.OpenFile();
                            try
                            {
                                using (StreamReader reader = new StreamReader(fileStream))
                                {
                                    fileContent = reader.ReadToEnd();
                                }
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                           
                        }
                        List<string> lines = File.ReadAllLines(filePath).ToList();

                        foreach (var item in lines)
                        {
                            string[] entry = item.Split(',');

                            room.Add(entry[0]);

                            if (room[0].Equals("Room 1"))
                            {
                                var room1 = new Room1();
                                room1.Show();
                                this.Hide();
                            }
                            else if (room[0].Equals("Room 2"))
                            {
                                var room2 = new Room2();
                                room2.Show();
                                this.Hide();
                            }
                            else if (room[0].Equals("Room 3"))
                            {
                                var room3 = new Room3();
                                room3.Show();
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Load file. Check the formatting, it should be in this format: Room 1", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}