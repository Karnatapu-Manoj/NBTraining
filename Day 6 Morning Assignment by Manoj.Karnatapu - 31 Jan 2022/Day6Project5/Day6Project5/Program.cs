using System;

namespace Day6Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            // Type Casting short to int

            short myShort = 10;
            int myInt = myShort;

            Console.WriteLine("Implicit Conversion of short to int is : {0}",myInt);

            // Explicit Conversion
            // Casting double to int

            double myDouble = 13.37;
            int myNewInt = (int)myDouble;
            Console.WriteLine("Explicit Conversion of double to int is : {0}",myNewInt);
            Console.ReadLine();
        }
    }
}
