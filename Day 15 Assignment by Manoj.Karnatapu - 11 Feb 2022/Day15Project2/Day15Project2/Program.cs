using System;
using System.IO;

// Author : Manoj.Karnatapu
// Purpose : Write a C# Code, to copy from one folder to another folder, by scheduling the job using Task Schedular in Windows OS.

// For Reference, Check Day15Project2 in the same Repository.
namespace Day15Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\C#\GitHub\FileOperations.txt";

            string TaskSchedularPath = @"D:\C#\TaskSchedular\TaskSchedularPath.txt";
            if(File.Exists(TaskSchedularPath))
                File.Delete(TaskSchedularPath);

            File.Copy(filePath, TaskSchedularPath);

            Console.WriteLine("File Copying is Done");

            Console.WriteLine("\n Task Schedular Executed the Given Operation, Succesfully.");
            Console.ReadKey();
        }
    }
}
