using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(23, 56);
            AddNumbers(23, 45, new int[] {54, 43});

        }

        public static void AddNumbers(int firstNumber, int secondNumber, int[] RestOfNumber = null)          //Specify Parameter Default
        {
            int result = firstNumber + secondNumber; 

            if( RestOfNumber != null )
            {
                foreach(int i in RestOfNumber)
                {
                     result =  result + i; 
                }
            }
            Console.WriteLine("Result = " +result);
            Console.ReadKey();

        }
    }
}
