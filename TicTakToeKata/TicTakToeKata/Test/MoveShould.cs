using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Test
{
    public class MoveShould
    {
        [Test]
        public void AllowUserToMakeAMoveOnTheBoard()
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

    }
}