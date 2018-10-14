using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSequence.BusineessLogicClasses;

namespace NumberSequence.UnitTests
{
    [TestClass]
    public class PowSequenceTests
    {
        [TestMethod]
        [DataRow(45, new int[] { 0,1,2,3,4,5,6})]
        public void GetSequence_WhenCalledReturns_IEnumerableSequence(int limit, int[] expected)
        {
            // Arrange
            PowSequence powSequence = new PowSequence(limit);

            // Act
            int[] actual = powSequence.GetSequence().ToArray();
            bool areEqual = actual.SequenceEqual(expected);

            // Assert
            Assert.IsTrue(areEqual);
        }
    }
}
