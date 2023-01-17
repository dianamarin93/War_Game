using System;
using System.Collections.Generic;
using System.Text;
using Composition.Weapons;

namespace Composition
{
    public class NavySeal : Soldier
    {
        private ShotGun shotGun;
        public NavySeal(string username, string skinColor, Pistol pistol, ShotGun shotGun, string armour) : base(username, skinColor, pistol,armour)
        {
        }
    }
}
