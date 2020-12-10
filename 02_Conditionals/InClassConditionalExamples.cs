using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class InClassConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int studentCount = 9;
            if (studentCount >= 20)
            {
                Console.WriteLine("The class is getting pretty small.");
            }
            else if (studentCount >= 10)
            {
                Console.WriteLine("This class is really small.");
            }
            else
            {
                Console.WriteLine("How many students do you have?");
            }

            switch (studentCount)
            {
                case 12:
                    Console.WriteLine("You have exactly 12 students.");  //evaluates the value of studentCount, in the case that it is exactly 12, it will run that code
                    break;
                case 10:
                    Console.WriteLine("You have exactly 10 students.");
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("You have x number of sutdents");
                    break;
                default:
                    Console.WriteLine("How many students do you have?");
                    break;
            }

            //Ternaries
            bool result = (studentCount == 10) ? true : false;
            string isGoodSize = (studentCount < 65) ? "This class is manageable" : "Ph boy, that's a lot of students";
        }
    }
}
