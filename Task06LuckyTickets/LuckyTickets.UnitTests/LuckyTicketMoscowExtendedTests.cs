using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyTickets.UnitTests
{
    [TestClass]
    public class LuckyTicketMoscowExtendedTests
    {
        [TestMethod]
        [DataRow(56719888, 8, false)]
        [DataRow(1234554321, 10, true)]
        [DataRow(19, 2, false)]
        public void IsLuckyTicket_WhenCalled_ReturnsTrueOrFalse(long number, int digits, bool expected)
        {
            // Arrange
            ILuckyTicketIdentifier ticketIdentifier = new LuckyTicketMoscowExtended(digits);
            Ticket ticket = new Ticket(number, digits);

            // Act
            bool actual = ticketIdentifier.IsLuckyTicket(ticket);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
