using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A C# Console Based Quiz Game Developed By Manoj Karnatapu.
namespace Day3Project1_Quiz_Game_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t ____::: Welcome To The Quiz Program By Manoj-Karnatapu  :::____\t\t\t\n");
            //Variable Declaration Section
            int score = 0, ans;
            string name;
            Console.Write("  Enter The Name Of The Participant :  ");
            name = Console.ReadLine();
            Console.WriteLine("\n\n=====================================================================================================================");
            Console.WriteLine($"\n\t\tHi {name}, You are About To begin The Quiz on Marvel Cinematic Universe\n");
            Console.WriteLine("=====================================================================================================================\n");
            
            //Question No:1
            Console.WriteLine("\nQ1. Which is the First Movie To watch in Marvel's Cronological Order ?");
            Console.WriteLine("\n1. Captain America  2. Captain Marvel  3. IronMan  4. Hulk\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            //Question No:2
            Console.WriteLine("\n\nQ2. Who is the First Avenger in Marvel Series ?");
            Console.WriteLine("\n1. Captain Marvel 2. Captain America  3. IronMan  4. Hulk\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            //Question No:3
            Console.WriteLine("\n\nQ3. Currently We are in Which Phase of Marvel ?");
            Console.WriteLine("\n1. Phase-One 2. Phase-Three  3. Phase-Four  4. Phase-Two\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            //Question No:4
            Console.WriteLine("\n\nQ4. Which Physics Theory of Concept is Used in Ant-Man Movie ?");
            Console.WriteLine("\n1. Pressure Theory 2. Quantum Physics  3. Big Bang  4. Multiverse\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            //Question No:5
            Console.WriteLine("\n\nQ5. What was the Wi-Fi Password of Kamar-Taj in Doctor Strange ?");
            Console.WriteLine("\n1. Infinite Stones 2. santum  3. Wenwuski  4. Shamballa\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
                score += 20;


            if (score >= 60)
            {
                Console.WriteLine("\n\n=====================================================================================================================\n");
                Console.WriteLine("\n\t  ____:::*** Congratulations {0}, you got {1}% in the Quiz ***:::____\n", name, score);
                Console.WriteLine("\n=====================================================================================================================\n");
            }
            else
            {
                Console.WriteLine("\n\n=====================================================================================================================\n");
                Console.WriteLine("\n\tSorry {0}, you have Scored {1}% in the Quiz. Try Again..!\n", name, score);
                Console.WriteLine("\n=====================================================================================================================\n");
            }
            Console.ReadLine();
        }
    }
}