using System;

// Author : Manoj.Karnatapu
// Purpose : Write C# Code to Print Hello World, Using Object Oriented Approach

// For Reference, Check Day16Project1 in the same Repositpory

namespace Day16Project1
{
    class HelloWorld
    {
        /// <summary>
        /// Displaying the Hello World Message
        /// </summary>
        public void PrintMessage()
        {
            Console.WriteLine("Hello World...!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.PrintMessage();
        }
    }
}
