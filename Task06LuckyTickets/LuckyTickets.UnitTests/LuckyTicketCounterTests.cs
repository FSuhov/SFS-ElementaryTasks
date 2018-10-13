using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LuckyTickets.UnitTests
{
    [TestClass]
    public class LuckyTicketCounterTests
    {
        [TestMethod]
        public void CountNumberOfLuckyTickets_WhenCalledWithDefaultDigits_ReturnsNumberOfTickets()
        {
            // Arrange
            LuckyTicketCounter ticketCounter = new LuckyTicketCounter(new LuckyTicketMoscow());

            // Act
            int actual = ticketCounter.CountNumberOfLuckyTickets();

            // Assert
            Assert.AreEqual(55251, actual);
        }

        [TestMethod]
        [DataRow(6, 55251)]
        [DataRow(2, 9)]
        public void CountNumberOfLuckyTickets_WhenCalledWithExtendedDigits_ReturnsNumberOfTickets(int digits, int expected)
        {
            // Arrange
            LuckyTicketCounter ticketCounter = new LuckyTicketCounter(new LuckyTicketMoscowExtended(digits), digits);

            // Act
            int actual = ticketCounter.CountNumberOfLuckyTickets();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
