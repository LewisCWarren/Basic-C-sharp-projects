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

            IQuittable disgruntled = new Employee();
            
            disgruntled.Quit(out int x);
        }
    }
}
