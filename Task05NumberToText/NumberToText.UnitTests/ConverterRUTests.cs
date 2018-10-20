using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToText.Classes;

namespace NumberToText.UnitTests
{
    [TestClass]
    public class ConverterRUTests
    {
        [TestMethod]
        [DataRow(54890, "пятьдесят четыре тысячи восемьсот девяносто")]
        [DataRow(0, "ноль")]
        [DataRow(010, "десять")]
        [DataRow(12_451_223, "двенадцать миллионов четыреста пятьдесят одна тысяча двести двадцать три")]
        public void ConvertToWords_ReturnsTextRepresentation(int number, string expected)
        {
            // Arrange
            ConverterEurope converter = new ConverterRU();

            // Act
            var actual = converter.ConvertToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
