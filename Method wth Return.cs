using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int result= Add(10,20);                   //Add Method 
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int Add(int num1, int num2)    
        {   
            return num1 + num2;                    //returns integer value
        }

    }
}
