using System;

// Author : Manoj.Karnatapu
// Purpose : This is a Mathematics Class in <ManojLibrary>

// for Reference, Check Physics.cs in ManojLibrary inside ManojKarnatapu Solution.

namespace ManojLibrary
{
    public class Physics
    {
        /// <summary>
        /// This is a Final Velocity Calculation
        /// </summary>
        /// <param name="u">initial velocity</param>
        /// <param name="a">acceleration</param>
        /// <param name="t">time</param>
        /// <returns>Final Velocity</returns>
        public static int FinalVelocity(int u, int a, int t)
        {
            int finalVelocity = u + a * t;
            Console.WriteLine(finalVelocity);
            return finalVelocity;
        }
        /// <summary>
        /// This is a Force Calculation Method
        /// </summary>
        /// <param name="m">Mass</param>
        /// <param name="a">Acceleration</param>
        /// <returns>Force</returns>
        public static int ForceCalculation(int m, int a)
        {
            int force = m * a;
            Console.WriteLine(force);
            return force;
        }
    }
}
