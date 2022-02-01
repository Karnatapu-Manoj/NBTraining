using System;

// Author : Manoj.Karnatapu
// Purpose : Creating an 4 different Class with Required 2 Methods(ReadingData & PrintData) & Calling the methods.

// This is a Seller Class from program.cs

namespace Day7Project2
{
    internal class Seller
    {
        private int sellerId;
        private string sellerName;
        private string sellerLocation;
        private string sellerType;

        public void CreateSellerData()
        {
            Console.WriteLine("\nEnter Seller Id : ");
            sellerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Seller Name : ");
            sellerName = Console.ReadLine();

            Console.WriteLine("\nEnter Seller Location : ");
            sellerLocation = Console.ReadLine();

            Console.WriteLine("\nEnter Seller Type : ");
            sellerType = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void DisplaySellerData()
        {
            Console.WriteLine("\n--------------- Seller Details ---------------\n");
            Console.WriteLine($"\n\tSeller Id : {sellerId}\n\tSeller Name : {sellerName}" +
                $"\n\tSeller Location : {sellerLocation}\n\tSeller Type : {sellerType}");
        }
    }
}
