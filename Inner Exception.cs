using System;
using System.IO;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the First number :");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Second number :");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int DN = FN / SN;

                    Console.WriteLine(DN);
                    Console.ReadKey();
                }

                catch (Exception ex)
                {
                    string filePath = @"C:\Users\Love Much Chandra\Desktop\C#\text1.txt";

                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.WriteLine();
                        sw.Write(ex.Message);
                        sw.Close();

                        Console.WriteLine("There is a Problem, Please try again");
                        Console.ReadKey();
                    }

                    else
                    {
                        throw new FileNotFoundException(filePath + "is not Present", ex);
                       
                    }

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception =  {0}",exception.GetType().Name);
                Console.WriteLine("Interal Exception = {0}",exception.InnerException.GetType().Name);
                Console.ReadKey();
            }
        }

    }


}
