using System;

// Author : Manoj.Karnatapu
// Purpose : Create a Class To Read inputs and print Factorial, Factors & isPrime or Not.

namespace Day9Project1
{
    class MathsOperations
    {
        private int input;
        private int i;

        public void ReadData()
        {
            Console.Write("Enter any Number to find Some Mathematical Calculations :  ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// This Method Finds Factorial of Given Number
        /// </summary>
        public void Factorial()
        {
            int fact = 1;
            
            for(int i = 1; i <= input; i++)
            {
                fact *= i;
            }

            Console.WriteLine($"\nThe Factorial of Given Number {input} is : {fact}");
        }

        /// <summary>
        /// This Method Finds Factors of a Given Number
        /// </summary>
        public void Factors()
        {
            Console.Write($"\nThe Factors of Given Number {input} is : \n");
            for(int i = 1; i <= input; i++)
            {
                if(input%i == 0)
                    Console.Write("\t{0}",i);
            }
        }

        /// <summary>
        /// This Method Finds Wether Given Number is Prime Or Not?
        /// </summary>
        public void IsPrime()
        {
            
            for(i = 2;i < input; i++)
            {
                if (input % i == 0)
                    break;
            }

            if(i == input)
                Console.WriteLine($"\n Yes, {input} is a Prime Number");
            else
                Console.WriteLine($"\n No, {input} is NOT a Prime Number");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperations m1 = new MathsOperations();
            m1.ReadData();
            m1.Factorial();
            m1.Factors();
            m1.IsPrime();

            Console.ReadLine();
        }
    }
}
