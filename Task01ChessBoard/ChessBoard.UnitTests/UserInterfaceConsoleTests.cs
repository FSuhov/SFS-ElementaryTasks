using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard.UnitTests
{
    [TestClass]
    public class UserInterfaceConsoleTests
    {
        [TestMethod]
        [DataRow(new string[] { "34", "24", "true"}, BoardConfig.ArgsStatus.ThreeArgs)]
        [DataRow(new string[] { "7", "24", "true" }, BoardConfig.ArgsStatus.InvalidArgs)]
        [DataRow(new string[] {  }, BoardConfig.ArgsStatus.NoArgs)]
        [DataRow(new string[] { "34" }, BoardConfig.ArgsStatus.OneArg)]
        [DataRow(new string[] { "tt", "24", "true" }, BoardConfig.ArgsStatus.InvalidArgs)]
        public void ValidateArgs_WhenCalled_ReturnsArgsStatus(string[] args, BoardConfig.ArgsStatus expectedResult)
        {
            UserInterfaceConsole userInterface = new UserInterfaceConsole();
            var result = userInterface.ValidateArgs(args);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void CreatBoard_WhenCalledWithCorrectArguments_ReturnsInstance()
        {
            UserInterfaceConsole userInterface = new UserInterfaceConsole();
            Board expectedBoard = new Board(48, 36, true);
            string[] localArgs = { "48", "36", "true" };
            Board actualBoard = userInterface.CreateBoard(localArgs);

            var result = actualBoard != null &&
                         expectedBoard.IsWhitesBelow == actualBoard.IsWhitesBelow &&
                         expectedBoard.WhiteCell.Width == actualBoard.WhiteCell.Width &&
                         expectedBoard.WhiteCell.Height == actualBoard.WhiteCell.Height;

            Assert.AreEqual(result, true);
            //Assert.AreEqual<Board>(expectedBoard, actualBoard);
        }

        [TestMethod]
        public void CreatBoard_WhenCalledWithNoArguments_ReturnsNull()
        {
            UserInterfaceConsole userInterface = new UserInterfaceConsole();
            Board expectedBoard = new Board(48, 36, true);
            string[] localArgs = {  };
            Board actualBoard = userInterface.CreateBoard(localArgs);

            var result = actualBoard != null &&
                         expectedBoard.IsWhitesBelow == actualBoard.IsWhitesBelow &&
                         expectedBoard.WhiteCell.Width == actualBoard.WhiteCell.Width &&
                         expectedBoard.WhiteCell.Height == actualBoard.WhiteCell.Height;

            Assert.AreEqual(result, false);
        }
    }
}
