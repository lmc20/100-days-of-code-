using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {

            AddNumbers(10, 20);
            AddNumbers(10, 29, 12, 43);
            
        }

        public static void AddNumbers(int firstNumber, int secondNumber, params object[] RestOfNumber )             //parameter array
        {

            int result = firstNumber + secondNumber;

            if (RestOfNumber != null)
            {
                foreach(int i in RestOfNumber)
                {
                    result = result + i;
                }
            }

   
            Console.WriteLine("Result : " + result);
            Console.ReadKey();
        }
    }

    
}
