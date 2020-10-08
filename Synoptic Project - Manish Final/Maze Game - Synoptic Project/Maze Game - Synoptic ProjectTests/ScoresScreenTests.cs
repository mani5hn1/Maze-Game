using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maze_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Maze_Game.Tests
{
    [TestClass()]
    public class ScoresScreenTests
    {
        [TestMethod()]
        public void FindNameInDataGrid()
        {
            //Arrange
            DataGridView dataGridView = new DataGridView();
            TextBox SearchTextBox = new TextBox();


            //Act

            SearchTextBox.Text = "manish";
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Name";
            dataGridView.Columns[1].Name = "CoinsCollected";
            dataGridView.Columns[2].Name = "Time";
            dataGridView.Columns[3].Name = "Difficulty";
            dataGridView.Columns[4].Name = "Collisions";

            string[] row = new string[] { "manish", "4", "1 second", "Easy", "4" };
            dataGridView.Rows.Add(row);


            //Assert
            Assert.AreEqual(dataGridView.Columns[0].Name= "manish", SearchTextBox.Text) ;
            

           


        }
    }
}