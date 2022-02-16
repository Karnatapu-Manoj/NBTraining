using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author : Manoj.Karnatapu
// Purpose : As per Business Requirements, Creating a Factorial Library.

// for Reference, check Day18Project1 in the same Repository.
namespace ManojLibrary
{
    public class Algebra
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else if (n < 0)
                return -9999;
            else if (n > 7)
                return -999;
            else
            {
                int fact = 1;
                for (int i = 1;i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
        }

        public static bool IsPalindrome(int n)
        {
            int rev = 0, rem, m;
            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (n == rev)
                return true;
            else
                return false;
        }
    }
}
