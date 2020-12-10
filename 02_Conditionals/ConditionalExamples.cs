using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            // "=" is the assignment "operator"
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4; 
        }

        [TestMethod]
        public void IfElseStatements()
        {
            //If you're hungry, eat, if you're tired, sleep.
            bool isTrue = true;
            if (isTrue)                                             //if this isn't true, "Do something here" code will never fire off
            {
                //Do something here
            }

            int age = 2;
            //1     //2
            if (age > 17)                                           //Structure of an if statement: 1. "if" keyword, 2. boolean in (), 3. body
            {
                //3
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You're far too young to be on a computer");  
            }
            else
            {
                Console.WriteLine("You're not even born yet");
            }

            if (age > 65 && age < 18)
            {
                //And comparison &&
            }
            if (age <= 65 || age >= 18)
            {
                //Or comparison ||
            }
            if (age == 17)
            {
                //Is equal to
            }
            if (age != 19)
            {
                //Not equal to
                //! bang operator
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)                                               //Switch keyword, what we're evaluating (age), case, break
            {
                case 18:
                    //Code for if age is 18
                    break;
                case 19:
                    //Code for if age is 19
                    break;
                case 20:
                    //Code for if age is 20
                    break;
                case 21:
                case 22:
                case 23:
                    //Code here for 21-23
                    break;
                default:
                    //Catch all code
                    Console.WriteLine("You are not 18-23");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 37;
            //variable = (boolean statement) ? trueValue : falseValue;

            bool isAge = (age == 24) ? true : false;

        }
    }
}
