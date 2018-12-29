using System;
using System.Collections.Generic;
namespace ConsoleApp31
{
    class Calculator
    {   
        [Obsolete ("Use Add List Method")]
        public static void Add(int a, int b)
        {
            int sum = a + b; 
            Console.WriteLine(sum);
        }

        public void Add(List<int> Numbers)
        {
            int Sum = 0;

            foreach(int number in Numbers)
            {
                Sum = Sum + number;
                
            }

            Console.WriteLine(Sum);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator.Add(3,3);
            Console.ReadKey();
        }
    }


}

