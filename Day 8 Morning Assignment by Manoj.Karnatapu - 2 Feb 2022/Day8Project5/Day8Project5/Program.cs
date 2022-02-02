using System;
using System.Collections.Generic;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Own Class with variables, & Print Using for loop, For Each Loop, Lambda Expression & LINQ query

namespace Day8Project5
{
    class Banking
    {
        public string bankName;
        public int accNo;
        public string name;
        public int balance;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Banking> banks = new List<Banking>()
            {
                new Banking(){ bankName = "SBI", accNo = 63242692, name = "Manoj Karnatapu", balance = 25000},
                new Banking(){ bankName = "HDFC", accNo = 38762643, name = "Vamsi Krishna", balance = 2000},
                new Banking(){ bankName = "IDFC", accNo = 69364846, name = "Pavan Kumar", balance = 5080},
                new Banking(){ bankName = "AXIS", accNo = 93142007, name = "   Vihar Dasari", balance = 28000},
                new Banking(){ bankName = "ICICI", accNo = 54385409, name = "Sarath Phani", balance = 15000}
            };

            // Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using For Loop

            Console.WriteLine("\n----- Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using For Loop -----\n");
            for (int i = 0; i < banks.Count; i++)
            {
                if (banks[i].balance > 20000)
                {
                    Console.WriteLine($"\nBank : {banks[i].bankName},\t Account No. : {banks[i].accNo},\t Account Name : {banks[i].name},\t Account Balance : {banks[i].balance}");
                }
            }


            // Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using For Each Loop

            Console.WriteLine("\n----- Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using For Each Loop -----\n");
            foreach (var d in banks)
            {
                if (d.balance > 20000)
                    Console.WriteLine($"\nBank : {d.bankName},\t Account No. : {d.accNo},\t Account Name : {d.name},\t Account Balance : {d.balance}");
            }

            // Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using Lambda Expression

            Console.WriteLine("\n----- Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using Lambda Expression -----\n");
            banks.Where(d => d.balance > 20000).ToList().ForEach(d => Console.WriteLine($"\nBank : {d.bankName},\t Account No. : {d.accNo},\t Account Name : {d.name}, Account Balance : {d.balance}"));

            // Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using LINQ Query.
            Console.WriteLine("\n----- Printing Customer (bankName, Acc.No, Name, Balance), Where balance > 20,000 Using LINQ Query -----\n");
            var result = from d in banks
                         where d.balance > 20000
                         select d;

            result.ToList().ForEach(d => Console.WriteLine($"\nBank : {d.bankName},\t Account No. : {d.accNo},\t Account Name : {d.name}, Account Balance : {d.balance}"));

            Console.ReadLine();
        }
    }
}
