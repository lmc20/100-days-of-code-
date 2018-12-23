using System;

namespace ConsoleApp22
{
    class Program
    {

        static void Main(string[] args)
        {
            Player Love = new Player();

            Love.health -= 40;
            Console.WriteLine(Love.health);

            Love.health += 40;
            Console.WriteLine(Love.health);

            Love.health -= 200;
            Console.WriteLine(Love.health);

            Console.ReadKey();
        }
    }

    class Player
    {
        private int _health = 100;
        public int health
        {
            get
            {
                return _health;
            }

            set
            {
                if(value <= 0)
                {
                    _health = 0;
                }

               else if (value >= 100)
                {
                    _health = 100;
                }

                else
                {
                    _health = value;
                }
            }
        }

        public void damage(int _dmg)
        {
            _health = _health - _dmg;
        }
    }
}
