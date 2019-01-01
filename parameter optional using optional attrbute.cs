using System;
using System.Runtime.InteropServices;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
         
            AddNumbers(10, 29);
            AddNumbers(43, 54, new int[] {23,45,56} );
        }

        public static void AddNumbers(int firstNumber, int secondNumber, [Optional]int[] RestOfNumber)  //Optional Attribute
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
