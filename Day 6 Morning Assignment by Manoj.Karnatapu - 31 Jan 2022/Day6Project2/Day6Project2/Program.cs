using System;
using System.Collections.Generic;

//Author : Manoj.Karnatapu
//Purpose : Declare a List<int> with 5 values & find Sum

namespace Day6Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();

            int sum = 0;

            data.Add(5);
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(50);

            foreach(int i in data)
            {
                sum = sum + i;
            }

            Console.WriteLine("The Sum Of given List items is : {0}", sum);

            Console.ReadLine();
        }
    }
}
