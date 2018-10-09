using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileParser.Tests
{
    [TestClass]
    public class FileParserTests
    {
        [TestMethod]
        [DataRow(new string[] {"test1.txt", "is"}, 7, DisplayName = "Normal txt File with 7 entries")]
        [DataRow(new string[] { "test2.txt", "is" }, 0, DisplayName = "Empty file, no entries")]
        [DataRow(new string[] { "test3.txt", "is" }, 7, DisplayName = "Strange txt File with 7 entries")]
        public void FindEntries_WhenPassedNormalFile_ReturnsNumberOfEntries(string[] args, int expectedResult)
        {
            FileParserConsole fileParser = new FileParserConsole();
            fileParser.ReadUserInput(args);

            var result = fileParser.FindEntries();

            Assert.AreEqual(result, expectedResult);
        }
    }
}
