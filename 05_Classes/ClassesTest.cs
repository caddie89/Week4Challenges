using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTest
    {
        [TestMethod]
        public void CookieTests()                   //When we see (), we know that we are calling a method - Cookie() "method" is going to be the Constructor
        {
            Cookie cookie = new Cookie();           //Made a new object called cookie.
            cookie.Name = "Snickerdoodle";          //.Name is setting the name property of the above Cookie. Classes can be thought of as cookie cutters.
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);        //Here, we have given arguments to our Cookie() method parameters in ClassExamples  
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);
        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle                    //Object Initialization Syntax
            {
                TypeOfVehicle = VehicleType.Car,
                Make = "Honda",
                Model = "Civic",
            };
        }
    }
}
