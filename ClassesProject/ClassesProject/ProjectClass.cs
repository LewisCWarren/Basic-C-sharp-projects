using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
    public class Math
    {


        public int Addition(int userNum)
        {
            
            Add = 100 + userNum;
            return Add;
        }

        int Add { get; set; }
        
        public int Subtraction( int resultAdd)
        {
            Subtract = resultAdd - 33;
            return Subtract;
        }

        int Subtract { get; set; }

        public int Division (int resultSubtract)
        {
            Divide = resultSubtract / 7;
            return Divide;
        }

        int Divide { get; set; }

        
    }
}
