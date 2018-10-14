using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequence.ConsoleClasses;

namespace NumberSequence.UnitTests
{
    [TestClass]
    public class SequenceConsoleTests
    {
        [TestMethod]
        [DataRow(new string[] { }, ConfigData.Config.AppStatus.InvalidArgs, DisplayName ="When no arguments entered")]
        [DataRow(new string[] {"as "}, ConfigData.Config.AppStatus.InvalidArgs, DisplayName = "Non-numeric arguments entered")]
        [DataRow(new string[] {"12" }, ConfigData.Config.AppStatus.PowerSequence, DisplayName = "One valid argument entered")]
        [DataRow(new string[] {"45", "190" }, ConfigData.Config.AppStatus.FiboSequence, DisplayName = "When two valid arguments entered")]
        [DataRow(new string[] {"100", "-9" }, ConfigData.Config.AppStatus.InvalidArgs, DisplayName = "Second argument less")]
        public void ValidateAndSetStatus_ReturnsStatus(string[]args, ConfigData.Config.AppStatus expected)
        {
            // Arrange
            SequenceConsole console = new SequenceConsole();
            console.ReadInputAndSetStatus(args);

            // Act
            ConfigData.Config.AppStatus actual = console.GetStatus();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
