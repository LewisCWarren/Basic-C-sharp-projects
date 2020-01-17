using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
       
            employee.SayName();
            Console.ReadLine();

            

            Employee employee1 = new Employee() { FirstName = "Dave", LastName = "Jenkins", id = 1 };
            Employee employee2 = new Employee() { FirstName = "Dave", LastName = "Mathews", id = 1 };

            employee = employee1 == employee2;
            Console.ReadLine();




        }
    }
}
