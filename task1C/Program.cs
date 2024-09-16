using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region first task

class Programm
{

    static void Main()
    {

        Console.WriteLine("Min and Max values for different type: \n");
        Console.WriteLine($"Byte: min Value: {Byte.MinValue}, max value: {Byte.MaxValue}");
        Console.WriteLine($"SByte: min value: {SByte.MinValue}, max value: {SByte.MaxValue}");
        Console.WriteLine($"Int16: min value: {Int16.MinValue}, max value: {Int16.MaxValue}");
        Console.WriteLine($"UInt16: min value: {UInt16.MinValue}, max value: {UInt16.MaxValue}");
        Console.WriteLine($"Int32: min value: {Int32.MinValue}, max value: {Int32.MaxValue}");
        Console.WriteLine($"UInt32: min value: {UInt32.MinValue}, max value: {UInt32.MaxValue}");
        Console.WriteLine($"Int64: min value: {Int64.MinValue}, max value: {Int64.MaxValue}");
        Console.WriteLine($"UInt64: min value: {UInt64.MinValue}, max value: {UInt64.MaxValue}");
        Console.WriteLine($"Char: min value: {Char.MinValue}, max value: {Char.MaxValue}");
        Console.WriteLine($"Single: min value: {Single.MinValue}, max value: {Single.MaxValue}");
        Console.WriteLine($"Double: min value: {Double.MinValue}, max value: {Double.MaxValue}");
        Console.WriteLine($"Decimal: min value: {Decimal.MinValue}, max value: {Decimal.MaxValue}");
        Console.WriteLine($"Bool: {false} - {true}");

        Console.WriteLine("\n \n");

        //second task 

        Console.WriteLine("Enter 2 side of rectangle");

        Console.WriteLine("Side A:");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Side B:");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle Rectangle = new Rectangle(sideA, sideB);

        Console.WriteLine($"Area: {Rectangle.Area}");
        Console.WriteLine($"Perimetr: {Rectangle.Perimetr} \n \n");

        Console.WriteLine();
        Console.WriteLine("Task 3");
        Point firstPoint = new Point(2, 1);
        Point secondPoint = new Point(2, -3);
        Point thirdPoint = new Point(-2, -3);
        Point fourthPoint = new Point(-3, -1);
        Point fifthPoint = new Point(-1, 2);

        Figure pentagon = new Figure(firstPoint, secondPoint, thirdPoint, fourthPoint, fifthPoint);
        Figure quadrangle = new Figure(firstPoint, secondPoint, thirdPoint, fourthPoint);
        Figure triangle = new Figure(firstPoint, secondPoint, thirdPoint);

        triangle.printInfo();
        quadrangle.printInfo();
        pentagon.printInfo();
    }

}

#endregion

#region second task

public class Rectangle
{

    double sideA;
    double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.sideA = sideA;
        this.sideB = sideB;
    }

    private double CalculateArea()
    {
        return (sideA * sideB);
    }

    private double CalculatePerimetr()
    {

        return (2 * (sideA + sideB));
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimetr
    {
        get { return CalculatePerimetr(); }
    }
}
#endregion


#region third task

public class Point
{
    private int x = 0;
    private int y = 0;

    #region Конструктор
    public Point(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
    #endregion

    #region Свойства
    public int X => x;
    public int Y => y;
    #endregion

}

public class Figure
{

    #region Поля
    public Point[] points;
    #endregion

    #region Конструктор
    public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE)
    {
        points = new Point[] { pointA, pointB, pointC, pointD, pointE };
        Name = "Pentagon";
    }
    public Figure(Point pointA, Point pointB, Point pointC, Point pointD) : this(pointA, pointB, pointC, pointD, null) { Name = "Quadrangle"; }
    public Figure(Point pointA, Point pointB, Point pointC) : this(pointA, pointB, pointC, null, null) { Name = "Triangle"; }
    #endregion

    #region Свойства
    public string Name { get; set; }
    #endregion

    #region Методы
    public double LengthSide(Point pointA, Point pointB)
    {
        if (pointA == null || pointB == null) { return 0; }
        return Math.Pow(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2), 0.5);
    }
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        if (points[0] == null || points[1] == null) { return 0; }
        perimeter += LengthSide(points[0], points[1]);
        perimeter += LengthSide(points[1], points[2]);
        if (points[3] == null)
        {
            perimeter += LengthSide(points[2], points[0]);
        }
        else
        {
            perimeter += LengthSide(points[2], points[3]);
            if (points[4] == null)
            {
                perimeter += LengthSide(points[3], points[0]);
            }
            else
            {
                perimeter += LengthSide(points[3], points[4]);
                perimeter += LengthSide(points[4], points[0]);
            }
        }
        return perimeter;
    }
    public void printInfo()
    {
        Console.WriteLine($"Figure Name: {Name}, it's Perimeter: {PerimeterCalculator()}");
    }
    #endregion

}
#endregion