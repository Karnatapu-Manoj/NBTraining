using System;
using System.IO;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code, To Read Data From a File, Using File Operations by Stream Writer Class.

// For Reference, Check Day15Project4 in the same Repository

namespace Day15Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We are Creating a File using streamWriter Class. It will not over Ride Each time when we run the code.
            // Instead it will Append the Text of Lines, Each time We Run the Code.
            StreamWriter writer = new StreamWriter(@"D:\C#\GitHub\StreamWriterAppendExample.txt", true);

            writer.WriteLine("This is From New object of Stream Writer,");
            writer.WriteLine("using Append by assigning True, while creating object for StreamWriter");

            writer.Close();
            Console.WriteLine("\n Appending is done, by using Stream Writer Class, By Enabling Append Method(true).");

            // We Are Reading the File Content using Stream Writer Class From System.IO namespace.
            StreamReader reader = new StreamReader(@"D:\C#\GitHub\StreamWriterAppendExample.txt");

            reader.ReadToEnd();

            reader.Close();
            Console.WriteLine("\n Reading is done, by using Stream Writer Class, by ReadToEnd Method.");
            
            Console.ReadKey();
        }
    }
}
