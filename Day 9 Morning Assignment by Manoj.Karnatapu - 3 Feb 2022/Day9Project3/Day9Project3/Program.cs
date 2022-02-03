using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author : Manoj.Karnatapu
//Purpose : Create an Employee Class with 4 variables, using one static variable and write methods to read & print data.

// For Reference, Check Day9Project3 in the Same Repository.

namespace Day9Project3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NB HealthCare";

        public void ReadData()
        {
            Console.Write("\nEnter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Employee Name : ");
            name = Console.ReadLine();
            Console.Write("\nEnter Employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintData()
        {
            Console.WriteLine("\n");
            Console.WriteLine($" Id : {id}, Name : {name}, Salary : {salary}, Company : {company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            // Reading Data From the User
            emp1.ReadData();
            emp2.ReadData();

            Console.WriteLine("\n\t-------------- Printing The Employee Data --------------");
            // Printing Data 
            emp1.PrintData();            
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
