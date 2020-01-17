using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassProject
{
    public class Employee : Person
    {
        public override void SayName()
        {
            base.SayName();
            
        }
        public int id { get; set; }

        public int EmployeeID()
        {
            id = 1;
            return id;
        }

        public static Employee operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.id == employee2.id)
            {
                Console.WriteLine("employee has the same ID as another ID.");
            }

            else
            {
                Console.WriteLine("Employee has a unique id");
            }
            return employee1;
        }

        public static Employee operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.id != employee2.id)
            {

                Console.WriteLine("Employee has a unique id");
            }

            else
            {
                Console.WriteLine("employee has the same ID as another ID.");
            }
            return employee1;

        }



    }
}
