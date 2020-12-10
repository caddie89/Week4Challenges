using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Week4Challenges
{
    abstract class Reindeer
    {
        public string ReindeerName { get; set; }
        public bool OnTeamSanta { get; set; }
        public int PositionOnTeam { get; set; }

        public abstract string ReindeerMethod();

        public Reindeer() { }

        public Reindeer(bool onTeamSanta)
        {
            OnTeamSanta = onTeamSanta;
        }

        public Reindeer(string reindeerName, bool onTeamSanta, int positionOnTeam)
        {
            ReindeerName = reindeerName;
            OnTeamSanta = onTeamSanta;
            PositionOnTeam = positionOnTeam;
        }
    }

    class Elves : Reindeer
    {
        public override string ReindeerMethod() 
        {
            if (OnTeamSanta == true)
            {
                return "Way to go!";
            }
            else
            {
                return "Maybe next year!";
            }
            
        }

        public string ElfName { get; set; }
        public int ElfAge { get; set; }
        public bool TrainsReindeerTeam { get; set; }

        public Elves() { }

        public Elves (string reindeerName, string elfName)
        {
            ReindeerName = reindeerName;
            ElfName = elfName;
        }

        public Elves(string reindeerName, bool onTeamSanta, string elfName)
        {
            ReindeerName = reindeerName;
            OnTeamSanta = onTeamSanta;
            ElfName = elfName;
        }

        public Elves(bool onTeamSanta, string elfName, int elfAge, bool trainsReindeerTeam)
            : base(onTeamSanta)
        {
            ElfName = elfName;
            ElfAge = elfAge;
            TrainsReindeerTeam = trainsReindeerTeam;
        }
    }

    class Sleigh : Elves
    {
        public string SleighName { get; set; }

        public List<Sleigh> WholeTeam { get; set; } = new List<Sleigh>();

        public Sleigh() { }

        public Sleigh(string reindeerName, string elfName, string sleighName)
            : base(reindeerName, elfName)
        {
            SleighName = sleighName;
        }

        public Sleigh(string reindeerName, bool onTeamSanta, string elfName, string sleighName)
            : base(reindeerName, onTeamSanta, elfName)
        {
            SleighName = sleighName;
        }
    }
}

//Create an abstract class. The theme can be of your choosing, just make sure it's something we haven't seen.
//Ex: Cookie, Shape, Vehicle, etc.
//Give this class at least 3 properties and 1 virtual or abstract method.
//Feel free to add more, you're not limited to just these requirements!
//Declare at least two classes that inherit from your abstract class.
//Make sure you implement all required members that need to be implemented
//In your Main method, new up an instance of each class that inherits from the parent class you set up.Make sure to set all appropriate properties.
