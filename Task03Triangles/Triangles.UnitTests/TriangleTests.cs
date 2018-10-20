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
        [DataRow("first", 2.5, 3.2, 4.9, "second", 1.8, 2.3, 3.99, -1)]
        [DataRow("first", 590_467_001.987, 3_256_789_000.2, 4_200_876.944, "second", 6_432_900_456.8, 2_000_944_599.34, 3_456_800.99, 1)]
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
