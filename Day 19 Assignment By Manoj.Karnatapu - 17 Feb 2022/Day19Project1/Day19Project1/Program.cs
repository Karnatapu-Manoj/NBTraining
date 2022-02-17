using System;
using System.Xml;

// Author : Manoj.Karnatapu
// Purpose : C# Code To read Xml data from a Xml file & printing the data to the Console.

// For Reference, Check Day19Project1 in the same Repository.

namespace Day19Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\C#\GitHub\Day19Project1\TagBasedXML.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}
