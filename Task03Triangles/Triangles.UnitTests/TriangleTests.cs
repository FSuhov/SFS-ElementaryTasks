using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangles.UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow("first", 2, 3, 4, "second", 1, 2, 3, -1)]
        [DataRow("first", 2, 3, 4, "second", 5, 6, 8, 1)]
        [DataRow("first", 2, 3, 4, "second", 2, 3, 4, 0)]
        public void CompareTo_whenCalled_ReturnComparisonResult(string name1, double a1, double b1, double c1,
                                                                string name2, double a2, double b2, double c2,
                                                                int expectedResult)
        {
            Triangle triangle1 = new Triangle(name1, a1, b1, c1);
            Triangle triangle2 = new Triangle(name2, a2, b2, c2);
            var result = triangle1.CompareTo(triangle2);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
