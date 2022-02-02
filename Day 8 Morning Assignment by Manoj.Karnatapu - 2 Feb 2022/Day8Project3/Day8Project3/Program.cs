using System;
using System.Collections.Generic;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Class of List Products, & print Product(Name & Brand) Whose Price is > 500,Using for loop, For Each Loop, Lambda Expression & LINQ query

// For Reference Please Do Check, Day8Project3 Code in the Same Repository.
namespace Day8Project3
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { id = 1, name = "Dell Mouse", price = 780, brand = "Dell In."},
                new Product() { id = 2, name = "Hp KeyBoard", price = 630, brand = "HP In."},
                new Product() { id = 3, name = "Lenovo Monitor", price= 2500, brand = "Lenovo In."},
                new Product() { id = 4, name = "Type-c to Type-A USB Convertor", price = 20, brand = "China Mall"}
            };

            // Printing Product (Name & Brand), Where price>500 Using For Loop
            Console.WriteLine("\n----------------- Printing Products price >500 Using For Loop -----------------\n");
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].price > 500)
                {
                    Console.WriteLine($"\nProduct Name = {products[i].name}\t\t Product Brand = {products[i].brand}");
                }
            }


            // Printing Product (Name & Brand), Where price>500 Using For Each Loop
            Console.WriteLine("\n----------------- Printing Products price >500 Using For Each Loop -----------------\n");
            foreach(var p in products)
            {
                if (p.price > 500)
                    Console.WriteLine($"\nProduct Name = {p.name}\t\t Product Brand = {p.brand}");
            }

            // Printing Product (Name & Brand), Where price>500 Using Lambda Expression
            Console.WriteLine("\n----------------- Printing Products price >500 Using Lambda Expression -----------------\n");
            products.Where(p => p.price > 500).ToList().ForEach(p => Console.WriteLine($"\nProduct Name = {p.name}\t\t Product Brand = {p.brand}"));

            // Printing Product (Name & Brand), Where price>500 Using LINQ Query.
            Console.WriteLine("\n----------------- Printing Products price >500 Using LINQ Query -----------------\n");
            var result = from p in products
                         where p.price > 500
                         select p;

            result.ToList().ForEach(p => Console.WriteLine($"\nProduct Name = {p.name}\t\t Product Brand = {p.brand}"));
            Console.ReadLine();
        }
    }
}
