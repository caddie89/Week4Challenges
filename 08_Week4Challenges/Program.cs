using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Week4Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            var elf1 = new Elves(false, "Sprinkles", 1224, false);
            var elf2 = new Elves("Blitzen", true, "Jolly");

            string output1 = elf1.ReindeerMethod();
            Console.WriteLine($"{elf1.ElfName} did not make the team. {output1}\n" +
                $"Press ENTER to continue...");
            Console.ReadLine();

            string output2 = elf2.ReindeerMethod();
            Console.WriteLine($"{output2} {elf2.ElfName} made Santa's Team! Can you believe that he's {elf2.ElfAge} years old?\n" +
                $"Press ENTER to continue...");
            Console.ReadLine();

            var wholeTeam = new Sleigh("Blitzen", true, "Jolly", "One Thing Sled to Another");

            var wholeTeamList = new List<Sleigh>();
            wholeTeamList.Add(wholeTeam);

            Console.WriteLine("Here's the team:\n");

            foreach (var item in wholeTeamList)
            {
                Console.WriteLine($"Reindeer: {item.ReindeerName}\n" +
                    $"Is on the team: {item.OnTeamSanta}\n" +
                    $"Elf: {item.ElfName}\n" +
                    $"Sleigh: {item.SleighName}");
            }

            Console.WriteLine("Press ENTER to close...");
            Console.ReadLine();
        }

    }

}










