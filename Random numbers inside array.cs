using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = new int[5];

            for (int i = 0; i <= 4; i++)
            {

                Random NumberGenerator = new Random();
                int Num = NumberGenerator.Next(1, 101);

                numbers[i] = Num;

                Console.WriteLine(numbers[i]);

                Console.ReadKey();
            }

        }
    }
}
