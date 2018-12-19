using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 1; i < 10; i++)
            { 
                Random NumberGenerator = new Random();
                int num01 = NumberGenerator.Next(1, 11);
                int num02 = NumberGenerator.Next(1, 11);

                Console.WriteLine("What is the result of " + num01 + " multiply " + num02);

                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == num01 * num02)
                {
                    Console.WriteLine("You are on fire today");
                }

                else
                {
                    Console.WriteLine("Try Harder");

                }

                Console.ReadKey();
            }
        }

    }
}
