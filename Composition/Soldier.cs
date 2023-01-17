using System;
using System.Threading;

namespace Composition
{
    public class Soldier
    {
        private string username;
        private int health;
        private string skinColor;

        private Pistol pistol;
        private string armour;

        public Soldier(string username, string skinColor, Pistol pistol, string armour)
        {
            this.username = username;
            this.health = 100;
            this.skinColor = skinColor;
            this.pistol = pistol;
            this.armour = armour;
        }

        public void Show_Details()
        {
            Console.WriteLine($"Username: {username}, health: {health}, skin color: {skinColor}, weapon: {pistol.Show_Details()},armour: {armour}");
        }

        public bool Fight(Soldier enemy)
        {
            Random rnd = new Random();

            while (true)
            {
                int chance = rnd.Next(10);

                if (chance < 5)
                {
                    this.Attack_WithPistol(enemy);
                    Console.WriteLine($"{this.username} shot {enemy.username} with {this.pistol.brand} causing {this.pistol.damage} damage");
                }
                else
                {
                    enemy.Attack_WithPistol(this);
                    Console.WriteLine($"{enemy.username} shot {this.username} with {enemy.pistol.brand} causing {enemy.pistol.damage} damage");

                }

                Thread.Sleep(500);

                if (this.health <= 0)
                {
                    Console.WriteLine(this.username + " has died");
                    return false;
                }

                if (enemy.health <= 0)
                {
                    Console.WriteLine(enemy.username + " has died");
                    return true;
                }
            }
        
        }

        public void Attack_WithPistol(Soldier enemy)
        {
            enemy.health -= this.pistol.damage;
        }

    }
}
