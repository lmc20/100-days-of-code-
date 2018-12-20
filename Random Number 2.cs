using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumberGenerator = new Random();
            for (int i = 1; i <= 10; i++)
            { 
            int num01 = NumberGenerator.Next(1, 7);
            int num02 = NumberGenerator.Next(1, 7);

            int sum = num01 + num02;

                Console.WriteLine(num01 + num02);
                if (sum < 7)
                {
                    Console.WriteLine("You Loose");
                }

                else
                {
                    Console.WriteLine("You Won");
                }

                Console.ReadKey();
            }
        }
    }
}
