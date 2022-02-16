using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManojLibrary;

// Author : Manoj.Karnatapu
// Purpose : Creating Test Case, For Algebra Library, For Factorial Method & IsPalindrome.

namespace ManojLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            // Arrange
            int n = 0;
            int expected = 1;
            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negative_Input()
        {
            // Arrange
            int n = -31;
            int expected = -9999;
            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Greater_than_seven_Input()
        {
            // Arrange
            int n = 20;
            int expected = -999;
            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Input()
        {
            // Arrange
            int n = 7;
            int expected = 5040;
            // Act
            int actual = Algebra.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest_Input()
        {
            // Arrange
            int n = 131;
            bool expected = true;

            // Act
            bool actual = Algebra.IsPalindrome(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}







