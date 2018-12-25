using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] Employees = new Employee[3];                        // Employees[]  is a base class referance variable  

            Employees[0] = new Employee();                                 //  Employees is a base class object
            Employees[1] = new FullTimeEmployee();                         //  FullTimeEmployees  is a derived class object
            Employees[2] = new PartTimeEmployee();                         //  PartTimeEmployee  is a derived class object 

            foreach (Employee e in Employees)
            {
                e.Print();
                Console.WriteLine();
                Console.ReadKey();                
            }
        }
    }

    public class Employee
    {
       public string FirstName = "FN";
       public string LastName = "LN";
        
        public virtual void Print()
        {
            Console.WriteLine("First Name: " +FirstName+ "Last Name: " +LastName);

        }
    }

    public class FullTimeEmployee : Employee
    {

        public override void Print()
        {
            Console.WriteLine("First Name: " + FirstName + "Last Name: " + LastName+ "-");

        }
    }

    public class PartTimeEmployee :Employee
    {
        
        public override void Print()
        {
            Console.WriteLine("First Name: " + FirstName + "Last Name: " + LastName+ "--");

        }
    }


}
