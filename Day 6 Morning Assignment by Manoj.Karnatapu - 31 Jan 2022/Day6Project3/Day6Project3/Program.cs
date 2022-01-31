using System;
using System.Collections.Generic;

// Author : Manoj.Karnatapu
//Purpose : Declare a List<string> with 5 values & print values using for_loop, foreach & Lambda Expression

namespace Day6Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>  data = new List<string>();
            data.Add("Manoj");
            data.Add("Sai");
            data.Add("Vihar");
            data.Add("Pavan");
            data.Add("Sharath");

            // Printing Values Using For Loop
            Console.WriteLine("\nPrinting The Items of the List, Using For Loop : ");
            for (int i=0;i < data.Count; i++)
            {
                Console.WriteLine("\t// {0} //",data[i]);
            }
            Console.WriteLine();

            // Printing Values Using For Each Loop
            Console.WriteLine("\nPrinting The Items of the List, Using For Each Loop : ");
            foreach(var d in data)
            {
                Console.WriteLine("\t// {0} //",d);
            }
            Console.WriteLine();

            // Printing Values Using Lambda Expressions
            Console.WriteLine("\nPrinting The Items of the List, Using Lambda Expression : ");
            data.ForEach(d => Console.WriteLine("\t// {0} //",d));

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
