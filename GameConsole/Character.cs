using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int HitChance { get; set; }
        public HarmRange Damage { get; set; }
        public bool Defend { get; set; }

        public bool Alive { get { return Health != 0; } }



        Random rnd = new Random();

        public Character(string name, int health, int hitChance, HarmRange damage, bool defend)
        {
            Name = name;
            Health = health;
            HitChance = hitChance;
            Damage = damage;
            Defend = defend;
        }


        public Character(string name, int health, int hitChance, HarmRange damage)
        {
            Name = name;
            Health = health;
            HitChance = hitChance;
            Damage = damage;
            
        }
        //public Character(string name, int health, int hitChance, HarmRange damage, bool defend, bool alive)
        //{
        //    Name = name;
        //    Health = health;
        //    HitChance = hitChance;
        //    Damage = damage;
        //    Defend = defend;
        //    Alive = alive;
        //}

        public void Defending()
        {
            Console.WriteLine("{0} is defending!", Name);
            Defend = true;
        }

        public void Strike(int amount)
        {
            // int damageRecieved = Defend ? (amount / 2) : amount;

            int damageRecieved;
            if (Defend)
            {
                damageRecieved = amount / 2;
            }
            else
            {
                damageRecieved = amount;
            }

            Health -= damageRecieved;
            Console.WriteLine("{0} lost {1} health ", Name, damageRecieved);
        }


        public void Attacking(Character tg)
        {
            Console.WriteLine("{0} attacks!", Name);
            Defend = false;

            if (HitChance <= rnd.Next(0,5))
            {
                Console.WriteLine("{0} missed!", Name);
            }
            tg.Strike(rnd.Next(Damage.Min, Damage.Max));
        }

        public void Healing(int amount)
        {
            Console.WriteLine("{0} use healing potion!", Name);
            Defend = false;
            Health = Health + amount;
            Console.WriteLine("{0} is healed for {1} points!", Name, amount);
        }

        public void QuitTheGame()
        {
            System.Environment.Exit(0);
        }

    }
}
