using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods3
{
    [TestClass]
    public class MethodExamples                                                         //We are in a public class called "MethodExamples"
    {

        //Input
        //What we do
        //Output

        public string AddTwoStrings(string stringOne, string stringTwo)                 //Parameters must be separated by ","
        {
            string combinedString = stringOne + stringTwo;
            return combinedString;
        }

        public bool ThisIsABool(bool notTrue, bool isTrue)
        {
            var boolPractice = notTrue || isTrue;
            return boolPractice;
        }

        public decimal PricePlusTax(decimal price, decimal taxPercentage, decimal discountPercentage)
        {
            var totalCost = price + (price * taxPercentage) - (price * discountPercentage);
            return totalCost;
        }

        private int MultiplyTwoNumbers(int z, int k)
        {
            var prod = z * k;
            return prod;
        }

        private int DivideTwoNumbers(int oneNum, int twoNum)
        {
            var quot = oneNum / twoNum;
            return quot;
        }

        private int FindRemainder(int speak, int friend)
        {
            var remainder = speak % friend;
            return remainder;
        }

        [TestMethod]
        //1    //2  //3       //4                                                       //1. "Access Modifier", 2. "Return type", 3. "Method Signature Name", 4. "Parameters"
        public void MethodTests()
        {
            string bothStrings = AddTwoStrings("I love my daughter, Zara. ", "I also love my wife, Kyla.\n");
            Console.WriteLine(bothStrings);

            string twoStrings = AddTwoStrings("I miss Zara.", " And I miss Kyla.\n");
            Console.WriteLine(twoStrings);

            bool boolExample = ThisIsABool(false, true);
            Console.WriteLine(boolExample);

            decimal totalCost = PricePlusTax(10.95m, .07m, .20m);
            Console.WriteLine(totalCost);
        }

        
    }
}
