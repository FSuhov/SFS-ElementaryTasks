using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyTickets.UnitTests
{
    [TestClass]
    public class LuckyTicketMoscowTests
    {
        [TestMethod]
        [DataRow(1,6,false)]
        [DataRow(999999, 6, true)]
        [DataRow(123456, 6, false)]
        [DataRow(123231, 6, true)]
        public void IsLuckyTicket_WhenCalled_ReturnsTrueOrFalse(int number, int digits, bool expected)
        {
            // Arrange
            ILuckyTicketIdentifier ticketIdentifier = new LuckyTicketMoscow();
            Ticket ticket = new Ticket(number, digits);

            // Act
            bool actual = ticketIdentifier.IsLuckyTicket(ticket);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
