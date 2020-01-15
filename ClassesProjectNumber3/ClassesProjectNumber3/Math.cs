using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectNumber3
{
   public class Math
    {
        public int Addition(int userNumOne, int userNumTwo = 1)
        {
            addOne = userNumOne + 35;
            addTwo = userNumOne + userNumTwo + 35;
            
            if (userNumTwo > 1)
            {
                return addTwo;
            }
            else
            {
                return addOne;
            }
        }
        public int addTwo { get; set; }
        public int addOne { get; set; }
    }
}
