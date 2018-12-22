using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
             
           
            Location man = new Location(34,Location.Direction.SOUTH);                                            //object
            man.Positon();

            Location bomb = new Location(12, Location.Direction.EAST);
            bomb.Positon();         
            Console.ReadKey();

            
        }
    }

    class Location
    {
        public enum Direction {NORTH, SOUTH, EAST, WEST};                                                        //enum
        public int Distance;
        public Direction _dir;

        
        public void Positon()                                                                                    //method
        {

            Console.WriteLine("The Position is " +_dir);
            Console.WriteLine("The Distance from camp is " +Distance);
        }

      
        public Location(int _Distance, Direction __dir)                                                         //constructor
        {
            Distance = _Distance;
            _dir = __dir;
           
        }

    }


}
