using System;
using System.IO;                                                                                    

namespace ConsoleApp29
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
              StreamReader streamReader = null;                                                             //StreamReader is used for reading data from files  

            try
            {
               
                streamReader = new StreamReader(@"C:\Users\Love Much Chandra\Desktop\C#\text1.txt");        //Adress of file
                Console.WriteLine(streamReader.ReadToEnd());
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File Does Not Exist.");
            }

            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Directory Does Not Exist.");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();

                }
                Console.WriteLine("Finally Stoped");
                Console.ReadKey();
            }
        }
    }
}
