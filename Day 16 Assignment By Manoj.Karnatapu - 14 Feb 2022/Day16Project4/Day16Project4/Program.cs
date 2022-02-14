using System;
// Author : Manoj.Karnatapu
// Purpose : Write a C# Code, To check if the given Number is Palindrome or Not, Using Object Oriented Approach

// For Reference, Check Day16Project4 in the same Repository.
namespace Day16Project4
{
    class Palindrome
    {
        int input;
        /// <summary>
        /// Reading Input Value, To Check Palindrome or Not
        /// </summary>
        /// <returns>Entered Input Number</returns>
        public int ReadInput()
        {
            Console.Write("\nEnter Any Number To Check, If Palindrome Or Not  :   ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
        /// <summary>
        /// To Check, if the given Input is Palindrome or Not
        /// </summary>
        /// <returns>Boolean Value</returns>
        public bool IsPalindrome()
        {
            int rev = 0, rem, m;
            m = input;
            while(m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (input == rev)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Object for Palindrome Class
            Palindrome palindrome = new Palindrome();
            int input = palindrome.ReadInput();     // Calling ReadInput() & storing the Returned Value.
            bool isPalindrome = palindrome.IsPalindrome(); // Calling IsPalindrome() & storing the Returned Bool value.

            // Printing the Output Message to Console.
            if (isPalindrome == true)
                Console.WriteLine("\nYes, {0} Is a Palindrome Number", input);
            else
                Console.WriteLine("\nNo, {0} is Not a Palindrome Number", input);

            Console.ReadLine();
        }
    }
}
