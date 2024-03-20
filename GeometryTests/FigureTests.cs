using Geometry;
using Geometry.Figures;
namespace GeometryTests
{
    /// <summary>
    /// ������ ���������� ����� ������
    /// </summary>
    public class Rectangle : Figure
    {
        public Rectangle(params int[] sides) {
            Sides = sides;
        }

        // ���� ����� �� �����������, �� �� ����������������
        public override double GetShapeArea() =>
            Sides[0] * Sides[1];
    }

    // ����������� ����� ���� �����������, �� � �� ���� 2 ��������, ������� ����� ������ ����������
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