using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToText.Classes;

namespace NumberToText.UnitTests
{
    [TestClass]
    public class ConverterENTests
    {
        [TestMethod]
        [DataRow(54890, "fifty four thousand eight hundred ninety")]
        [DataRow(0, "zero")]
        [DataRow(010, "ten")]
        public void ConvertToWords_ReturnsTextRepresentation(int number, string expected)
        {
            // Arrange
            ConverterEurope converter = new ConverterEN();

            // Act
            var actual = converter.ConvertToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
