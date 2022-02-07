using System;

// Author : Manoj.Karnatapu
// purpose : Write example program for interfaces discussed in the class IShape include the classes Cricle, Square, Triangle, Rectangle

// For Reference, check Day11Project1 in the same repository.

namespace Day11Project1
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }

    class Circle : IShape
    {
        private int radius;
        public void ReadRadius()
        {
            Console.Write("\nEnter Radius Value : ");
            radius = Convert.ToInt32(Console.ReadLine());

        }
        public int CalculateArea()
        {
            return 22 * radius * radius / 7;
        }

        public int CalculatePerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }
    class Square : IShape
    {
        private int side;
        public void ReadSide()
        {
            Console.Write("\nEnter Side of a Square : ");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return 4 * side;
        }
        public int CalculateArea()
        {
            return side * side;
        }
    }
    class Rectangle : IShape
    {
        private int length;
        private int width;  
        public void ReadSide()
        {
            Console.Write("\nEnter Length of a Rectangle : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter width of a Rectangle : ");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return 2 * (length + width);
        }
        public int CalculateArea()
        {
            return length * width;
        }
    }
    class Triangle : IShape
    {
        private int side1;
        private int side2;
        private int side3;
        public void ReadSides()
        {
            Console.Write("\nEnter Side-1 of a Triangle : ");
            side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter side-2 of a Triangle : ");
            side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter side-3 of a Triangle : ");
            side3 = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }
        public int CalculateArea()
        {
            double semiperimeter = (side1 + side2 + side3) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - side1) *(semiperimeter - side2) * (semiperimeter - side3));
            return Convert.ToInt32(Area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.ReadRadius();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nThe Perimeter of Circle is :  {circle.CalculatePerimeter()}");
            Console.WriteLine($"\nThe Area of Circle is :  {circle.CalculateArea()}");
            Console.WriteLine("\n ----------------------------------------------------------- \n");

            Square square = new Square();
            square.ReadSide();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nThe Perimeter of Square is : {square.CalculatePerimeter()}");
            Console.WriteLine($"\nThe Area of Square is : {square.CalculateArea()}");
            Console.WriteLine("\n ----------------------------------------------------------- \n");

            Rectangle rectangle = new Rectangle();
            rectangle.ReadSide();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nThe Perimeter of a Rectangle is : {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"\nThe Area of a Rectangle is : {rectangle.CalculateArea()}");
            Console.WriteLine("\n ----------------------------------------------------------- \n");

            Triangle tri = new Triangle();
            tri.ReadSides();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nThe Perimeter of a given Triangle is : {tri.CalculatePerimeter()}");
            Console.WriteLine($"\nThe Area of a Triangle is : {tri.CalculateArea()}");
            Console.WriteLine("\n ----------------------------------------------------------- \n");

            Console.ReadLine();
        }
    }
}
