using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples2
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Hello developers - this will be ignored by the compiler
            //-- Whole Numbers

            byte oneBytesWorth; //variable type - "byte" called smallNumber
            oneBytesWorth = 255; //Minimum 0, Maximum 255 - "smallNumber" has been initialized with the value of 255

            short smallWholeNumber = 16; //Int16
            int wholeNumber = 32;        //Int32
            long largeWholeNumber = 64;  //Int64

            //-- Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.2345678d;
            decimal decimalExample = 1.23456789m; //Very big decimal, money transactions especially

            //-- Characters
            char letter = 'z';
            string name = "Zara";

            //-- Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo; //numOne / numTwo with a remainder of 2 - "%" is called modulus
            Console.WriteLine(remainder);


            Console.WriteLine(name);
        }
        [TestMethod]
        public void ReferenceTypes()
        {
            //-- Strings
            string stringExample = "This is a string.";
            string secondString = "This is another string.";

            Console.WriteLine($"{stringExample} {secondString}");

            string declared;
            declared = "Now it's initialized.";

            //-- Formatting strings
            string concatenate = stringExample + " " + secondString; //Strings have to be concatenated exactly how they are.
            string interpolate = $"{stringExample} {secondString} Strings are fun."; //This is a string. This is another string. Strings are fun.
            Console.WriteLine(interpolate);

            //-- Other Object Examples

            //1      //2            //3
            DateTime now = DateTime.Now;                //1. Object type, 2. Variable name, 3. Operator
            Console.WriteLine(now);

                                  //4 //5
            DateTime randomDate = new DateTime(1989, 06, 24);        //4. "New up", 5. Constructor

            TimeSpan waitTime = now - randomDate;                    //We can tell what the difference is between two dates with TimeSpan
            Console.WriteLine(waitTime.TotalDays);

            //-- Collections
            //-- Arrays

            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(stringArray);

            //-- Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Samuel");
            listOfStrings.Add("Lawrence");
            listOfStrings.Add("Addie");            //ctrl period

            //-- Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");


            //-- Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");                                              //"j" is getting in the door, "Josh" is what is inside

            //-- Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }
    }
}
