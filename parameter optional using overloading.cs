using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 39);
            AddNumbers(10, 20, new int[] {39, 09});

        }

        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine("Result : " + result);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] RestOfNumber)            // overloading
        {

            int result = firstNumber + secondNumber;

            if (RestOfNumber != null)
            {
                foreach (int i in RestOfNumber)
                {
                    result = result + i;
                }
            }


            Console.WriteLine("Result : " + result.ToString());
            Console.ReadKey();
        }
    }
}
