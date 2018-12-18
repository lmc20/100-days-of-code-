using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the values of a and b");

           
            

            switch (num)
            {
                case 1:  
                    a = Convert.ToInt32(Console.ReadLine());
                   

                    b = Convert.ToInt32(Console.ReadLine());


                    c = a + b;

                    Console.WriteLine(c);
                    Console.ReadKey();

                    break;

                case 2:
                    a = Convert.ToInt32(Console.ReadLine());


                    b = Convert.ToInt32(Console.ReadLine());


                    c = a - b;

                    Console.WriteLine(c);
                    Console.ReadKey();

                    break;

                case 3:
                    a = Convert.ToInt32(Console.ReadLine());


                    b = Convert.ToInt32(Console.ReadLine());


                    c = a * b;

                    Console.WriteLine(c);
                    Console.ReadKey();

                    break;

                case 4:
                    a = Convert.ToInt32(Console.ReadLine());


                    b = Convert.ToInt32(Console.ReadLine());


                    c = a / b;

                    Console.WriteLine(c);
                    Console.ReadKey();

                    break;
            }
        }
    }
}
