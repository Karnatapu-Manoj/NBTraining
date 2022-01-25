using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console Application for Adding Two Numbers
            // Code Developer By : Manoj Karnatapu (24-01-2022)

            int firstNumber , secondNumber , sum = 0;

            Console.WriteLine("Enter the First number : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            sum = firstNumber + secondNumber;
            Console.WriteLine($"The Addition of two numbers i.e., {firstNumber} and {secondNumber} is {sum}");

            Console.ReadLine();
        }
    }
}
