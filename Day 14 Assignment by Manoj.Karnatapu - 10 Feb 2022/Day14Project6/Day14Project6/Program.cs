using System;
// Author : Manoj.Karnatapu
// Purpose : Find the first number after 1000 which is divisible by 97

// for reference, Check Day14Project6 in the same Repository.
namespace Day14Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 1097; i++)
            {
                if ( i % 97 == 0 )
                {
                    Console.WriteLine("\nThe First Number after 1000 which is divisible by 97 is :  {0}",i);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
