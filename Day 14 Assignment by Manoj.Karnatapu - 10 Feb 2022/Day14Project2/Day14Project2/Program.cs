using System;

// Author : Manoj.Karnatapu
// Purpose : C# Code to illustrate Normal properties i.e.,{using only get , only set & both set and get Methods.}

// for Reference, check Day14Project2 in the same repository.

namespace Day14Project2
{
    class Employee
    {
        private int id;
        private string name;
        private string designation;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Designation
        {
            // Setting only Write Only Property
            set { designation = value; }
        }
        public int Salary
        {
            get
            {
                if (designation == "M")
                    return 90000;
                else if (designation == "HR")
                    return 50000;
                else if (designation == "TL")
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
            Console.WriteLine("\n --------------**** NB Salary Details ****--------------\n");
            Employee emp = new Employee();
            emp.Id = 100;
            emp.Name = "Mohan Sir";
            emp.Designation = "M";
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
