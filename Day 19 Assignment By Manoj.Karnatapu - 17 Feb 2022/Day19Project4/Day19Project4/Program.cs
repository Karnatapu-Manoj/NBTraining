using System;
using System.Xml;

// Author : Manoj.Karnatapu
// Purpose : C# Code To read Xml Data from a Xml file & printing the data name for the User Given ID.

// For Reference, Check Day19Project4 in the same Repository.

namespace Day19Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter Any ID Number from 1- 10, To find the Product : ");
            int input = int.Parse(Console.ReadLine());
            
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\C#\GitHub\Day19Project4\AttributeBasedXML.xml");
            var Mobile = doc.GetElementsByTagName("Mobile")[input - 1].Attributes["Name"].Value;

            Console.WriteLine(Mobile);   

            Console.ReadLine();
        }
    }
}
