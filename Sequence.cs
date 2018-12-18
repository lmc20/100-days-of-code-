using System;

namespace Sequence1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double i;
            for (i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                   
                else
                    
                     Console.WriteLine(-i);
                     Console.ReadKey();
            }

        }
    }
}
