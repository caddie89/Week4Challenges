using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Week2ChallengesInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greeter = new Greeter();
            string person = greeter.GreetAPerson("Dolly!");
            Console.WriteLine(person);

            Greeter farewell = new Greeter();
            string person2 = farewell.FarewellPerson("Jimmy!");
            Console.WriteLine(person2);

            Console.ReadLine();
        }
    }
}
