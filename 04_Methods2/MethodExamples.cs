using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods2
{
    [TestClass]
    public class MethodExamples
    {

        //Input
        //What we do
        //Output

        //Access Modifier -- Return Type -- Method Signature (Name and list of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)                //By calling the method, numOne and numTwo have been given values
        {
            int sum = numOne + numTwo;
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;
        }

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int DivideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }

        [TestMethod]
        public void MethodTests()                                       //Access modifier (public), return type (output), Method Signature including name and parameters, and body
        {
            int banana = AddTwoNumbers(7, 12);                          //Calling the method and giving it two integers - 7 & 12 are arguments, they fulfill the parameters of numOne & numTwo
            Assert.AreEqual(19, banana);

            int subractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = DivideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);
        }
    }
}
