using System;
using System.Collections.Generic;

namespace killamonster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsters = new List<Monster>();
            int dead = 0;

            
    // Monster Fight //
            

            monsters.Add(new Monster("Bjorn"));   
            while(dead != 6) {
            foreach(Monster m in monsters) {
                Console.WriteLine("Name " + m.Name);
                Console.WriteLine("Health " + m.Health);
            }

            if (monsters[0].Health <= 0)
            {
                dead++;
                Console.Clear();
                
                string[] names = {"Greet","Bob","Diego","Cas","Miland","Calvin","Jaydar","Jan","Henk","Piet"};

                monsters.Remove(monsters[0]);
                string name = names[new Random().Next(0, names.Length)];
    	        monsters.Add(new Monster(name));

                Console.WriteLine("Name " + monsters[0].Name);
                Console.WriteLine("Health " + monsters[0].Health);
            }
    
            string input = Console.ReadLine();

            Console.Clear();

            if (input.ToLower() == "attack")
            {
                monsters[0].Damage = monsters[0].Damage;

                Console.WriteLine("Name " + monsters[0].Name);
                Console.WriteLine("Health " + monsters[0].Health);


                Console.Clear();
            }
        }
            Console.WriteLine("Victory");
        }
    }
}