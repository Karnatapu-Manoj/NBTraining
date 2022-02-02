using System;
using System.Collections.Generic;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Class of List Departments, & print Department(Id & Name) Whose EmpCount is > 50,Using for, foreach, Lambda & LINQ.

namespace Day8Project4
{
    class Department
    {
        public int id;
        public string name;
        public int empCount;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>()
            {
                new Department() { id = 1, name = "Packing", empCount = 780},
                new Department() { id = 2, name = "Transportation", empCount = 350},
                new Department() { id = 3, name = "System Admin", empCount = 58},
                new Department() { id = 4, name = "Managers", empCount = 20}
            };

            // Printing Department (Id & Name), Where empCount > 50 Using For Loop
            Console.WriteLine("\n----------------- Printing Department (Id & Name), Where empCount > 50 Using For Loop -----------------\n");
            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].empCount > 50)
                {
                    Console.WriteLine($"\nDepartment Id = {departments[i].id}\t\t Department Name = {departments[i].name}");
                }
            }


            // Printing Department (Id & Name), Where empCount > 50 Using For Each Loop
            Console.WriteLine("\n----------------- Printing Department (Id & Name), Where empCount > 50 Using For Each Loop -----------------\n");
            foreach (var d in departments)
            {
                if (d.empCount > 50)
                    Console.WriteLine($"\nDepartment Id = {d.id}\t\t Department Name = {d.name}");
            }

            // Printing Department (Id & Name), Where empCount > 50 Using Lambda Expression
            Console.WriteLine("\n----------------- Printing Department (Id & Name), Where empCount > 50 Using Lambda Expression -----------------\n");
            departments.Where(d => d.empCount > 50).ToList().ForEach(d => Console.WriteLine($"\nDepartment Id = {d.id}\t\t Department Name = {d.name}"));

            // Printing Department (Id & Name), Where empCount > 50 Using LINQ Query.
            Console.WriteLine("\n----------------- Printing Department (Id & Name), Where empCount > 50 Using LINQ Query -----------------\n");
            var result = from d in departments
                         where d.empCount > 50
                         select d;

            result.ToList().ForEach(d => Console.WriteLine($"\nDepartment Id = {d.id}\t\t Department Name = {d.name}"));
            Console.ReadLine();
        }
    }
}
