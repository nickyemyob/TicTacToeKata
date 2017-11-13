using System.Collections.Generic;
using NUnit.Framework;

namespace TicTakToeKata
{
    [TestFixture]
    public class RendererShould
    {
        [Test]
        public void RenderTheBoardOfCurrentStateToTheConsole()
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

            string expectedBoardVisualisation = "[o][ ][ ]" + "\n" +
                                                "[ ][ ][ ]" + "\n" +
                                                "[ ][ ][ ]";

            var renderer = new Renderer();
            var actualBoardVisualisation = renderer.Render(board);

            Assert.AreEqual(expectedBoardVisualisation,actualBoardVisualisation);

        }
        
    }
}