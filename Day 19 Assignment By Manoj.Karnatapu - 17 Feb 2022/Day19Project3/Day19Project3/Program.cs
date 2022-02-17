using System;
using System.Xml;

// Author : Manoj.Karnatapu
// Purpose : C# Code To read Xml Data from a Xml file & printing the data of Only Names to the Console.

// For Reference, Check Day19Project3 in the same Repository.

namespace Day19Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\C#\GitHub\Day19Project1\TagBasedXML.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "ID")
                    {
                        Console.Write("{0}, ",childNode.InnerText);
                    }
                    if (childNode.Name == "Name")
                    {
                        Console.Write("{0}, ", childNode.InnerText);
                    }
                    if (childNode.Name == "Price")
                    {
                        Console.Write("{0}\n", childNode.InnerText);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
