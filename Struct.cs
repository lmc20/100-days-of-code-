using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Love ");
            C1.Print();

            Customer C2 = new Customer(102, "Valley ");
                       
            C2.Print();
            Console.ReadKey();
        }
    }

    public struct Customer
    {
        private int _Id;
        private string _Name;

        public int Id { get { return _Id;} set {_Id = value;} }
        public string Name { get {return _Name;} set { Name = value;} }

        public void Print()                                               //Method
        {
            Console.WriteLine("Name: "+Name+ "Id: "+Id);
        }

        public Customer(int Id, string Name)                               //Constructor
        {
            this._Id = Id;
            this._Name = Name;
        }
    }


}


// Struct are Value Type                                    Classes are Referance Type
// Destroyed Immediately after scope ends                   Referance variable is destroyed after scope is Lost but the actual object won't until Garbage collector 
// Stored on Stack                                          Stored in Heap
// A Struct cannot have Parameterless Constructor           Classes can have Parameter Constructor
// Struct can't Inherit from classes
//Structures are Sealed
//Both Structure and classes can Inherit from Interface