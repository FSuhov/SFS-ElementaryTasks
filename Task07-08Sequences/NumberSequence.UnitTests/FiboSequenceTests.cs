using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequence.BusineessLogicClasses;

namespace NumberSequence.UnitTests
{
    [TestClass]
    public class FiboSequenceTests
    {
        [TestMethod]
        [DataRow(45, 150, new int[] { 55,89,144,233 })]
        public void GetSequence_WhenCalledReturns_IEnumerableSequence(int start, int limit, int[] expected)
        {
            // Arrange
            FiboSequence fiboSequence = new FiboSequence(start,limit);

            // Act
            int[] actual = fiboSequence.GetSequence().ToArray();
            bool areEqual = actual.SequenceEqual(expected);

            // Assert
            Assert.IsTrue(areEqual);
        }
    }
}
