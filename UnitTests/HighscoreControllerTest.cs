using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

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
    }
}
