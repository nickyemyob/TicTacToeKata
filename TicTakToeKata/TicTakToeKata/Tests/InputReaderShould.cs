using Moq;
using NUnit.Framework;
using TicTakToeKata.Interfaces;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class InputReaderShould
    {
        [Test]
        [Ignore("just for fun")]
        public void PassUserInput()
        {
            //THIS IS ONLY FOR PLAYING AROUND WITH MOQ
            Mock<IInputReader> inputReaderMock = new Mock<IInputReader>();

            inputReaderMock.Setup(e => e.UserInput()).Returns("Hello World!");

            Assert.AreEqual("Hello World!", inputReaderMock.Object.UserInput());

        }
        
    }
}