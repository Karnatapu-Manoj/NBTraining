using System;

// Author : Manoj.Karnatapu
// Purpose : Creating an 4 different Class with Required 2 Methods(ReadingData & PrintData) & Calling the methods.

// This is a Products Class from program.cs

namespace Day7Project2
{
    internal class Products
    {
        private int productID;
        private string productName;
        private string productBrand;
        private long productPrice;

        public void CreateProductData()
        {
            Console.WriteLine("\nEnter the Product ID : ");
            productID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the Product Name : ");
            productName = Console.ReadLine();

            Console.WriteLine("\nEnter the Product Brand : ");
            productBrand = Console.ReadLine();

            Console.WriteLine("\nEnter the Product Price : ");
            productPrice = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\n--------------- Product Details ---------------\n");
            Console.WriteLine($"\n\tProduct Id : {productID}\n\tProduct Name : {productName}" +
                $"\n\tProduct Brand : {productBrand}\n\tProduct Price : {productPrice}");
        }
    }
}
