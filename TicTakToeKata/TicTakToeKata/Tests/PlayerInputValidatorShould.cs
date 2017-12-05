﻿using NUnit.Framework;
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

        private static readonly object[] IrrelevantInGameUserInputScenarios =
        {
            new object[] { "" },
            new object[] { " " },
            new object[] { "a" },
            new object[] { "abc123" }
        };

        [TestCaseSource(nameof(IrrelevantInGameUserInputScenarios))]
        [Test]
        public void NotAcceptInputIrrelevantToTheGame(string input)
        {
            var checker = new PlayerInputValidator();

            var isIrreleventInGameInput = checker.GetReleventInGameInput(input);

            Assert.False(isIrreleventInGameInput);
        }

        private static readonly object[] RelevantInGameUserInputScenarios =
        {
            new object[] { "1" },
            new object[] { "8" }
        };


        [TestCaseSource(nameof(RelevantInGameUserInputScenarios))]
        [Test]
        public void AcceptInputThatIsReleventToTheGame(string input)
        {
            var checker = new PlayerInputValidator();

            var isIrreleventInGameInput = checker.GetReleventInGameInput(input);

            Assert.True(isIrreleventInGameInput);
        }


    }
}