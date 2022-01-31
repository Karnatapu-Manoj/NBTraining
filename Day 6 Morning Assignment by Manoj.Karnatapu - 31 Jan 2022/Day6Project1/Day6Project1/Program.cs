using System;
using System.Collections;

// Author: Manoj.Karnatapu
// Purpose : To Declare ArrayList, assign some Values & Find Sum/

namespace Day6Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();

            int sum = 0;

            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            foreach(var d in data)
            {
                sum = sum + (int)d;
            }

            Console.WriteLine("The Sum of Array List items is : {0}", sum);

            Console.ReadLine();

        }
    }
}
