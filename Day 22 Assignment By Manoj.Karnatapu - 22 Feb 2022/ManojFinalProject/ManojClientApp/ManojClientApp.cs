using System;
using BusinessLogicLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating a Client App for Employee Management Application.

// For Reference, Check ManojFinalProject in the same Repository.

namespace ManojClientApp
{
    public class ManojClientApp
    {
        public static void Main(string[] args)
        {
            string choice;
            int ch;
            do
            {
                Console.WriteLine("\n\n-------- Welcome To Employee Management application By Manoj.Karnatapu -------- \n");
                Console.WriteLine("\n\t -------***** Employee Management Application *****-------\n\n");
                Console.WriteLine("\t 1. Add Employee Details");
                Console.WriteLine("\t 2. Search Employee By Id");
                Console.WriteLine("\t 3. Search Employee By Name");
                Console.WriteLine("\t 4. Display All Employee Details");

                Console.Write("\n Enter Your Choice :  ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        SearchEmployeeById();
                        break;
                    case 3:
                        SearchEmployeeByName();
                        break;
                    case 4:
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.Write("\nDo You Wish to Continue to Main Menu (y/n): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                choice = Console.ReadLine();
                Console.ResetColor();
            } while (choice == "y" || choice == "Y");

            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("\n Thank You For Using Manoj_Client_Application ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n \t *** Visit Again *** ");
            Console.ResetColor();

            Console.ReadLine();
        }
        
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;

            Console.Write("\nEnter the Employee Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Employee Name : ");
            name = Console.ReadLine();
            Console.Write("\nEnter the Employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Employee Age : ");
            age = Convert.ToInt32(Console.ReadLine());

            var result = EmployeeBLL.AddEmployee(id, name, salary, age);

            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n  Employee Details Saved Succesfully");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n  Error occured During Saving The Given Data, Please Try Again");
                Console.ResetColor();
            }

        }

        public static void SearchEmployeeById()
        {
            int id;
            Console.Write("\nEnter any ID to Search Employee_Details_By_ID :  ");
            id =Convert.ToInt32(Console.ReadLine());
            var result = EmployeeBLL.GetEmployeesById(id);

            if(result.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo Records, Found With This ID");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\n The Employee Details For Given Id : \n");
                Console.ForegroundColor = ConsoleColor.Green;
                result.ForEach(e => Console.WriteLine("\t{0}",e));
                Console.ResetColor();
            }
        }
        
        public static void SearchEmployeeByName()
        {
            string name;
            Console.Write("\nEnter any NAME, To Search_Employee_Details_By_Name :  ");
            name =Console.ReadLine();

            var result = EmployeeBLL.GetEmployeesByName(name);

            if( result.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo Employee Details, Found with Given Name '{0}' ",name);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("\n     The Employees, whose names Consists '{0}' are :  \n",name);
                Console.ForegroundColor = ConsoleColor.Green;
                result.ForEach(emp => Console.WriteLine("\t{0}",emp));
                Console.ResetColor();
            }

        }
        public static void DisplayAllEmployees()
        {
            var employees = EmployeeBLL.GetAllEmployees();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\n\n\t\t ---- Displaying All Employee Details in the Record ----\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var employee in employees)
            { 
                Console.WriteLine(employee);
            }
            Console.ResetColor();
        }
    }
}
