using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToText.Classes;

namespace NumberToText.UnitTests
{
    [TestClass]
    public class ConverterUATests
    {
        [TestMethod]
        [DataRow(54890, "п'ятьдесят чотири тисячи вiсiмсот дев'яносто")]
        [DataRow(0, "нуль")]
        [DataRow(010, "десять")]
        [DataRow(12_451_223, "дванадцять мiльйонiв чотириста п'ятьдесят одна тисяча двiстi двадцять три")]
        public void ConvertToWords_ReturnsTextRepresentation(int number, string expected)
        {
            // Arrange
            ConverterEurope converter = new ConverterUA();

            // Act
            var actual = converter.ConvertToWords(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
