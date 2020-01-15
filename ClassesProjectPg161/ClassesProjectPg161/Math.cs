using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectPg161
{
    public class Math
    {

        

       public void  Addition(  int userNumOne,  int userNumTwo)
        {

            Add = userNumOne + 20;
            String = Convert.ToString(Add);
            String2 = Convert.ToString(userNumOne);
            Console.WriteLine(String + " " + String2);
            

        }
        public string String { get; set; }
        public string String2 { get; set; } 
        public int Add { get; set; }
        
    }
}

