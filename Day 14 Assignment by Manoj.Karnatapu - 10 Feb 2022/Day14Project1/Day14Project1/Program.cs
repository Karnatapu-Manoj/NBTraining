using System;
// Author : Manoj.Karnatapu
// Purpose : Sealed Class Illustration Example Code.

// For Reference, Check Day14Project1 in the same Repository.
namespace Day14Project1
{
    sealed class Police
    {
        public string GetSecret()
        {
            return "Encounter order for, Khaide No.420";
        }
    }
    class Khaides : Police // Bcz, sealed class cannot be inherited or can't be derived.
    {
        public void Crime()
        {
            // Todo
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Khaides k = new Khaides();
            Console.WriteLine(k.GetSecret());

            Console.ReadLine();
        }
    }
}
