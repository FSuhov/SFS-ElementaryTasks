using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard.UnitTests
{
    [TestClass]
    public class ConsoleInterfaceTests
    {
        [TestMethod]
        [DataRow(new string[] {"64", "72", "true" }, BoardConfig.ApplicationStatus.Success)]
        [DataRow(new string[] { "64", "720" }, BoardConfig.ApplicationStatus.BadSizing)]
        [DataRow(new string[] {  }, BoardConfig.ApplicationStatus.NoArgs)]
        [DataRow(new string[] { "asd", "14" }, BoardConfig.ApplicationStatus.InvalidArgs)]
        public void ReadInputAndSetStatus_WhenCalled_SetsStatusOfObject(string[] args, BoardConfig.ApplicationStatus expectedStatus)
        {
            // Arrange
            ChessBoardConsoleUserInterface chessBoardConsole = new ChessBoardConsoleUserInterface();

            // Act
            chessBoardConsole.ReadInputAndSetStatus(args);

            // Assert
            Assert.AreEqual(expectedStatus, chessBoardConsole.GetStatus());
        }
    }
}
