using System;
using FavoriteThings.Things;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // pets
            var dog = new Pets(34);
            var cat = new Pets(100);
            cat.UpdateBehavior(Behaviors.angry);

            // games
            var battlefield = new Games("Battlefield 24");
            var oxenfree = new Games("Oxenfree");

            oxenfree.SetGenre(GameGenres.casual);

            // Cups
            var mugCup = new Cups();
            var glassCup = new Cups();

            mugCup.AssignCupType("mug");
            mugCup.AssignOuncesHeld(16);

            //Devs
            var juniorDev = new Developers("Freshly Showered");
            var seniorDev = new Developers("Extra Stinky");

            juniorDev.ResetStench("a bit stinky");

            Console.WriteLine($"The dog's behavior is {dog.Behavior} and it's hair length is {dog.HairLength}");
            Console.WriteLine($"The cat's behavior is {cat.Behavior}");

            Console.WriteLine($"I like to play {battlefield.Title}");
            Console.WriteLine($"{oxenfree.Title} is a \"{oxenfree.GameGenre}\" game.");

            Console.WriteLine($"My {mugCup.CupType} holds {mugCup.OuncesHeld}oz of fluid");

            Console.WriteLine($"This Junior dev is a {juniorDev.GetDevType()} developer and smells {juniorDev.Stench}");

            Console.ReadKey();
        }
    }
}
