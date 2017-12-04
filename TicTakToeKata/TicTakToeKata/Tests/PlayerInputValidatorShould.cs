using NUnit.Framework;
using TicTakToeKata.Validators;

namespace TicTakToeKata.Tests
{
    [TestFixture]
    public class PlayerInputValidatorShould
    {

        private static readonly object[] OutOfBoundsUserInputScenarios =
        {
            new object[] { -1 },
            new object[] { 9 }
        };

        [TestCaseSource(nameof(OutOfBoundsUserInputScenarios))]
        [Test]
        public void NotAcceptNumbersOutsideTheBoundsOfTheBoard(int input)
        {
            var checker = new PlayerInputValidator();

            var isWithinBoardBoundry = checker.IsWithinBoardBoundry(input);

            Assert.False(isWithinBoardBoundry);
        }
    }
}