using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Weapons
{
    public class SniperRiffle : Gun
    {
        public SniperRiffle(string brand, string color, int damage, int bulletsStorage) : base(brand, color, damage, bulletsStorage)
        {
        }
    }
}
