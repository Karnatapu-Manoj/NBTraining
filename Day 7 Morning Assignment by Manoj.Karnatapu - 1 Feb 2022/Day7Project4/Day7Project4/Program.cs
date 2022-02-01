using System;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Employee class, with Employee’s array object and initialize with 5 employees. Print Output using for Loop, foreach loop & Lambda expression.

namespace Day7Project4
{
    internal class Program
    {
        class Employee
        {
            public int empId;
            public string empName;
            public int empSalary;
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee(){empId = 1, empName = "Manoj.Karnatapu", empSalary = 35000},
                new Employee(){empId = 2, empName = "Sarath Phani", empSalary = 25000},
                new Employee(){empId = 3, empName = "Vihar Dasari", empSalary =32000},
                new Employee(){empId = 4, empName = "Pavan Chira", empSalary = 38000},
                new Employee(){empId = 5, empName = "Manoj Yekkola", empSalary = 28000},
                new Employee(){empId = 6, empName = "Sai", empSalary = 20000}
            };

            // Using For Loop
            Console.WriteLine("\n\t Printing Using For Loop\n");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee Id = {employees[i].empId},  Employee Name = {employees[i].empName},  Employee Salary = {employees[i].empSalary}");
            }

            // Using For Each Loop
            Console.WriteLine("\n\t Printing Using For Each Loop\n");
            foreach(var e in employees)
            {
                Console.WriteLine($"Employee.ID = {e.empId},  Employee.Name = {e.empName},  Employee.Salary = {e.empSalary}");
            }
            // Using Lambda Expression
            Console.WriteLine("\n\t Printing Using Lambda Expression\n");

            employees.ToList().ForEach(d => Console.WriteLine($"ID = {d.empId},  Name = {d.empName},  Salary = {d.empSalary}"));

            Console.ReadLine();
        }
    }
}
