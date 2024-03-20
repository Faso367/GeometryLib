using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetShapeArea_WithValidValues()
        {
            // Arrange
            var circle = new Circle(5);
            double expected = 78.53981633974483;
            // Act
            double actual = circle.GetShapeArea();
            // Assert 
            Assert.AreEqual(expected, actual, 0.001, "Площадь круга была вычислена некорректно");
        }

        [TestMethod]
        public void GetShapeArea_WithNullValue()
        {
            // Arrange
            var circle = new Circle(0);
            double expected = 0;
            // Act
            double actual = circle.GetShapeArea();
            // Assert 
            Assert.AreEqual(expected, actual, 0.001, "Площадь круга была вычислена некорректно");
        }
    }
    
}
