using System;

// Author : Manoj.Karnatapu
// Purpose : This is a Mathematics Class in <ManojLibrary>

// for Reference, Check Chemistry.cs in PublicLibrary inside MyProject Solution.

namespace PublicLibrary
{
    public static class Chemistry
    {
        /// <summary>
        /// This is a Benzene Formula
        /// </summary>
        /// <returns>Benzene Formula</returns>
        public static string Benzene()
        {
            Console.WriteLine("C6H6");
            return "C6H6";
        }
        /// <summary>
        /// This is a Water Formula.
        /// </summary>
        public static void Water()
        {
            Console.WriteLine("H2O");
        }
    }

}
