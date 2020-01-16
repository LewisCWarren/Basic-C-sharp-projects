using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassProject
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
            
        }


        public void Quit(out int x)
        {
            Console.WriteLine("Quitting");
             x = 5;
        }

        


    }
}
