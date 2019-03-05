using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Developers
    {
        private DevTypes DevType { get; set; }
        public string Stench { get; protected set; }

        public Developers(string stench)
        {
            Stench = stench;
        }

        public void ResetStench(string newStench)
        {
            Stench = newStench;
        }

        public string GetDevType()
        {
            return $"{DevType}";
        }
    }

    enum DevTypes
    {
        FrontEnd,
        BackEnd,
        Maintenance,
        DevOps
    }
}
