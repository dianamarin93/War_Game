using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Weapons
{
    public class ShotGun : Gun
    {
        public ShotGun(string brand, string color, int damage, int bulletsStorage) : base(brand, color, damage, bulletsStorage)
        {
        }
    }
}
