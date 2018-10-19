using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyTickets.UnitTests
{
    [TestClass]
    public class LuckyTicketPiterTests
    {
        [TestMethod]
        [DataRow(1ul, 6, false)]
        [DataRow(999999ul, 6, true)]
        [DataRow(123456ul, 6, false)]
        [DataRow(132231ul, 6, true)]
        public void IsLuckyTicket_WhenCalled_ReturnsTrueOrFalse(ulong number, int digits, bool expected)
        {
            // Arrange
            ILuckyTicketIdentifier ticketIdentifier = new LuckyTicketPeter();
            Ticket ticket = new Ticket(number, digits);

            // Act
            bool actual = ticketIdentifier.IsLuckyTicket(ticket);

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

