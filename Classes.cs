using System;

namespace ConsoleApp16
{

    class Animal                                     //Declearing a new class

    {
        
        public string name = "Butter's";              //Class Variables  
        public int age = 2;
        public string color = "white";


        public void Print()                          //Method
        {
            Console.WriteLine("Name " +name);
            Console.WriteLine("Age " +age);
            Console.WriteLine("Color " +color);
        }

        
     }

    class Program
    {
        static void Main(string[] args)        
        {  

            Animal dog = new Animal();  //Object of class Animal  
            dog.name = "Test";
            dog.age = 4;
            dog.color = "brown";

            Animal cat = new Animal();   
            cat.name = "Kitty";
            cat.age = 6;
            cat.color = "brown";


            dog.Print();
            Console.WriteLine();
            cat.Print();

            Console.ReadKey();
        }

    }
}
