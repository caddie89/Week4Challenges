using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes2
{
    public class Cookie                                  //Declaring a class - name (class)
    {
        public string Name { get; set; }                 //Getters and setters - allows us to get and set the value
        public bool HasNuts { get; set; }
        public double GramsOfFlour { get; set; }
        public string Ingredients { get; set; }

                                                                               //If you don't define a constructor, C# will add one in the background
        public Cookie(string name, bool hasNuts, double gramsOfFlour)          //This is our constructor, when we new up a Cookie, it will refer to this method
        {
            Name = name;
            HasNuts = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }

        public Cookie()                                                        //We need this empty constructor if we are going to new up methods in ClassTests
        {

        }
    }

    public enum VehicleType                                                    //Enums allow us to create a type and assign all its values
    {
        Car,
        Truck,
        Van,
        Motorcycle,
        Spaceship,
        Plane,
        Boat
    }
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle()
        {

        }

    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }                  //We can change Cookie without changing the Order
        public decimal TotalCost { get; set; }
    }
}
