using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class HumanPlayerShould
    {

        [Test]
        public void AllowUserToMakeAMoveOnTheBoard()
        {
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

            var humanPlayer = new HumanPlayer();
            var actualPosition = humanPlayer.Move(board, usersMove);

            Assert.AreEqual(expectedBoard, board);
            Assert.AreEqual(usersMove, actualPosition);
        }

    }
}