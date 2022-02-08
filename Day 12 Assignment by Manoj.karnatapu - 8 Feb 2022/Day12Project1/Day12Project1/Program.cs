using System;

// Author : Manoj.Karnatapu
// Purpose : C# Code for Division program, & handling 3 exceptions along with super exception catch at the End.

namespace Day12Project1
{
    /// <summary>
    /// This is a Simple Division Program, With Catching Exceptions.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Implementing a Division program, With an User Friendly Experience.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Try block with Logical Code Implementation Section
            try
            {
                int a, b , c;
                Console.Write("\nEnter the Dividend Value :  ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write($"\nenter the Divisor Value to Divide {a} :  ");
                b= Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine($"\n The Division of {a} / {b} is : {c}");
                Console.ReadLine();
            }
            // Catch Block for OverFlowException
            catch (OverflowException)
            {
                Console.WriteLine("\nPlease Do Enter the Numbers Only in the Range of 0 to 50000");
            }
            // Catch Block for DivideByZeroException
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nPlease Do Provide divisor Value, a Non-Zero Number to Do Perfect Division.");
            }
            // Catch Block For FormatException
            catch (FormatException)
            {
                Console.WriteLine("\nPlease, Do Enter only Integers. Strings / Special Characters are not Allowed to do Division as per Mathematics Standard.");
            }

            // Catch Block For Other Kind Of Exceptions.
            catch (Exception)
            {
                Console.WriteLine("\n\t Some Error Has Occured, Please Contact the Admin");
            }

            finally
            {
                Console.WriteLine("\n\n\n\n\n Designed & Developed By Manoj.karnatapu");
                Console.ReadLine();
            }
        }
    }
}
