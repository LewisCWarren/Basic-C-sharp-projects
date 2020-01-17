using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassProject
{
    public class Employee<T> : Person
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

        public List<T> things { get; set; }



    }
}
