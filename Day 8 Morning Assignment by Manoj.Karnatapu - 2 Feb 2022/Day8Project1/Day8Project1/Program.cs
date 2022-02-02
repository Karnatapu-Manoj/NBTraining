using System;
using System.Collections.Generic;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create a List of 8 Random Numbers, Find Even Numbers using for loop, foreach loop, lambda expression & LINQ Querry.

namespace Day8Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>() { 49, 56, 34, 22, 77, 95, 138, 139, 52};

            // Printing The Even Numbers From List Using For Loop
            Console.WriteLine("\n------------ Printing Using For Loop ------------\n");
            for(int i = 0; i < data.Count; i++)
            {
                if(data[i]%2 == 0)
                    Console.WriteLine("\t{0}",data[i]);
            }

            // Printing The Even Numbers From List Using For Each Loop
            Console.WriteLine("\n------------ Printing Using For Each Loop ------------\n");
            foreach(var d in data)
            {
                if(d%2 == 0)
                    Console.WriteLine("\t{0}",d);
            }

            // Printing The Even Numbers From List Using Lambda Expression
            Console.WriteLine("\n------------ Printing Using Lambda Expression ------------\n");
            data.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine("\t{0}",x));

            // Printing The Even Numbers From List Using Linq Query
            Console.WriteLine("\n------------ Printing Using LinQ Query ------------\n");

            var result = from d in data 
                         where d % 2 == 0
                         select d;

            result.ToList().ForEach(x => Console.WriteLine("\t{0}",x));

            Console.ReadLine();
        }
    }
}
