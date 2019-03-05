using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Cups
    {
        public string CupType { get; private set; }
        public int OuncesHeld { get; private set; }

        public void AssignCupType(string typeOfCup)
        {
            CupType = typeOfCup;
        }
        public void AssignOuncesHeld(int numInOz)
        {
            OuncesHeld = numInOz;
        }
    }
}
