using System;
using System.Collections.Generic;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Class of List Employees, & print Using for loop, For Each Loop, Lambda Expression & LINQ query

namespace Day8Project2
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ id = 1, name = "Manoj Karnatapu", salary = 29000},
                new Employee(){ id = 2, name = "Vihar Dasari", salary = 26000},
                new Employee(){ id = 3, name = "Pavan Kumar", salary = 28000},
                new Employee(){ id = 4, name = "Vamsi Krishna", salary = 27000},
                new Employee(){ id = 5, name = "Sarath Phani", salary = 24000}
            };

            // Printing Employee Data from the List Using For Loop
            Console.WriteLine("\n----------------- Printing Using For Loop -----------------\n");
            for(int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"id = {employees[i].id}, name = {employees[i].name}, Salary = {employees[i].salary}");
            }
            // Printing Employee Data from the List Using For Each Loop
            Console.WriteLine("\n----------------- Printing Using For Each Loop -----------------\n");
            foreach(var e in employees)
                Console.WriteLine($"Id = {e.id}, Name = {e.name}, Salary = {e.salary}");

            // Printing Employee Data from the List Using Lambda Expression
            Console.WriteLine("\n----------------- Printing Using Lambda Expression -----------------\n");
            employees.ForEach(e => Console.WriteLine($" Id = {e.id}, Name = {e.name}, Salary = {e.salary}"));

            // Printing Employee Data from the List Using LINQ Query
            Console.WriteLine("\n----------------- Printing Using LINQ Query -----------------\n");
            var result = from e in employees
                         select e;

            result.ToList().ForEach(e => Console.WriteLine($"Id = {e.id}, Name = {e.name}, Salary = {e.salary}"));

            Console.ReadLine();
        }
    }
}
