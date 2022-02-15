using System;
using ManojLibrary;
// Author : Manoj.Karnatapu
// Purpose : Created a Public Library and Using ManojLibrary namespace for identifying the Access Modifiers.

// For Reference, check AccessModifier > Public Library > MyPublicDerivedClass.cs in the same Repository.

namespace PublicLibrary
{
    /// <summary>
    /// This is a MyPublicDerivedClass in other Assembly by inheriting the MyBaseClass and identifying the Access Modifier accessability.
    /// </summary>
    public  class MyPublicDerivedClass : MyBaseClass
    {
        /// <summary>
        /// MyPublicDerivedClassMethod(), we are using the variables from Inherited MyBaseClass of ManojLibrary & identifying the Access Modifier accessability
        /// </summary>
        public void MyPublicDerivedClassMethod()
        {
            a = 5;
            //b = 10;    // Here the Private Access Modifier is not accessed in the Derived Class in Other Assembly
            c = 15;
            //d = 20;    // Here the internal Access Modifier is not accessed in the Derived Class in Other Assembly
            e = 30;
        }
    }

    /// <summary>
    /// This is a MyPublicOtherClass in Other Assembly & Identifying the Access Modifier accessability.
    /// </summary>
    public class MyPublicOtherClass
    {
        /// <summary>
        /// MyPublicOtherClassMethod(), we are creating the object for MyPublicDerivedClass & identifying the Access Modifier accessability
        /// </summary>
        public void MyPublicOtherClassMethod()
        {
            MyPublicDerivedClass mpd = new MyPublicDerivedClass();
            mpd.a = 5;
            // mpd.b = 10;  Here the Private Access Modifier is not accessed in the other Class in Other Assembly
            // mpd.c = 15;  Here the Protected Access Modifier is not accessed in the other Class in Other Assembly
            // mpd.d = 20;  Here the internal Access Modifier is not accessed in the other Class in Other Assembly
            // mpd.e = 30;  Here the Protected Internal Access Modifier is not accessed in the other Class in Other Assembly
        }
    }
}
