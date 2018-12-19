using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1= Add(10,10);
            int result2= Add(10, 20, 30);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadKey();
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
