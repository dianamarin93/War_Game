using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Composition;
using Composition.Weapons;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            RifleGun r = new RifleGun("Kalasnikov", "brown", 40, 30);
            Pistol p = new Pistol("Berreta", "black", 25, 12);
            ShotGun shotGun = new ShotGun("Winchester", "black", 50 , 20);
            GrenadeLauncher grenade = new GrenadeLauncher("GM-94", "green", 40, 6);
            SniperRiffle sniperRiffle = new SniperRiffle("Barret MRAD", "black", 100, 20);
            
           BombTerrorist terrorist = new BombTerrorist("Hercule","grey", p, grenade, "bulletproof vest");
           KamikazeTerrorist terroristk = new KamikazeTerrorist("Hulk", "green", p, shotGun, "bulletproof vest");
           SniperTerrorist terrorists = new SniperTerrorist("Panther", "green", p, sniperRiffle, "tactical vest");

            Sniper sniper= new Sniper("Tarzan", "yellow", new Pistol("Desert Eagle", "grey", 50, 7),
                new SniperRiffle("MP40", "white", 45, 30), "tactical vest");
            Marine marine = new Marine("Thor", "blue", p, r, "");
            NavySeal navy = new NavySeal("Momoa", "black", p, shotGun, "");

            List<Soldier> goodGuys = new List<Soldier>() { sniper, marine, navy };
            List<Soldier> badGuys = new List<Soldier>() { terrorist, terroristk, terrorists };

            Random rndR = new Random();

            while (true)
            {
                if (goodGuys.Count == 0)
                {
                    Console.WriteLine("Good Guys team lost!");
                    break;
                }

                if (badGuys.Count == 0)
                {
                    Console.WriteLine("Bad Guys team lost!");
                    break;
                }
                Soldier fighter1 = goodGuys[rndR.Next(goodGuys.Count)];
                Soldier fighter2 = badGuys[rndR.Next(badGuys.Count)];

                if (fighter1.Fight(fighter2))
                {
                    badGuys.Remove(fighter2);
                }
                else
                {
                    goodGuys.Remove(fighter1);
                }

            }

            Console.ReadKey();
        }
    }
}
