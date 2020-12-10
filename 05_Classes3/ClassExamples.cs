using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes3
{
    public class Greeter
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public string Farewell { get; set; }
    }

    public enum VehicleType { Car, Truck, Van, Motorcyle, Spaceship, Plane, Boat }          //Use enums to creat customizable objects
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType TypeOfVehicle { get; set; }                                     //VehicleType object created by enum is used here       
    }
}
