using System.Collections.Generic;
using NUnit.Framework;
using TicTakToeKata.Players;

namespace TicTakToeKata.Tests
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

            var humanPlayer = new HumanPlayer("o");
            var actualMove = humanPlayer.Move(board);

            Assert.AreEqual(expectedBoard, board);
            Assert.AreEqual(usersMove, actualMove);
        }

    }
}