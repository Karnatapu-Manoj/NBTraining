using System;

// Author : Manoj.Karnatapu
// Purpose : Create a Class to Read Two inputs and print Sum, Difference, Product & Division.

namespace Day9Project2
{
    class MathsTask
    {
        private int a, b;
        private int temp;

        public void ReadData()
        {
            Console.WriteLine("\nEnter Any Two Numbers to Do Arithametic Operations : \n");
            Console.Write("Enter a Value : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter b Value : ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// This Method is Used To Calculate Addition Of Two Numbers
        /// </summary>
        public void Addition()
        {
            temp = a + b;
            Console.WriteLine($"\nThe Sum Of Given Two Numbers {a} + {b} is : {temp}");
        }
        /// <summary>
        /// This Method is Used To Calculate the Difference of Two Numbers
        /// </summary>
        public void Difference()
        {
            temp = a - b;
            Console.WriteLine($"\nThe Difference Of Given Two Numbers {a} - {b} is : {temp}");
        }
        /// <summary>
        /// This Method is Used To Calculate the Product of Two Numbers
        /// </summary>
        public void Product()
        {
            temp = a * b;
            Console.WriteLine($"\nThe Product Of Given Two Numbers {a} * {b} is : {temp}");
        }
        /// <summary>
        /// This Method is Used To Calculate the Division of Two Numbers
        /// </summary>
        public void Division()
        {
            temp = a / b;
            Console.WriteLine($"\nThe Division Of Given Two Numbers {a} / {b} is : {temp}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsTask m2 = new MathsTask();
            m2.ReadData();
            m2.Addition();
            m2.Difference();
            m2.Product();
            m2.Division();

            Console.ReadLine();
        }
    }
}
