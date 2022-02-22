using System;
using System.Collections.Generic;
using DataAccessLibrary;


// Author : Manoj.Karnatapu
// Purpose : Creating a BLL for Employee Management Application.

// For Reference, Check ManojFinalProject in the same Repository.

namespace BusinessLogicLibrary
{
    public class EmployeeBLL
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            // Todo Validations

            var result = EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);
            return result;
        }
        public static List<String> GetEmployeesById(int id)
        {
            var result = EmployeeDAL.GetEmployeesById(id);
            return result;
        }
        public static List<String> GetEmployeesByName(string name)
        {
            var result = EmployeeDAL.GetEmployeesByName(name);
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}
