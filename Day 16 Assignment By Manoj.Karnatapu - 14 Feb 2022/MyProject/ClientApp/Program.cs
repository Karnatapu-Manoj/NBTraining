using System;
using ManojLibrary;
using PublicLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating MyProject Solution with Built-in ManojLibrary & PublicLibrary

// For Reference, Check MyProject in the Same Repository.

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nAddition of 5 & 6 is : ");
            Mathematics.Addition(5, 6);
            Console.Write("\nSubtraction of 7 & 3 is : ");
            Mathematics.Subtraction(7, 3);
            Console.Write("\nMultiplication of 8 & 4 is : ");
            Mathematics.Multiplication(8, 4);
            Console.Write("\nDivision of 9 / 5 is : ");
            Mathematics.Division(9, 5);

            Console.Write("\nFinal Velocity is : ");
            Physics.FinalVelocity(5, 5, 5);
            Console.Write("\nCalculated Force is : ");
            Physics.ForceCalculation(10, 5);

            Console.Write("\nBenzene Formula is :  ");
            Chemistry.Benzene();
            Console.Write("\nWater Formula is : ");
            Chemistry.Water();

            Console.ReadLine();
        }
    }
}
