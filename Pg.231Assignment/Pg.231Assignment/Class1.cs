using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg._231Assignment
{
    
    
        public class Person
        {
            public Person(string name) : this(name, "blue", 11)
            {

            }

            public Person(string name, string favColor, int favNumber)
            {
                Name = name;
                FavNumber = favNumber;
                FavColor = favColor;
            }
            public string FavColor { get; set; }
            public string Name { get; set; }
            public int FavNumber { get; set; }
        }
    
}
    

