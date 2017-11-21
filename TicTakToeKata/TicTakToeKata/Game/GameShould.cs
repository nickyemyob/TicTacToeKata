using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Game
{
    [TestFixture]
    public class GameShould
    {
        [Test]
        public void CreateAnEmptyGameBoard()
        {
            var expectedBoard = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var game = new Game();
            var actualBoard = game.NewBoard();

            Assert.AreEqual(expectedBoard, actualBoard);
        }

        private static readonly object[] IncorrectUserInputScenarios =
        {
            new object[] { "a" },
            new object[] { "" },
            new object[] { " " },
            new object[] { "-1" },
            new object[] { "9" }


        };

        [TestCaseSource(nameof(IncorrectUserInputScenarios))]
        [Test]
        public void InformTheUserOfInvalidInput(string input)
        {
            var userInput = input;
            bool checkInput = Game.Input(userInput);

            Assert.False(checkInput);
            
        }

        private static readonly object[] CorrectUserInputScenarios =
        {
            new object[] { "0" },
            new object[] { "8" },
            new object[] { "4" }


        };

        [TestCaseSource(nameof(CorrectUserInputScenarios))]
        [Test]
        public void AccecptsUserInputIfValid(string input)
        {
            var userInput = input;
            bool checkInput = Game.Input(userInput);

            Assert.True(checkInput);

        }

        [Test]
        public void FinishTheGameWhenThereAreNoMoreMoves()
        {
            var expectedBoard = new List<string>
            {
                "x", "o", "x",
                "x", "o", "x",
                "o", "x", "o"
            };

            var gameIsFinished = Game.IsFinished(expectedBoard);

            Assert.True(gameIsFinished);
        }

        [Test]
        public void NotFinishTheGameWhenThereAreNoMoreMoves()
        {
            var expectedBoard = new List<string>
            {
                "x", "o", "x",
                "x", "o", "x",
                "o", "x", " "
            };

            var gameIsFinished = Game.IsFinished(expectedBoard);

            Assert.False(gameIsFinished);
        }


    }
}