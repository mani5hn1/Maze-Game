using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maze_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Maze_Game.Tests
{
    [TestClass()]
    public class Room2ScreenTests
    {
        [TestMethod()]
        public void CollectCoins()
        {
            //Arrange
            Label ActualCoinsLabel = new Label();
            PictureBox coin = new PictureBox();
            int collection = 0;

            //Act
            if (Cursor.Clip.IntersectsWith(coin.Bounds))
            {
                collection++;
                ActualCoinsLabel.Text = collection.ToString();
                coin.Visible = false;
            }

            //Assert
            Assert.AreEqual(collection, 1);
        }

        [TestMethod()]
        public void ResetPointerIfUserTouchesWalls()
        {
            //Arrange
            Label wall = new Label();
            Panel panel = new Panel();

            //Act
            panel.Location = new Point(128, 141);
            panel.Size = new Size(200, 100);

            //Assert
            if (Cursor.Clip.IntersectsWith(wall.Bounds))
            {
                Assert.AreEqual(Cursor.Position = panel.Location, panel.Location);
            }
        }

        [TestMethod()]
        public void CursorReachesFinishLine()
        {
            //Arrange
            Label finish = new Label();
            Timer timer = new Timer();
            Stopwatch sw = new Stopwatch();
            int collection = 0;
            string finishedgame = "You did it! You collected: " + collection + " coins! " +
                "your time was " + string.Format("{00}", sw.Elapsed.Seconds + " seconds");
            string finishedgame1;

            //Act
            timer.Start();
            sw.Start();

            //Assert
            if (Cursor.Clip.IntersectsWith(finish.Bounds))
            {
                sw.Stop();
                timer.Stop();
                finishedgame1 = $"You did it! You collected: {collection} coins! your time was {string.Format("{00}", sw.Elapsed.Seconds + " seconds")}";

                Assert.AreEqual(finishedgame, finishedgame1);
            }
        }
    }
}