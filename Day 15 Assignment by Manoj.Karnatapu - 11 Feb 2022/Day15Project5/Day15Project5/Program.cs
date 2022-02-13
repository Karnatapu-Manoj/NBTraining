using System;
using System.IO;

// Author : Manoj.Karnatapu
// Purpose : A C# Console Based Quiz Game Developed By Manoj Karnatapu. Storing Scores in a File using File Operations.

// For Reference, check Day15Project5 in the same repository.

namespace Day15Project5
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

            StreamWriter sw = new StreamWriter(@"D:\C#\NBTraining\Day 15 Assignment by Manoj.Karnatapu - 11 Feb 2022\Scores_Results.txt", true);
            sw.WriteLine(" Name : {0} \n\t Score : {1}\n", name, score);
            sw.Close();

            Console.WriteLine("\n\n=====================================================================================================================\n");
            Console.WriteLine("\n\t  ____:::*** Congratulations, Your Scores got submitted to the Admin ***:::____\n");
            Console.WriteLine("\n=====================================================================================================================\n");

            Console.ReadLine();
        }
    }
}
