using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int age , newage;

            Console.WriteLine("Enter Your Age:");

            age = Convert.ToInt32(Console.ReadLine());

            newage = age + 10;

            Console.WriteLine(newage);

            Console.ReadKey();
        }
    }
}
