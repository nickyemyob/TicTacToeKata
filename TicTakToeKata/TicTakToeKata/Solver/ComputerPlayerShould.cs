using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Solver
{
    [TestFixture]
    public class ComputerPlayerShould
    {
        [Test]
        public void DetermineAValidMove()
        {
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var result = ComputerPlayer.Solve(board);

            Assert.AreEqual(1, result);

        }


    }
}