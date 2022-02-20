using System;
// Author : Manoj.Karnatapu
// Purpose : Nullable Type C# Code Example.

// For reference, check NullableTypes project in the same reference.

namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int? firstValue = 20;
            int? secondValue = null;

            int? result;

            result = (firstValue.HasValue) ? firstValue : null;

            Console.WriteLine("The value inside First Value Nullable type is : {0}", result);

            result = (secondValue.HasValue) ? secondValue : null;

            Console.WriteLine("The value inside Second Value Nullable type is : {0}", result);
            // If u find No Output displaying in the console window means, it's value is null i.e., unassigned.

            Console.ReadKey();
        }
    }
}
