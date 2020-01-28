using System;
namespace killamonster
{
    
    public class Monster
    {

    // Constructor //

        private string name;

        public Monster(string name) 
        {
            this.name = name;
        }

        public string Name 
        {
            get 
            { 
                return name; 
            }
        }
        
        
    // Health //
        private int _health = 100;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value <= 0)
                {
                    _health = 0;
                    Console.WriteLine(this.name + " Is Dead.");
                    System.Threading.Thread.Sleep(1000);
                }
                _health = value;

                  if (_health <= 0)
                {
                    _health = 0;
                }
            }
        }
    
    // Name //

        private string _name = "nope" ;

    // Damage //

        private string _damage = "nope" ;
        public int Damage
        {
            get
            {
                Random r = new Random();
                int number = r.Next(1, 100);
                return number;
            }
            set
            {
                Health -= value;
            }
            
        }
    }
}