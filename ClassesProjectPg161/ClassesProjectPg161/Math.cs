using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectPg161
{
    public class Math
    {
       public void  Addition( int userNumOne, int userNumTwo)
        {
            Add = userNumOne + 20;
            String = Convert.ToString(userNumTwo);
            String2 = Convert.ToString(Add);
            Console.WriteLine(String);
            Console.WriteLine(String2);
            

        }
        public int Add { get; set; }
        public string String2 { get; set; }
        public string String { get; set; }
    }
}
