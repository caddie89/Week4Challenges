using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes2
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "Snickerdoodle";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Chocolate Chip";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoodle = new Cookie("Snickerdoodle", false, 11.5);
            Cookie chocolateChip = new Cookie("Chocolate Chip", false, 150);
            Cookie peanutButter = new Cookie("Peanut Butter", true, 10.23456);
        }
        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Car,                //Object Initialization Syntax
                Make = "Honda",
                Model = "Civic"
            };
        }
    }
}
