using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods4
{
    [TestClass]
    public class MethodExamples
    {
        //A method is a re-usable chunk of code.
        //4 parts including our input, what we do, and output.
        //Access modifier, return type, method signature, list of parameters go into (), and then a body in {}

        public int AddTwoNumbers(int numOne, int numTwo)                            //Parameters are what we take in
        {
            int sum = numOne + numTwo;                                              //We want a NEW int value, we named it sum. This method will                                                                                return the value of sum which will be numOne + numTwo
            return sum;
        }

        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;

            if (num <= 10)
            {
                Console.WriteLine("That's a small number.");
            }
            else
            {
                Console.WriteLine("That's a big number.");
            }

            return num;
        }

        public void Write(string name)
        {

        }

        public int Question5Method(int number)
        { 
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            return number;
        }

        public int Question6Method(int numOne, int numTwo)
        {
            if (numOne > numTwo)
            {
                Console.WriteLine(numOne);
            }
            else
            {
                Console.WriteLine(numTwo);
            }

            return numOne;
        }

        public int Question7Method(string stringOne)
        {
            int intOne = Int32.Parse(stringOne);

            return intOne;
        }

        public double Question8Method(int intOne, int intTwo)
        {
            int quotient = intOne / intTwo;
            double doubleTrouble = Convert.ToDouble(quotient);

            return doubleTrouble;
        }

        public int Question9Method(DateTime currentYear, DateTime birthYear)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan span = currentYear - birthYear;
            int years = (zeroTime + span).Year - 1;

            Console.WriteLine($"You are {years} years old.");

            return years;
        }

        public int Question9Method2(DateTime birthyear)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime today = DateTime.Now;
            TimeSpan newDate = today - birthyear;
            int years = (zeroTime + newDate).Year - 1;

            Console.WriteLine($"You are {years} years old.");

            return years;
        }

        public string Question10Method(string name)
        {
            Console.WriteLine($"Hello, dear {name}. You are most welcome here!");

            return name;
        }

        [TestMethod]
        public void MethodTests()
        {
            int sum = AddTwoNumbers(7, 12);                  //7 and 12 are called arguments, these need to fulfill the parameters of numOne and numTwo
            Console.WriteLine(sum);
        }

        [TestMethod]
        public void AnotherMethodTest()
        {
            int difference = SubtractTwoNumbers(10, 5);
            //Console.WriteLine(difference);
        }

        [TestMethod]
        public void TestQ5()
        {
            int someNumber = Question5Method(20);
        }

        [TestMethod]
        public void TestQ6()
        {
            var someNumber = Question6Method(16, 15);

        }

        [TestMethod]
        public void TestQ7()
        {
           var someNumber = Question7Method("100");
           int newInt = someNumber + 16;
           Console.WriteLine(newInt);

        }

        [TestMethod]
        public void TestQ8()
        {
            double someNumber = Question8Method(32, 3);
            Console.WriteLine(someNumber);
        }

        [TestMethod]
        public void TestQ9()
        {
            MethodExamples age = new MethodExamples();
            var someVariable = age.Question9Method(new DateTime(2020, 12, 02), new DateTime(1989, 06, 24));
        }
        [TestMethod]
        public void TestQ9_2()
        {
            MethodExamples age = new MethodExamples();
            var someVariable = age.Question9Method2(new DateTime(1989, 06, 24));
        }

        [TestMethod]
        public void TestQ10()
        {
            string userName = "Caleb";
            var someString = Question10Method(userName);
        }
    }
}
