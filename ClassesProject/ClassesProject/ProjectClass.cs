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

        public int Subtraction( int Add)
        {
            Subtract = 33 - Add;
            return Subtract;
        }

        int Subtract { get; set; }

        public int Division (int Subtract)
        {
            Divide = Subtract / 7;
            return Divide;
        }

        int Divide { get; set; }

        public int Total()
        {
            Result = Add + Subtract + Divide;
            return Result;
        }
        int Result { get; set; }
    }
}
