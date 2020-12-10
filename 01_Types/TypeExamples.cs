using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers -- Variables are "named location in computer memory (RAM - Random Access Memory)" and have three different parts: 1. Type, 2. Name, 3. Value

            //1  //2
            byte oneBytesWorth; //oneBytesWorth will ALWAYS be a byte
            //3 - initialize with a value of "255"
            oneBytesWorth = 255; //min - 0, max - 255
            short smallWholeNumber = 16;    //Int16
            int wholeNumber = 32;           //Int32
            long largeWholeNumber = 64;     //Int64

            int newNumber = oneBytesWorth;

            //-- Decimals
            float floatExample = 1.234567f; //-- "f" indicates its the end of a float
            double doubleExample = 1.234567; //-- decimals are assumed to be doubles (no d required)
            decimal decimalExample = 1.234567m; //-- very big decimal, sometimes used for money transactions

            //-- Characters
            char letter = 'j'; //-- single quotes tell us its a single character (number, character, letter)

            //-- Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;         //-- 17 / 5 = 3 ???
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;    //-- 17 % 5 = 2
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //-- Strings
            string stringExample = "This is a string.";
            string name = "Caleb";

            string declared;        //has not been initialized
            declared = "Now it's initialized.";

            //-- Formatting strings
            string concatenate = stringExample + " " + name;                        //This is a string. Caleb
            string interpolate = $"{name}. Here is the string: {stringExample}";    //Caleb. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples - Object Orienated Language
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 06, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //-- Collections - We have to declare but also specify what the object holds.
            // Arrays 
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];                                         //can never have more than 15 values

            Console.WriteLine(stringArray);

            // Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>();        //First person in line, is the first person out of the line
            firstInFirstOut.Enqueue("Luke");

            // Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            // Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }
    }
}
