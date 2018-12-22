using System;

namespace ConsoleApp20
{
    class Program
    { 

        static void Main(string[] args)
        {
            Animal cat = new Animal("Butter's", 3, "white");                                   //object
            cat.Print();

            Animal dog = new Animal("Ghost", 1, "grey");                                        //object
            dog.Print();

            Console.WriteLine("count =" + Animal.count);
            Console.ReadKey();
        }
    }


    class Animal                                                                               //class
    {
        public static int count = 0;
        public string name ;
        public int age;
        public string color;

        

        public void Print()                                                                     //method
        {
            Console.WriteLine("name= " +name);
            Console.WriteLine("age= " + age);
            Console.WriteLine("color= " + color);
           
            Console.ReadKey();
            
        }

         public Animal(string _name, int _age, string _color)                                   //constructor

        {
            name = _name;
            age = _age;
            color = _color;

            count++;
            
        }
         
         


    }


}
