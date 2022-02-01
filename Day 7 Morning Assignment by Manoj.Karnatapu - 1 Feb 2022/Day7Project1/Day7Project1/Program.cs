using System;

// Author : Manoj.Karnatapu
// Purpose : Creating an Emplyee Class with 2 Methods(ReadEmployee & PrintEmployee) & Calling the methods.
namespace Day7Project1
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        // ReadEmployee Method to read the data from the user
        public void ReadEmployee()
        {
            Console.WriteLine("\nEnter Employee ID : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Employee Name : ");
            name = Console.ReadLine();

            Console.WriteLine("\nEnter Employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        // PrintEmployee Method will print the data of the Employee
        public void PrintEmployee()
        {
            Console.WriteLine($"\nId = {id}, Name = {name}, Salary = {salary}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadEmployee();
            emp1.PrintEmployee();

            Console.ReadLine();
        }
    }
}
