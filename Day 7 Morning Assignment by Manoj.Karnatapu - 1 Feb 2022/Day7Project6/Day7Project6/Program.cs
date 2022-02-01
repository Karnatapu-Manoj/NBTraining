using System;
using System.Linq;

// Author : Manoj.Karnatapu
// Purpose : Create Customer and Products class data in the form of Array while creating Object & print using For loop, For Each loop and Lambda Expressions.

namespace Day7Project6
{
    class Customer
    {
        public int customerId;
        public string customerName;
        public string customerSubscription;
    }

    class Products
    {
        public int productId;
        public string productName;
        public int productPrice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[]
            {
                new Customer(){ customerId = 1, customerName = "Manoj.Karnatapu", customerSubscription = "Prime User"},
                new Customer(){ customerId = 2, customerName = "Pavan Kumar", customerSubscription = "General"},
                new Customer(){ customerId = 3, customerName = "Vihar Dasari", customerSubscription = "Prime User"}
            };
            // Using For Loop
            Console.WriteLine("\n\t Printing Customer Data Using For Loop\n");
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine($"Customer Id = {customers[i].customerId},  Customer Name = {customers[i].customerName},  Customer Subscription = {customers[i].customerSubscription}");
            }

            // Using For Each Loop
            Console.WriteLine("\n\t Printing Customer Data Using For Each Loop\n");
            foreach (var e in customers)
            {
                Console.WriteLine($"Customer.ID = {e.customerId},  Customer.Name= {e.customerName},  Customer.Subscription = {e.customerSubscription}");
            }
            // Using Lambda Expression
            Console.WriteLine("\n\t Printing Customer Data Using Lambda Expression\n");

            customers.ToList().ForEach(d => Console.WriteLine($"ID = {d.customerId},  Name = {d.customerName},  Subscription = {d.customerSubscription}"));

            Console.WriteLine("\n=======================================================================\n");

            // For Products Class
            Products[] products = new Products[]
            {
                new Products(){ productId = 1, productName = "Nokia 5500", productPrice = 10000},
                new Products(){ productId = 2, productName = "RedMi Note 9 pro", productPrice = 13000},
                new Products(){ productId = 3, productName = "OnePlus 9R", productPrice = 48000}
            };
            // Using For Loop
            Console.WriteLine("\n\t Printing Products Data Using For Loop\n");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product Id = {products[i].productId},  Product Name = {products[i].productName},  Product price = {products[i].productPrice}");
            }

            // Using For Each Loop
            Console.WriteLine("\n\t Printing Products Data Using For Each Loop\n");
            foreach (var p in products)
            {
                Console.WriteLine($"Product.ID = {p.productId},  Product.Name= {p.productName},  Product.Price = {p.productPrice}");
            }
            // Using Lambda Expression
            Console.WriteLine("\n\t Printing Products Data Using Lambda Expression\n");

            products.ToList().ForEach(d => Console.WriteLine($"ID = {d.productId},  Name = {d.productName},  Price = {d.productPrice}"));

            Console.ReadLine();

        }
    }
}
