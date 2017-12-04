using System.Collections.Generic;
using NUnit.Framework;
using TicTakToeKata.Players;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class ComputerPlayerShould
    {
        [Test]
        public void CreateASolution()
        {
            var computerPlayer = new ComputerPlayer("x");
            var expectedBoard = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var board = new List<string>
            {
                "x", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };


            var move = computerPlayer.Move(expectedBoard);

            CollectionAssert.AreEqual(expectedBoard, board);
            Assert.AreEqual(0, move);
        }
    }
}