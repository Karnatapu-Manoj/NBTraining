using System;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code for Method Overriding Using new KeyWord.

// for Reference, check Day10Project4 in the same Repository. 

namespace Day10Project4
{
    class EnglishGreetings
    {
        /// <summary>
        /// This is a Hi Method, To Greetings Hi
        /// </summary>
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        /// <summary>
        /// This is a Hello Method, To Greetings Hello
        /// </summary>
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        /// <summary>
        /// This is a Good Morning, To Greeting Good Morning.
        /// </summary>
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }

    class TeluguGreetings : EnglishGreetings
    {
        public new void PrintGM()
        {
            Console.WriteLine("Subhodhayam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguGreetings obj = new TeluguGreetings();

            Console.WriteLine("\n --------- Method Overriding Using new KEY Word ---------\n");
            obj.PrintHi();
            obj.PrintHello();
            obj.PrintGM();

            Console.ReadLine();
        }
    }
}
