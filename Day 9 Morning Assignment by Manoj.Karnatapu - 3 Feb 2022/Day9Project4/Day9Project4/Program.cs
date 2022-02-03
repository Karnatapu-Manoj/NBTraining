using System;

// Author : Manoj.Karnatapu
//Purpose : Create an Employee Class with, two constructors and write methods to read & print data.

namespace Day9Project4
{
    internal class Program
    {
        class Employee
        {
            public int id;
            public string name;
            public int salary;
            public static string company = "NB HealthCare";
            
            /// <summary>
            /// This is a Default Constructor
            /// </summary>
            public Employee()
            {
                this.id = 0;
                this.name = null;
                this.salary = 0;
            }
            /// <summary>
            /// This is a Constructor with Values of 
            /// </summary>
            /// <param name="eid">Employee Id</param>
            /// <param name="ename">Employee Name</param>
            /// <param name="esalary">Employee Salary</param>
            public Employee(int eid, string ename, int esalary)
            {
                this.id = eid;
                this.name = ename;
                this.salary = esalary;
            }


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
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(230489, "Manoj.Karnatapu", 30000);

            // Reading Data From the User
            emp1.ReadData();
            Console.WriteLine("\n\t---------- Printing The Employee Data Using Default Constructor ----------");
            emp1.PrintData();

            // Printing Data Using Constructor
            Console.WriteLine("\n\t---------- Printing The Employee Data Using Constructor ----------");
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}