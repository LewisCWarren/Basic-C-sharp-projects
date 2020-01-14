using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectNumber2
{
    public class Math
    {
        public int Addition(int userNumOne)
        {
            Add = 25 + userNumOne;
            return Add;
        }
        public int Add { get; set; }

        public decimal Addition(decimal userNumTwo)
        {
            multiply = userNumTwo * 3;
            return multiply;
        }
        public decimal multiply { get; set; }


        string userString;


        public int Conversion( string userString)
        {
            int num = Convert.ToInt32(userString);
            userNum = num * 5;
            
            return userNum;
        }
        public int userNum { get; set; }
        public int equation { get; set; }
        
    }
}
