using System;
using System.Collections.Generic;
using System.Text;
using Composition.Weapons;

namespace Composition
{
    public class KamikazeTerrorist : Soldier
    {
        private ShotGun shotGun;
        public KamikazeTerrorist(string username, string skinColor, Pistol pistol, ShotGun shotGun, string armour) : base(username, skinColor, pistol, armour)
        {
        }
    }
}
