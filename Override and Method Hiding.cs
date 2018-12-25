using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass1();
            b.Print();
        }
    }

    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a base class");
            Console.ReadKey();

        }
    }

    class DerivedClass  : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("This is a derived class");
            Console.ReadKey();
        }
    }

   class DerivedClass1 : BaseClass
    {
        public new void Print()
        {
            Console.WriteLine("This is a derived1 class");
            Console.ReadKey();
        }
    }


}

