using System;
using System.Collections.Generic;
using System.Text;
using Composition.Weapons;

namespace Composition
{
    public class BombTerrorist : Soldier
    {
        private GrenadeLauncher grenade;
        public BombTerrorist(string username, string skinColor, Pistol pistol, GrenadeLauncher grenade, string armour) : base(username, skinColor, pistol, armour)
        {
        }
    }
}
