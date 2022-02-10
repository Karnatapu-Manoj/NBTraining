using System;

// Author : Manoj.Karnatapu
// Purpose : C# Code to illustrate using Auto-Implemented Properties (No private or public classlevel Variables).

// for Reference, check Day14Project3 in the same repository.
namespace Day14Project3
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public int Salary
        {
            get
            {
                if (Designation == "M")
                    return 90000;
                else if (Designation == "HR")
                    return 50000;
                else if (Designation == "TL")
                    return 75000;
                else
                    return 30000;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ------**** NB Salary Details (Using Auto-Implemented Properties) ****------\n");
            Employee emp = new Employee();
            emp.Id = 100;
            emp.Name = "Mohan Sir";
            emp.Designation = "M";
            //emp.Salary = (emp.Designation == "M") ? 90000 : 60000;

            Console.WriteLine($"\n {emp.Id}\t {emp.Name}\t {emp.Salary}");

            Employee emp1 = new Employee();
            emp1.Id = 101;
            emp1.Name = "J.K";
            emp1.Designation = "TL";

            Console.WriteLine($"\n {emp1.Id}\t {emp1.Name}\t\t {emp1.Salary}");

            Employee emp2 = new Employee();
            emp2.Id = 102;
            emp2.Name = "Durga Prasad";
            emp2.Designation = "HR";

            Console.WriteLine($"\n {emp2.Id}\t {emp2.Name}\t {emp2.Salary}");

            Employee emp3 = new Employee();
            emp3.Id = 103;
            emp3.Name = "Manoj";
            emp3.Designation = "S";

            Console.WriteLine($"\n {emp3.Id}\t {emp3.Name}\t\t {emp3.Salary}");

            Console.ReadLine();
        }
    }
}
