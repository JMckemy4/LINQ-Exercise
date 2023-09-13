using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names...
            List<string> gameNames = new List<string>
            {
                "Fallout",
                "Rainbow Six",
                "Skyrim",
                "Call of Duty",
                "Rocket League",
                "Fortnite",
                "Phaz"
            };

            //Order the list of games by length of the game name.
            var orderedGames = gameNames.OrderBy(name => name.Length);

            //Use the lambda expression in this exercise as well.


            //Use Method Syntax for this exercise
            Console.WriteLine("Ordered Game Names by Length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
