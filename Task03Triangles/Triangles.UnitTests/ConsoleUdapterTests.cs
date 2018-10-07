using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangles.UnitTests
{
    [TestClass]
    public class ConsoleUdapterTests
    {
        [TestMethod]
        public void MakeShape_WhenCalledWithCorrectArguments_ReturnShape()
        {
            ConsoleUserAdapter userAdapter = new ConsoleUserAdapter();
            Triangle template = new Triangle("first", 4, 5, 6);
            Triangle triangle = (Triangle)userAdapter.MakeShape("First,4,5,6");

            var result = (triangle!= null) && 
                         (template.Name == triangle.Name &&
                          template.SideA == triangle.SideA &&
                          template.SideB == triangle.SideB &&
                          template.SideC == triangle.SideC);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void MakeShape_WhenCalledWithIncorrectArguments_ReturnNull()
        {
            ConsoleUserAdapter userAdapter = new ConsoleUserAdapter();
            Triangle template = new Triangle("First", 4, 5, 6);
            Triangle triangle = userAdapter.MakeShape("First,4,g,6") as Triangle;

            var result = (triangle != null) &&
                         (template.Name == triangle.Name &&
                          template.SideA == triangle.SideA &&
                          template.SideB == triangle.SideB &&
                          template.SideC == triangle.SideC);
            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void MakeShape_WhenCalledNoArguments_ReturnNull()
        {
            ConsoleUserAdapter userAdapter = new ConsoleUserAdapter();
            Triangle template = new Triangle("First", 4, 5, 6);
            Triangle triangle = userAdapter.MakeShape("") as Triangle;

            var result = (triangle != null) &&
                         (template.Name == triangle.Name &&
                          template.SideA == triangle.SideA &&
                          template.SideB == triangle.SideB &&
                          template.SideC == triangle.SideC);
            Assert.AreEqual(result, false);
        }
    }
}
