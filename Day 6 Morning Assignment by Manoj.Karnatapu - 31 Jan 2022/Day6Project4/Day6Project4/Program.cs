using System;
using System.Collections.Generic;

// Author : Manoj.Karnatapu
//Purpose : Declare a List<string> with 5 values from the User & print the sum of it using for_loop, foreach & Lambda Expression

namespace Day6Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0, sum2 = 0, sum3 = 0;

            // Assigning Values to List 
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Enter any value into the index {0}, into the  List : ", i);
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }


            // Printing Values Using For Loop
            Console.WriteLine("\n\nPrinting The Sum of Values in the List, Using For Loop : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            for (int i = 0; i < data.Count; i++)
            {
                sum1 = sum1 + data[i];
            }
            Console.WriteLine("\n The sum of List Items Using For Loop is : {0}", sum1);

            // Printing Values Using For Each Loop
            Console.WriteLine("\n\nPrinting The Sum of Values in the List, Using For each Loop : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var d in data)
            {
                sum2 += d;
            }
            Console.WriteLine("\n The sum of List Items Using For Each Loop is : {0}", sum2);

            // Printing Values Using Lambda Expressions
            Console.WriteLine("\n\nPrinting The Sum of Values in the List, Using Lambda Expression : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            data.ForEach(d => sum3 = sum3 + d);

            Console.WriteLine("\n The sum of List Items Using For Each Loop is : {0}", sum3);

            Console.ReadLine();

        }
    }
}
