using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata.Solver
{
    [TestFixture]
    public class SolverShould
    {
        [Test]
        public void AiDeterminesAValidMove()
        {
            var board = new List<string>
            {
                "o", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var result = Solver.AiSolver(board);

            Assert.AreEqual(1, result);

        }


    }
}