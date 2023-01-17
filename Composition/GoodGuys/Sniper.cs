using System;
using System.Collections.Generic;
using System.Text;
using Composition.Weapons;

namespace Composition
{
    public class Sniper : Soldier
    {
        private SniperRiffle sniperRiffle;
        public Sniper(string username, string skinColor, Pistol pistol, SniperRiffle sniperRiffle, string armour) 
            : base(username, skinColor, pistol, armour)
        {
        }
    }
}
