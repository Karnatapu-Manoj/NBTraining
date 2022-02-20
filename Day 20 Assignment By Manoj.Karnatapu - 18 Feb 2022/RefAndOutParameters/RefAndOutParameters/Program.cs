using System;
// Author : Manoj.Karnatapu
// Purpose : C# Code to illustrate, the Ref & Out keywords.

// For Reference, check RefAndOutParameters Project in the same Repository.

namespace RefAndOutParameters
{
    internal class Program
    {
        /// <summary>
        /// This is a method for Ref Keyword Example
        /// </summary>
        /// <param name="id"> ref id</param>
        /// <returns>NextId</returns>
        public static string NextNameByRef(ref int id)
        {
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
        /// <summary>
        /// This is a Method for Out Keyword Example
        /// </summary>
        /// <param name="id">out id</param>
        /// <returns>NextId</returns>
        public static string NextNameByOut(out int id)
        {
            id = 1;
            string returnText = "Next-" + id.ToString();
            return returnText;
        }
        /// <summary>
        /// Main Method, Code Starting point.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\n -----------**** Ref Keyword Output ****-----------");

            int i = 1;
            Console.WriteLine("Previous value of integer i : " + i.ToString());
            string testRef = NextNameByRef(ref i);
            Console.WriteLine("Current value of integer i : " + i.ToString());

            Console.WriteLine("\n -----------**** Out Keyword Output ****-----------");

            int j;
            string testOut = NextNameByOut(out j);
            Console.WriteLine("Current value of integer j:" + j.ToString());

            Console.ReadKey();
        }
    }
}
