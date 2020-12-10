using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            //var person = new Person();
            //person.FirstName = "Caleb";
            //person.ToString();                                  //This is an inherited method.

            var customer = new Customer(true, "Caleb", "Addie", "12193794633", "caleb.addie@gmail.com");
            customer.ToString();
            customer.FirstName = "James";
            customer.IsPremium = true;

            var employee = new Employee();
            employee.FirstName = "Addie";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.HourlyWage = 15.74m;

            List<Person> people = new List<Person>();
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmployee);

            List<int> numbers = new List<int>();
            numbers.Add(7);
            numbers.Add(1000);
            //numbers.Add(7.5m) - Cannot add a decimal to a list of integers

        }
    }
}
