using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyTickets.UnitTests
{
    [TestClass]
    public class TicketTests
    {
        [TestMethod]
        [DataRow(1290ul, 6, 4, (byte)9, DisplayName = "When called insede range")]
        [DataRow(99_912_902ul, 8, 7, (byte)2, DisplayName = "When called last of range")]
        [DataRow(1290ul, 6, 0, (byte)0, DisplayName = "When called first of range")]
        public void Indexer_WhenCalled_ReturnsByteNumber(ulong number, int digits, int index, byte expected)
        {
            // Arrange
            Ticket ticket = new Ticket(number, digits);

            // Act
            byte actual = (byte)ticket[index];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
