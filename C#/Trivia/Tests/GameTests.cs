using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trivia;

namespace Tests
{
    [TestClass]
    public class GameTests
    {
        public TestContext TestContext { get; set; }

        public GameTests()
        {
        }

        [TestMethod]
        public void GameCreationTest()
        {
            // arrange
            var newGame = new Game();

            // act

            // assert
            Assert.AreEqual(50, newGame.PopQuestions.Count);
            Assert.AreEqual(50, newGame.ScienceQuestions.Count);
            Assert.AreEqual(50, newGame.SportsQuestions.Count);
            Assert.AreEqual(50, newGame.RockQuestions.Count);

            Assert.IsTrue(newGame.PopQuestions.All(q => q.StartsWith("Pop")));
            Assert.IsTrue(newGame.ScienceQuestions.All(q => q.StartsWith("Science")));
            Assert.IsTrue(newGame.SportsQuestions.All(q => q.StartsWith("Sports")));
            Assert.IsTrue(newGame.RockQuestions.All(q => q.StartsWith("Rock")));
        }

        [TestMethod]
        public void RollTest()
        {
            // arrange
            var newGame = new Game();
            newGame.Add("TestPlayer");

            // act
            int rolledNo = newGame.Roll(diceSize: 6);

            // assert
            Assert.IsTrue(rolledNo >= 1 && rolledNo <= 6, "Number should be in the range");
        }

    }
}

