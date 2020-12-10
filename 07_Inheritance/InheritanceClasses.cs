using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance
{
    abstract class Person                                               //Abstract - only able to implement a person through "Customers" and "Employees"
    {                                                                   //We can use the abstract concept Person objects in our other classes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(){}
        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class Customer : Person                                             //The ":" is allowing us to inherit all the objects from the Person class
    {
        public bool IsPremium { get; set; }

        public Customer(){}

        public Customer(bool isPremium, string firstName, string lastName, string phoneNumber, string email)
            : base(firstName, lastName, phoneNumber, email)             //": base() is allowing us to use the constructor in the person class (cotr                                                                     shortcut)
        {
            IsPremium = isPremium;

        }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
    }

    class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double Hours { get; set; }
    }

    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
    }
}
