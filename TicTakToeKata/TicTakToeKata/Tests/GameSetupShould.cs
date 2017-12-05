using System.Collections.Generic;
using NUnit.Framework;
using TicTakToeKata.Rules;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class GameSetupShould
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

            var game = new GameSetup();
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
            var game = new GameSetup();
            var userInput = input;
            bool checkInput = game.IsValidInput(userInput);

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
            var game = new GameSetup();
            var userInput = input;
            bool checkInput = game.IsValidInput(userInput);

            Assert.True(checkInput);

        }

        [Test]
        public void FinishWhenThereAreNoMoreMoves()
        {
            var game = new GameSetup();
            var expectedBoard = new List<string>
            {
                "x", "o", "x",
                "x", "o", "x",
                "o", "x", "o"
            };

            var gameIsFinished = game.IsFinished(expectedBoard);

            Assert.True(gameIsFinished);
        }

        [Test]
        public void NotFinishWhenThereAreValidMoreMoves()
        {
            var game = new GameSetup();
            var expectedBoard = new List<string>
            {
                "x", "o", "x",
                "x", "o", "x",
                "o", "x", " "
            };

            var gameIsFinished = game.IsFinished(expectedBoard);

            Assert.False(gameIsFinished);
        }

        [Test]
        public void SetupSizeOfBoard()
        {
            var game = new GameSetup();
            var expectedSize = 9;

            var board = game.NewBoard();

            var actualSize = board.Count;

            Assert.AreEqual(expectedSize,actualSize);

        }
    }
}