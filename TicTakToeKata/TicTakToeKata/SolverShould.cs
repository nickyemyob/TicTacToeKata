using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class SolverShould
    {
        [Test]
        public void MakeAMoveOnTheBoardAfterTheUser()
        {
            var board = new List<string>();
            board.Add("o");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");
            board.Add(" ");

            var solver = new Solver();

            var result = solver.Solve(board);

            Assert.AreEqual(2, result);
        }
    }
}