using System;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Employee class, with Employee’s array object and initialize with 5 employees & write C# code to print employees who is getting salary >= 30,000 using for loop, foreach loop & Lambda expression.

namespace Day7Project5
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
            Console.WriteLine("\n\t Printing Salary >= 30,000/- Using For Loop\n");
            for (int i = 0; i < employees.Length; i++)
            {
                if(employees[i].empSalary >= 30000)
                    Console.WriteLine($"Employee ID = {employees[i].empId}, Employee Name = {employees[i].empName},  Employee Salary = {employees[i].empSalary}");
            }

            // Using For Each
            Console.WriteLine("\n\t Printing Salary >= 30,000/- Using For Each Loop\n");
            foreach (var e in employees)
            {
                if(e.empSalary >= 30000)
                    Console.WriteLine($"Employee.ID = {e.empId},  Employee.Name = {e.empName},  Employee.Salary = {e.empSalary}");
            }

            // Using Lambda Expression
            Console.WriteLine("\n\t Printing Salary >= 30,000/- Using Lambda Expression\n");
            employees.ToList().Where(e => e.empSalary >= 30000).ToList().ForEach(e => Console.WriteLine($"ID = {e.empId},  Name = {e.empName},  Salary = {e.empSalary}"));

            Console.ReadLine();
        }
    }
}
