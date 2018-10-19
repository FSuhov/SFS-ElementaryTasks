using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyTickets.UnitTests
{
    [TestClass]
    public class LuckyTicketCounterTests
    {
        [TestMethod]
        [DataRow(6, 55251)]
        [DataRow(2, 9)]
        public void CountNumberOfLuckyTickets_Moscow_ReturnsNumberOfTickets(int digits, int expected)
        {
            // Arrange
            LuckyTicketCounter ticketCounter = new LuckyTicketCounter(new LuckyTicketMoscow(), digits);

            // Act
            int actual = ticketCounter.CountNumberOfLuckyTickets();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(6, 55251)]
        [DataRow(2, 9)]
        public void CountNumberOfLuckyTickets_Piter_ReturnsNumberOfTickets(int digits, int expected)
        {
            // Arrange
            LuckyTicketCounter ticketCounter = new LuckyTicketCounter(new LuckyTicketPeter(), digits);

            // Act
            int actual = ticketCounter.CountNumberOfLuckyTickets();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
