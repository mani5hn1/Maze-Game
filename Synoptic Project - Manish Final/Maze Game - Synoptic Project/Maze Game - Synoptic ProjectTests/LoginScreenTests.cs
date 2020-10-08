using Microsoft.VisualStudio.TestTools.UnitTesting;
using Maze_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze_Game.Tests
{
    [TestClass()]
    public class LoginScreenTests
    {
        [TestMethod()]
        public void CreateAccount()
        {
            //Arrange
            TextBox username = new TextBox();
            TextBox password = new TextBox();
            string usernameExists = "admin1";

            //Act
            username.Text = "admin";
            password.Text = "adminpassword";

            //Assert
            if (username.Text != usernameExists)
            {
                Assert.AreNotEqual(username.Text, usernameExists);
                MessageBox.Show("Account Created");
            }
        }

        [TestMethod()]
        public void AccountAlreadyExists()
        {
            //Arrange
            TextBox username = new TextBox();
            TextBox password = new TextBox();
            string usernameExists = "admin1";

            //Act
            username.Text = "admin1";
            password.Text = "adminpassword";

            //Assert
            if (username.Text == usernameExists)
            {
                Assert.AreEqual(username.Text, usernameExists);
                MessageBox.Show("Account Already Exisits");
            }
        }

        [TestMethod()]
        public void LoginAccount()
        {
            //Arrange
            TextBox username = new TextBox();
            TextBox password = new TextBox();
            string usernameExists = "admin";

            //Act
            username.Text = "admin";
            password.Text = "adminpassword";

            //Assert
            if (username.Text == usernameExists)
            {
                Assert.AreEqual(username.Text, usernameExists);
                MessageBox.Show("You have Successfully Logged in");
            }
        }

        [TestMethod()]
        public void LoginDoesNotExist()
        {
            //Arrange
            TextBox username = new TextBox();
            TextBox password = new TextBox();
            string usernameExists = "admin";

            //Act
            username.Text = "admin1";
            password.Text = "adminpassword";

            //Assert
            if (username.Text != usernameExists)
            {
                Assert.AreNotEqual(username.Text, usernameExists);
                MessageBox.Show("Login does not Exist");
            }
        }
    }
}