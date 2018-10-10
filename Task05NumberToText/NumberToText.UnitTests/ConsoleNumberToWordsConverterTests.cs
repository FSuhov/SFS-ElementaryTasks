using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToText.UnitTests
{
    [TestClass]
    public class ConsoleNumberToWordsConverterTests
    {
        [TestMethod]
        [DataRow(new string[] { }, ConsoleNumberToWordsConverter.InputStatus.noArgs, DisplayName = "No arguments passed, returns false")]
        [DataRow(new string[] {"asdd "}, ConsoleNumberToWordsConverter.InputStatus.invalidArgs, DisplayName = "Invalid arguments passed, returns false")]
        [DataRow(new string[] {"54890" }, ConsoleNumberToWordsConverter.InputStatus.validArgs, DisplayName = "Correct arguments passed, returns true")]
        [DataRow(new string[] { "54890077878787655" }, ConsoleNumberToWordsConverter.InputStatus.invalidArgs, DisplayName = "Too big number passed, returns false")]
        public void ReadAndValidateNumber_SetsInputStatus(string[]args, ConsoleNumberToWordsConverter.InputStatus expectedResult)
        {
            // Arrange
            ConsoleNumberToWordsConverter converter = new NumberToText.ConsoleNumberToWordsConverter();

            // Act
            converter.ReadAndValidateNumber(args);

            //Assert
            Assert.AreEqual(expectedResult, converter.Status);
        }

        [TestMethod]
        [DataRow(0, "zero")]
        [DataRow(11, "eleven")]
        [DataRow(910009, "nine hundred and ten thousand and nine")]
        public void ConvertNumberToWords_WhenCalled_SetsWords(int number, string expectedResult)
        {
            // Arrange
            ConsoleNumberToWordsConverter converter = new NumberToText.ConsoleNumberToWordsConverter();
            converter.ReadAndValidateNumber(new string[] { number.ToString() });

            // Act
            converter.ConvertNumberToWords();

            // Assert
            Assert.AreEqual(expectedResult, converter.Words);

        }
    }
}
