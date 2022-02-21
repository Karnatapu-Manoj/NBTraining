using System;
using MyConsoleApp.ServiceReference1;

// Author : Manoj.Karnatapu
// Purpose : Creating a C# Console application & Consuming the Webservices.

// For Reference, Check MyConsoleApp in the same Repository.

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlgebraMathematicsSoapClient obj = new AlgebraMathematicsSoapClient();
            Console.Write("\n Enter Any Number to find its Factorial : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe Factorial of Given Number {0} is : {1}", n, obj.Factorial(n));

            Console.WriteLine("\nEnter Any 2 Number For Arithmetic Calculations");
            Console.Write("\nEnter Value for variable(a) : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Value for variable(b) : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe Addition of {a} and {b} is : {obj.Add(a, b)}");
            Console.WriteLine($"\nThe Multiplication of {a} and {b} is : {obj.Mul(a, b)}");
            Console.WriteLine($"\nThe Division of {a} and {b} is : {obj.Div(a, b)}\n");

            Console.ReadKey();
        }
    }
}
