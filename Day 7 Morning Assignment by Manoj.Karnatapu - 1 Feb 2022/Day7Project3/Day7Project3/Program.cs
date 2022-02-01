using System;

// Author : Manoj.Karnatapu
// Purpose : Create Employee Class with 3 Public variables. Crete object and initialize with values while creating object and print the values.

namespace Day7Project3
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public int employeeAge;
        public int employeeSalary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() {employeeId = 310596, employeeName = "Manoj.Karnatapu", employeeAge = 25, 
             employeeSalary = 35000};

            Console.WriteLine($"\n\t Employee Id = {emp.employeeId},\n\t Employee Name = {emp.employeeName}," +
                $"\n\t Employee Age = {emp.employeeAge},\n\t Employee Salary = {emp.employeeSalary}");

            Console.ReadLine();
        }
    }
}
