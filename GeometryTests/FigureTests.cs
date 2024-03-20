using Geometry;
using Geometry.Figures;
namespace GeometryTests
{
    /// <summary>
    /// Пример добавления новой фигуры
    /// </summary>
    public class Rectangle : Figure
    {
        public Rectangle(params int[] sides) {
            Sides = sides;
        }

        // Этот метод не тестируется, тк он пользовательский
        public override double GetShapeArea() =>
            Sides[0] * Sides[1];
    }

    // Абстрактный класс тоже тестируется, тк в нём есть 2 свойства, которые могут выдать исключения
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void CreateFigure_WithNegativeSideValue_ShouldThrowArgumentException()
        {
            // Arrange, Act, Assert
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(-1, 3));
        }

        [TestMethod]
        public void CreateFigure_WithNullSideValue_ShouldThrowArgumentException()
        {
            // Arrange, Act, Assert
            Assert.ThrowsException<ArgumentException>(() => new Rectangle(0, 4));
        }
    }
}