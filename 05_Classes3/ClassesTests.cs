using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes3
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void GreeterTests()
        {
            Greeter name = new Greeter();
            name.Name = "Dolly!";
            Greeter greeting = new Greeter();
            greeting.Greeting = "Hello, ";
        }
        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

        }
    }
}
