using System;
using System.Collections.Generic;
using System.Text;
using Composition.Weapons;

namespace Composition
{
    public class Pistol : Gun
    {
       
        public Pistol(string brand, string color, int damage, int bulletsStorage) : base(brand, color, damage, bulletsStorage)
        {
     
        }

        
    }
}
