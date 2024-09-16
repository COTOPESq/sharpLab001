using System.Drawing;
using Xunit;

public class FigureTests
{
    [Fact]
    public void TestTrianglePerimeter()
    {
        Point point1 = new Point(0, 0);
        Point point2 = new Point(0, 3);
        Point point3 = new Point(4, 0);
        Figure triangle = new Figure(point1, point2, point3);

        double perimeter = triangle.PerimeterCalculator();

        Assert.Equal(12, perimeter, 2);
    }

    [Fact]
    public void TestQuadranglePerimeter()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 3);
        Point p3 = new Point(3, 3);
        Point p4 = new Point(3, 0);
        Figure quadrangle = new Figure(p1, p2, p3, p4);

        double perimeter = quadrangle.PerimeterCalculator();

        Assert.Equal(12, perimeter, 2);
    }

    [Fact]
    public void TestPentagonPerimeter()
    {
        // Arrange
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 3);
        Point p3 = new Point(3, 3);
        Point p4 = new Point(3, 0);
        Point p5 = new Point(1, 1);
        Figure pentagon = new Figure(p1, p2, p3, p4, p5);

        double perimeter = pentagon.PerimeterCalculator();

        Assert.True(perimeter > 0);
    }
}
