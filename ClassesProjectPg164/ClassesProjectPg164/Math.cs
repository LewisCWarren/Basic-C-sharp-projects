using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectPg164
{
    public class Math
    {
        public void Division(out int userNum)
        {
            userNum = Convert.ToInt32(Console.ReadLine()) / 2;

        }
        public int Divide { get; set; }

        public int Subtraction(int userNum2)
        {
            Subtract = userNum2 - 1;
            return Subtract;
        }
        public int Subtract { get; set; }

        public int Subtraction(int userNum2, int userNum3 = 1)
        {
            Subtract = userNum2 - 1;
            Subtract2 = userNum3 - 1;
            return Subtract;
        }
        int Subtract2 { get; set; }
    }
}

   
