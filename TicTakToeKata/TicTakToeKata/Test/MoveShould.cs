using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Test
{
    public class MoveShould
    {
        [Test]
        public void AllowUserToMakeAValidMove()
        {
            var move = new Move();
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

            move.UsersMove(board, usersMove);

            Assert.AreEqual(expectedBoard, board);
        }

        [Test]
        public void AllowComputerPlayerToMakeAValidMove()
        {
            var move = new Move();
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

            move.ComputerPlayersMove(board);

            Assert.AreEqual(expectedBoard, board);
        }

        [Test]
        public void NotLetPlayersOverwriteExistingMoves()
        {
            var move = new Move();
            var board = new List<string>
            {
                "x", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var game = new Game();

            move.UsersMove(board,0);

            var expectedBoard = new List<string>
            {
                "x", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            Assert.AreEqual(expectedBoard,board);
        }
    }
}