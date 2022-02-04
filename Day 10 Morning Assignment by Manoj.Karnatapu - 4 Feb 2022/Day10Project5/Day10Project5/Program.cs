using System;

// Authot : Manoj.Karnatapu
// Purpose : Write a C# Code for Method Overriding Using virtual, override keyword.

// For Reference, check Day10Project5 in the same Repository.
namespace Day10Project5
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
        public virtual void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }


    class TeluguGreetings : EnglishGreetings
    {
        public override void PrintGM()
        {
            Console.WriteLine("Subhodhayam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguGreetings obj = new TeluguGreetings();
            EnglishGreetings obj2 = new EnglishGreetings();

            Console.WriteLine("\n ------ Method Overriding Using virtual , override KEY Word -------\n");
            obj.PrintHi();
            obj.PrintHello();
            obj2.PrintGM();
            obj.PrintGM();

            Console.ReadLine();
        }
    }
}
