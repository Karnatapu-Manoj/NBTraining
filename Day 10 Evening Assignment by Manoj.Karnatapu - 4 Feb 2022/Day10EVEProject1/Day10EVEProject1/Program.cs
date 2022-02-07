using System;

// Author : Manoj.Karnatapu
// Purpose : Abstract Template Creation

// For Reference, check Day10EVEProject1 in the same Repository.

namespace Day10EVEProject1
{
    /// <summary>
    /// This is an Abstract Class
    /// </summary>
    abstract class Salary
    {
        /// <summary>
        /// This is a GetPF Normal Method with Body
        /// </summary>
        /// <param name="basic">INT Basic</param>
        /// <returns>Cal O/p</returns>
        public int GetPF(int basic)
        { return 12 * basic / 100; }
        /// <summary>
        /// This is a GetHRA Normal Method with Body
        /// </summary>
        /// <param name="basic">INT Baisc</param>
        /// <returns>Cal O/p</returns>
        public int GetHRA(int basic)
        { return 40 * basic / 100; }

        /// <summary>
        /// This is an Abstract Method GetCA, it doesn't have a Body in Abstract class.
        /// </summary>
        /// <returns>Enforcing Derived class to Use this method mandatorly.</returns>
        public abstract int GetCA();
        /// <summary>
        /// This is an Abstract Method GetSA, it doesn't have a Body in Abstract class.
        /// </summary>
        /// <returns>Enforcing Derived class to Use this method mandatorly.</returns>
        public abstract int GetSA();
    }

    class Microsoft : Salary
    {
        public override int GetCA()
        {
            return 6000;
        }

        public override int GetSA()
        {
            return 7000;
        }
    }
    class Google : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }

        public override int GetSA()
        {
            return 10000;
        }
    }
    class IBM : Salary
    {
        public override int GetCA()
        {
            return 4000;
        }

        public override int GetSA()
        {
            return 6000;
        }
    }
    class Facebook : Salary
    {
        public override int GetCA()
        {
            return 20000;
        }

        public override int GetSA()
        {
            return 20000;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Microsoft Code

            // Google Code

            // IBM Code

            // Facebook Code

            Console.WriteLine("Abstract Class Template Execution Success");

            Console.ReadLine();
        }
    }
}
