using System;

namespace FavoriteThings.Things
{
    class Pets
    {
        public Behaviors Behavior { get; protected set; }
        public int HairLength { get; protected set; }

        public Pets(int hairLength)
        {
            HairLength = hairLength;
            Behavior = Behaviors.happy;
        }

        public void Sniff()
        {
            Console.WriteLine("/nYou have been sniffed!");
        }

        public int MeasureHair()
        {
            return HairLength;
        }

        public void UpdateBehavior(Behaviors newBehavior)
        {
            Behavior = newBehavior;
        }
    }

    enum Behaviors
    {
        loyal = 1,
        angry,
        happy,
        needy,
        lazy
    }
}
