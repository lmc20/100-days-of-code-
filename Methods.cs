using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)                // Main Method
        {
            GreetUser();                              // Method Call 
            Add(13,20);                               // Arguments
            Console.ReadKey();
        }

        public static void GreetUser()                // New Method
        {
            Console.WriteLine("Hello User");
        }

        public static void Add(int num1, int num2)    // Parameters(int num1, int num2) 
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
