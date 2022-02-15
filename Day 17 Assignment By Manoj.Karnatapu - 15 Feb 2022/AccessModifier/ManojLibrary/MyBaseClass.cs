using System;
// Author : Manoj.Karnatapu
// Purpose : Created a Manoj Library for identifying the Access Modifiers.

// For Reference, check AccessModifier > Manoj Library > MyBaseClass.cs in the same Repository.

namespace ManojLibrary
{
    /// <summary>
    /// This is a Base Class Initializing with Access modifier variables.
    /// </summary>
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        /// <summary>
        /// This is a BaseClassMethod(), Checking wether accessing the Variables is Possible or not
        /// </summary>
        public void MyBaseClassMethod()
        {
            a = 5;
            b = 10;
            c = 15;
            d = 20;
            e = 30;

        }
    }

    /// <summary>
    /// This is a DerivedClass of BaseClass,inheriting the properties of baseclass. 
    /// </summary>
    public class MyDerivedClass : MyBaseClass
    {
       public void MyDerivedClassMethod()
        {
            a = 5;
            // b = 10;    // Here the Private Access Modifier is not accessed in the Derived Class
            c = 15;
            d = 20;
            e = 30;
        }
    }
    /// <summary>
    /// This is a separate class, checking the accessed variables are using in outside of a class or not.
    /// </summary>
    public class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            mb.a = 5;
            // mb.b = 10; Here the Private Access Modifier is not accessed in the other Class in Same Assembly
            // mb.c = 15; Here the Protected Access Modifier is not accessed in the other Class in Same Assembly
            mb.d = 20;
            mb.e = 30;

        }
    }
}
