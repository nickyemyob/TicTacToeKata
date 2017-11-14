using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class GameShould
    {
        [Test]
        public void CreateAnEmptyGameBoard()
        {
            var expectedBoard = new List<string>
            {
                " ", " ", " ",
                " ", " ", " ",
                " ", " ", " "
            };

            var game = new Game();
            var actualBoard = game.NewBoard();

            Assert.AreEqual(expectedBoard, actualBoard);
        }
        
    }
}