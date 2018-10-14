using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FileParser.Tests
{
    [TestClass]
    public class SeekerTests
    {
        [TestMethod]        
        [DataRow( "test1.txt", "is", 13, DisplayName = "Normal txt File with 13 entries")]
        [DataRow( "test2.txt", "is", 0, DisplayName = "Empty file, no entries")]
        [DataRow( "test3.txt", "is", 13, DisplayName = "Strange txt File with 13 entries")]
        public void ParseFile_WhenCalled_ReturnsNumberOfEntries(string path, string find, int expected)
        {
            // Arrange
            Seeker seeker = new Seeker(path, find);

            // Act
            int actual = seeker.ParseFile();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
