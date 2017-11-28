using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Test
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

            var computerPlayer = new ComputerPlayer();
            var solver = new Solver();
            var solve = solver.Solve(board);

            var result = computerPlayer.Move(board,solve);

            Assert.AreEqual(1, result);

        }


    }
}