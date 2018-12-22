using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog fringe = new Dog();                                              // Object made from Dog Class
            fringe.name = "Fringe";
            fringe.age = 5;
            fringe.color = "Golden Brown";
            fringe.spotcount = 0;
            Console.WriteLine("Spotcount = " + fringe.spotcount);
            fringe.print();
            



            Cat missy = new Cat();                                             // Object made from Cat Class
            missy.name = "missy";
            missy.age = 2;
            missy.color = "White";
            missy.cuteness = 8.0;
            Console.WriteLine("Cuteness = " + missy.cuteness);
            missy.print();
           



        }
    }



    class Animal                                                                   //Animal Class
    {
        public string name = "Butter's";
        public int age = 6;
        public string color = "black";

        public void print()
        {

            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Color =  " + color);
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    class Dog : Animal                                                            //Dog Class Inherited from Animal Class
    {
       public int spotcount = 32;

    }

    class Cat : Animal                                                            //Cat Class Inherited from Animal Class
    {
       public double cuteness = 4.5f;

    }

   

}
