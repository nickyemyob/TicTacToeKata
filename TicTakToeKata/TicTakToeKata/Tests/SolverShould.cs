using System.Collections.Generic;
using NUnit.Framework;
using TicTakToeKata.Players;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class SolverShould
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

            var computerPlayer = new ComputerPlayer("x");
            var solver = new Solver();
            var solve = solver.Solve(board);

            var result = computerPlayer.Move(board);

            Assert.AreEqual(1, result);

        }


    }
}