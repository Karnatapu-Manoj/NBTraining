using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Application for Calculating "a POWER b" using for loop
            // Code Developed by : Manoj Karnatapu (24-01-2022)

            int firstNumber , secondNumber , p = 1;

            Console.WriteLine("Enter Number, to Calculate the power of...");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter the Power Value of {firstNumber} to calculate : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= secondNumber; i++)
                p = p * firstNumber;

            Console.WriteLine($"The {firstNumber} power {secondNumber} is : {p}");

            Console.ReadLine();
        }
    }
}
