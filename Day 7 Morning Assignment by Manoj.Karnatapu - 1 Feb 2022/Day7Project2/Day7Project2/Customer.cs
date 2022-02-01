using System;


// Author : Manoj.Karnatapu
// Purpose : Creating an 4 different Class with Required 2 Methods(ReadingData & PrintData) & Calling the methods.

// This is a Customer Class from program.cs

namespace Day7Project2
{
    internal class Customer
    {
        private int customerId;
        private string customerName;
        private string customerSubscriptionDetails;
        private long customerMobileNumber;

        public void CreateCustomerData()
        {
            Console.WriteLine("\nEnter Customer ID : ");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter Customer Name : ");
            customerName = Console.ReadLine();

            Console.WriteLine("\nEnter Customer Subscription Type : ");
            customerSubscriptionDetails = Console.ReadLine();

            Console.WriteLine("\nEnter Customer Mobile No. : ");
            customerMobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public void DisplayCustomerProfile()
        {
            Console.WriteLine("\n--------------- Customer Details ---------------\n");
            Console.WriteLine($"\n\tCustomer Id : {customerId}\n\tCustomer Name : {customerName}" +
                $"\n\tSubscription Type : {customerSubscriptionDetails}\n\tMobile No. : {customerMobileNumber}");

        }
    }
}
