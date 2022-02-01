using System;

// Author : Manoj.Karnatapu
// Purpose : Creating an 4 different Class with Required 2 Methods(ReadingData & PrintData) & Calling the methods.

// This is a Department Class from program.cs

namespace Day7Project2
{
    internal class Department
    {
        private int departmentId;
        private string departmentName;

        public void ReadDepartment()
        {
            Console.WriteLine("\n Enter Department ID : ");
            departmentId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Department Name : ");
            departmentName = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void DisplayDepartment()
        {
            Console.WriteLine("\n--------------- Department Details ---------------\n");
            Console.WriteLine($"\n\t Department Id : {departmentId}\n\t Department Name : {departmentName}");
        }
    }
}
