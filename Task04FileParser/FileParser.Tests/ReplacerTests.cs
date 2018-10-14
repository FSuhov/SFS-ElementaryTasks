using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileParser.Tests
{
    [TestClass]
    public class ReplacerTests
    {
        [TestMethod]
        [DataRow("test1.txt", "is", "REPLACED", 13, DisplayName = "Normal txt File with 13 entries")]
        [DataRow("test2.txt", "is", "REPLACED", 0, DisplayName = "Empty file, no entries")]
        [DataRow("test3.txt", "is", "REPLACED", 13, DisplayName = "Strange txt File with 13 entries")]
        public void ParseFile_WhenCalled_ReturnsNumberOfEntries(string path, string find, string replace, int expected)
        {
            // Arrange
            Replacer replacer = new Replacer(path, find, replace);

            // Act
            int actual = replacer.ParseFile();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
