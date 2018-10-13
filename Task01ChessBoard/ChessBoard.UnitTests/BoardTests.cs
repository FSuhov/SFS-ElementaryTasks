using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessBoard.UnitTests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        [DataRow(9, 8, 1, 1)]
        [DataRow(68, 90, 8, 11)]
        public void BoardConstructor_WhenCalled_CreatesInstance(int height, int width, int expectedCellWidht, int expectedCellHeight)
        {
            // Arrange

            // Act
            Board board = new Board(height, width);

            // Assert
            Assert.AreEqual(expectedCellWidht, board.FirstCell.Width);
            Assert.AreEqual(expectedCellHeight, board.FirstCell.Height);
        }
    }
}
