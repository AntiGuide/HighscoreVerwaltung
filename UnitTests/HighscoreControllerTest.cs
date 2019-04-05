using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server;

namespace UnitTests {
    [TestClass]
    public class HighscoreControllerTest {
        [TestMethod]
        public void CreateUser_NonExistent() {
            var highscoreController = new HighscoreController();
            Assert.IsFalse(highscoreController.GetUsers().Any(u => u.Name == "Tester"));
            var user = highscoreController.CreateUser("Tester");
            Assert.IsTrue(highscoreController.GetUsers().Any(u => u.Name == "Tester"));
            Assert.AreEqual(user, highscoreController.GetUsers().First(u => u.Name == "Tester"));
        }

        [TestMethod]
        public void CreateGame_NonExistent() {
            var highscoreController = new HighscoreController();
            Assert.IsFalse(highscoreController.GetGames().Any(u => u.Name == "TestGame"));
            var game = highscoreController.CreateGame("TestGame");
            Assert.IsTrue(highscoreController.GetGames().Any(u => u.Name == "TestGame"));
            Assert.AreEqual(game, highscoreController.GetGames().First(u => u.Name == "TestGame"));
        }
    }
}
