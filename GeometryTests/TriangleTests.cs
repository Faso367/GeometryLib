using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTests
{
    [TestClass]
    public class TriangleTests
    {

        [TestMethod]
        public void CreateTriangle_WithImpossibleSideValue_ShouldThrowArgumentException()
        {
            // Arrange, Act, Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(8, 1, 2));
        }

        [TestMethod]
        public void GetShapeArea_WithValidValues()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);
            double expected = 6;
            // Act
            double actual = triangle.GetShapeArea();
            // Assert 
            Assert.AreEqual(expected, actual, 0.001, "Площадь треугольника была вычислена некорректно");
        }

        [TestMethod]
        public void Triangle_IsRight_True()
        {
            // Arrange
            var triangle = new Triangle(5, 12, 13);
            var expected = true;
            // Act
            bool actual = triangle.IsRight;
            // Assert
            Assert.AreEqual(expected, actual, "Треугольник был ошибочно классифицирован как прямоугольный");
        }

        [TestMethod]
        public void Triangle_IsRight_False()
        {
            // Arrange
            var triangle = new Triangle(3, 3, 3);
            var expected = false;
            // Act
            bool actual = triangle.IsRight;
            // Assert
            Assert.AreEqual(expected, actual, "Треугольник был ошибочно классифицирован как прямоугольный");
        }
    }
}
