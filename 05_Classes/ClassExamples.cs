using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    //We can have as many classes in a namespace as we want. The name on the right does not have to be the name of the class.
    public class Cookie
    {
        //What is a cookie? We need to assign some properties. 
        public string Name { get; set; }                            //Anything that is not a local variable or parameter should be pascal cased (Name).
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }
        //The is not currently any "method" or written code - constructors are not yet defined

        public Cookie()                                       //Overloading methods/constructors
        {

        }
        //Constructors do not need a return type, and they always have to have the same name as the class
        public Cookie(string name, bool hasNuts, double gramsOfFlour) //This is going to be our constructor - body will fire off - because this is a method, it can be given parameters
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

    public enum VehicleType { Car, Truck, Van, Motocylce, Spaceship, Plane, Boat } //enum creates a brand new type and assign all its values

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public int Year { get; set; }
        public bool Carfax { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {

        }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }
    }
}
