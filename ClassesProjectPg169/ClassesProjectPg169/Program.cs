using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectPg169
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "[Student", LastName = "Sample]" };

            

            employee.SayName();
            Console.ReadLine();
            
        }
    }
}
