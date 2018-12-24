using System;

namespace ConsoleApp23
{
    public class Employee
    {

        public string FirstName;
        public string LastName;

        public void Print()
        {
            Console.WriteLine("Employee's Name: " + FirstName + " " + LastName);
            Console.ReadKey();
        }

    }

    public class FullTimeEmployee : Employee
    {

    }

    public class PartTimeEmployee : Employee
    {
        public new void Print()                                                              //Method Hides the Base Method
        {
            Console.WriteLine("Employee's Name: " + FirstName + " " + LastName+ "-" );
            Console.ReadKey();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee Employee = new FullTimeEmployee();
            Employee.FirstName = "Love";
            Employee.LastName = "Chandra";
            Employee.Print();

            PartTimeEmployee PEmployee = new PartTimeEmployee();
            PEmployee.FirstName = "Bret";
            PEmployee.LastName = "Hart";
            PEmployee.Print();                                                       // Inherited Class Method


            ( (Employee)PEmployee).Print();                                          //Calling the Base Class Method



        }
    }
}
