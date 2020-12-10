using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class InClassTypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            int age = 31;

            byte someByte = 23;                         //Michael usually uses int or doubles, sometimes decimals

            int anotherNumber = 23;

            anotherNumber = 256;

            double someDouble = 23.31295701285;
            float someFloat = 23.3409587230857f;
            decimal someDecimal = 23.34892057403m;

            Console.WriteLine(someDouble + someFloat);
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string[] names = { "Casey", "Micahel", "Simon" };
            List<string> fruits = new List<string>();
            fruits.Add("grape");
            fruits.Add("apple");
    

            Dictionary<char, double> dictionary = new Dictionary<char, double>();
            dictionary.Add('x', 3.1459);
            dictionary['x'] = 34234.2345; //changing the value in the key value pair.

            Console.WriteLine(fruits[0]);
            Console.WriteLine(dictionary['x']);
          
        }
    }
}
