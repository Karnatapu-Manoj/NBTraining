using System;
using System.IO;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code, to write data into file/append the data Using Stream Writer Class.

// For Reference, Check Day15Project3 in the same Repository. 

namespace Day15Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are Creating a File using streamWriter Class. It will over Ride Each time we run the code
            StreamWriter sw = new StreamWriter(@"D:\C#\GitHub\StreamWriterExample.txt");
            sw.WriteLine("Hi this is Manoj");
            sw.WriteLine("This is a File Operation using StreamWriter with WriteLine Method");
            sw.Close();
            Console.WriteLine("\n Writing File Is done, by using Stream Writer Class by writeLine Method.\n");


            // We are Creating a File using streamWriter Class. It will not over Ride Each time when we run the code.
            // Instead it will Append the Text of Lines, Each time We Run the Code.
            StreamWriter writer = new StreamWriter(@"D:\C#\GitHub\StreamWriterAppendExample.txt", true);

            writer.WriteLine("This is From New object of Stream Writer,");
            writer.WriteLine("using Append by assigning True, while creating object for StreamWriter");
            writer.Close();
            Console.WriteLine("\n Appending is done, by using Stream Writer Class, By Enabling Append Method(true).");

            Console.ReadKey();
        }
    }
}
