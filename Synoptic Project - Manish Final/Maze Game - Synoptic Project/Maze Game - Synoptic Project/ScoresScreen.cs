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
    public partial class ScoresScreen : Form
    {
        public ScoresScreen()
        {
            InitializeComponent();
        }

        //Loads the data into the grid
        private void ScoresScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mazeGameDataSet.MazeGame' table. You can move, or remove it, as needed.
            this.mazeGameTableAdapter.Fill(this.mazeGameDataSet.MazeGame);
            try
            {
                //This line of code loads data into the 'mazeGameDataSet.MazeGame' table.
                //this.mazeGameTableAdapter.Fill(this.mazeGameDataSet.MazeGame);
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Show Data", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                var mainScreen = new MainScreen();
                mainScreen.Show();
            }
        }

        //User is sent back to the main screen.
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainScreen = new MainScreen();
            mainScreen.Show();
        }

        //User is able to look for their own name or other users to see their scores.
        private void SearchTextBox_TextChanged(object sender, KeyPressEventArgs e)
        {
            try
            {
                string Scnn = @"Data Source = (LocalDb)\MSSQLLocalDB;Initial catalog=MazeGame; Integrated Security=True";
                using (SqlConnection sc = new SqlConnection(Scnn))
                {
                    sc.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = new SqlCommand("SELECT * FROM MazeGame", sc);
                        var dataset = new DataSet();
                        adapter.Fill(dataset);
                        var dt = dataset.Tables[0];
                        var dv = dt.DefaultView;
                        dv.RowFilter = String.Concat("[Username] LIKE '%", SearchTextBox.Text, "%'");
                        dataGridView1.DataSource = dv.ToTable();
                    }
                }
            }
            catch (Exception)
            {
                string title = "Close Window";
                MessageBox.Show("Unable to Show Data", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}