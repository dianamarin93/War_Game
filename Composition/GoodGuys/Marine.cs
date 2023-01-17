using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class Marine : Soldier
    {
        private RifleGun riflegun;
        public Marine(string username, string skinColor, Pistol pistol, RifleGun riffleGun, string armour) : base(username, skinColor, pistol,  armour)
        {
        }
    }
}
