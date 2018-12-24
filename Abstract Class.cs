using System;

namespace ConsoleApp24
{

    public abstract class Customer
    {
        public abstract void Print();

    }

    public class Product : Customer
    {
        public string name;
        public int price; 

        public override void Print()
        {
            Console.WriteLine("Name:" +name); 
            Console.WriteLine("Price:" +price) ;
            Console.ReadKey();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Product Pizza = new Product();
            Pizza.name = "CheeseBurst";
            Pizza.price = 200;
            Pizza.Print();

   
        }
    }
}
