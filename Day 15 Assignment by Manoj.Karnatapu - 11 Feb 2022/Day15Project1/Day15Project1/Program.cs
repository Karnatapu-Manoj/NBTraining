using System;
using System.IO;
using System.Text;

// Author : Manoj.Karnatapu
// Purpose : File Operations Using atleast 10 Methods.

// For Reference, Check Day15Project1 in the same Repository.

namespace Day15Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assigning a File Path using Verbatim String Manipulation method.
            string fileName = @"D:\C#\GitHub\FileOperations.txt";

            // Creating a File with Given File Path
            StreamWriter sw = File.CreateText(fileName);

            // When we Use WriteLine Method in StreamWriter class,
            // It will Write in New Line each time it is called.
            sw.WriteLine("Hi this is my first File Operations using C# code");

            // The below statement is to have an empty line break in the file.
            sw.WriteLine("");
            sw.WriteLine("Writing Data using StringWriter, by using WriteLine Method.");

            // When We Use Write Method in StreamWriter Class,
            // it will start from the place of Cursor Exits after the last update, If Any.
            sw.Write("This Line is by Write Method");
            sw.Write("This is Second Line using Write Method\n");
            sw.Close();

            // Appending a Text 
            sw = File.AppendText(fileName);
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
            Console.WriteLine("\nFile Appending  is Done by Append_Text Method.");
            // We Need to Close the File, When ever we Create/open/Read a File, in file Operations.
            sw.Close();

            // Reading a File Using OpenText() Method
            StreamReader sr = File.OpenText(fileName);
            string s;
            Console.WriteLine("\n");
            while ((s = sr.ReadLine()) != null)
                Console.WriteLine(s);
            
            sr.Close();


            string fileNewPath = @"D:\FileOperations.txt";
            // Moving a File From One Path to Another Path
            if(File.Exists(fileNewPath))
                File.Delete(fileNewPath);
            Console.WriteLine("\nAlready the File is Present, So Deleting the old file & Creating a New File.");

            File.Move(fileName, fileNewPath);
            Console.WriteLine("\nFile Moved to New Path, Successfuly [D:/FileOperations.txt]");

            // Copying the File From NewPAth to Old path to make a Duplicate.
            /*if (File.Exists(fileName))
                File.Delete(fileName);
            Console.WriteLine("\nAlready the File is Present, So Deleting the old file & Creating a New File.");*/

            File.Copy(fileNewPath, fileName);
            Console.WriteLine("\nFile Copying is Done Successfully, to old Path\n");
            
            // Opening a Text File
            File.OpenText(fileName).Close();
            Console.WriteLine("\nFile opened Successfully, without any Errors");
            string appendText = "This is an Extra text from Append_All_Text Method";
            File.AppendAllText(fileName, appendText, Encoding.UTF8);

            Console.WriteLine("\nFile Appended with Extra Text , Successfully");

            string readText = File.ReadAllText(fileName);
            Console.WriteLine("\n\n Reading All Text From the File\n");
            Console.WriteLine(readText);

            Console.ReadLine();
        }
    }
}
