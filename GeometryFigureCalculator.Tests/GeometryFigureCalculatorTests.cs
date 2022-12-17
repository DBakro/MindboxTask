using GeometryFigureCalculator.Figures;

namespace GeometryFigureCalculator.Tests
{
    public class GeometryFigureCalculatorTests
    {

        /// <summary>
        /// ���� �������������� �������
        /// </summary>
        [Fact]
        public void CircleNegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
        }

        /// <summary>
        /// ���� ������������� ������ ������������
        /// </summary>
        [Fact]
        public void TriangleNegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -4, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, -4, -5));
        }

        /// <summary>
        /// ���� ������� ������������
        /// </summary>
        [Fact]
        public void TriangleSquare()
        {
            IGeometryFigure geometryFigure = new Triangle(3, 4, 5);
            double square = geometryFigure.CalculateSquare();
            Assert.Equal(6, square);
        }

        /// <summary>
        /// ���� ������� �����
        /// </summary>
        [Fact]
        public void CircleSquare()
        {
            IGeometryFigure geometryFigure = new Circle(5);
            double square = geometryFigure.CalculateSquare();
            Assert.Equal(78.54, Math.Round(square, 2));
        }

        /// <summary>
        /// ���� �����������, ��� ����������� �������������
        /// </summary>
        [Fact]
        public void RightTringle()
        {
            Triangle triangle = new (6, 8, 10);
            bool isRightTringle = triangle.IsRightTringle();
            Assert.True(isRightTringle);
        }

        /// <summary>
        /// ���� �����������, ��� ����������� �� �������������
        /// </summary>
        [Fact]
        public void NotRightTringle()
        {
            Triangle triangle = new (3, 4, 6);
            bool isRightTringle = triangle.IsRightTringle();
            Assert.False(isRightTringle);
        }
    }
}