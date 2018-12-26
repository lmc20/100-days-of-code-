// delegate is a Type Safe Function Pointer

using System;

public delegate void HelloFunctiondelegate(string messasage);                   //Creating a delegate


namespace ConsoleApp28
     
{
    class Program
    {
        static void Main(string[] args)
        {           
            HelloFunctiondelegate del = new HelloFunctiondelegate(Hello);         //delegate del points to Hello Function

            del("Hello From Delegate");                                             
        }

        public static void Hello(string strMessage)
        {
        Console.WriteLine(strMessage);
        Console.ReadKey();
        }

    }
}
