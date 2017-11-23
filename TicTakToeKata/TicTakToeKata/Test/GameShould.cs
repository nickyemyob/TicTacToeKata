using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Test
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

        [Test]
        public void AllowUserToMakeAValidMove()
        {
            var game = new Game();
            var board = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var expectedBoard = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var usersMove = 0;

            game.UsersMove(board, usersMove);

            Assert.AreEqual(expectedBoard, board);
        }

        [Test]
        public void AllowComputerPlayerToMakeAValidMove()
        {
            var game = new Game();
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var expectedBoard = new List<string>
            {
                "o", "x", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            game.ComputerPlayersMove(board);

            Assert.AreEqual(expectedBoard, board);
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
            var game = new Game();
            var userInput = input;
            bool checkInput = game.Input(userInput);

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
            var game = new Game();
            var userInput = input;
            bool checkInput = game.Input(userInput);

            Assert.True(checkInput);

        }

        [Test]
        public void FinishWhenThereAreNoMoreMoves()
        {
            var game = new Game();
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
            var game = new Game();
            var expectedBoard = new List<string>
            {
                "x", "o", "x",
                "x", "o", "x",
                "o", "x", " "
            };

            var gameIsFinished = game.IsFinished(expectedBoard);

            Assert.False(gameIsFinished);
        }
    }
}