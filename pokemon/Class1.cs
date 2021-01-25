using System;
using System.Collections.Generic;
using System.Text;

namespace bot
{
    class Hokemon
    {
       
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public Hokemon()
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);

        }

        public void get_details()
        {
            Console.WriteLine("\n\n************\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5}\n**********\n", name, health, max_health, attack, speed, defense);
        }

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your droid: ");
            name = Console.ReadLine();
        }

        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public int attackCalculator()
        {
            int attackValue;
            Random rnd = new Random();
            attackValue = ((attack * speed) / 2) * rnd.Next(0, 2);

            return attackValue;
        }
        public int defenceCalculator()
        {
            int defenceValue;
            Random rnd = new Random();

            defenceValue = (defense * speed) / 10 * rnd.Next(0, 2);

            return defenceValue;
        }
    }
}