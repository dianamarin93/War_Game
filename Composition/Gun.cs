using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Weapons
{
    public class Gun
    {
        public string brand;
        public string color;
        public int damage;
        public int bulletsStorage;

        public Gun(string brand, string color, int damage, int bulletsStorage)
        {
            this.brand = brand;
            this.color = color;
            this.damage = damage;
            this.bulletsStorage = bulletsStorage;
        }

        public string Show_Details()
        {
            return $"brand: {brand}, color: {color}, damage: {damage}, bullets storage: {bulletsStorage}";
        }

    }
}
