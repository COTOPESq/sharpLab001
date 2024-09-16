using System.Drawing;
using Xunit;
namespace TriangleTest

{
    public class RectangleTest
    {
        [Fact]
        public void CalculateArea_correct()
        {
            double sideA = 5;
            double sideB = 10;
            Rectangle rectangle = new Rectangle(sideA, sideB);

            double area = rectangle.Area;

            Assert.Equal(50, area);
        }

        [Fact]

        public void CalculatePerimeter_correct()
        {
            double sideA = 5;
            double sideB = 10;

            Rectangle rectangle = new Rectangle(sideA, sideB);

            double perimetr = rectangle.Perimetr;

            Assert.Equal(30, perimetr);
        }



    }
}