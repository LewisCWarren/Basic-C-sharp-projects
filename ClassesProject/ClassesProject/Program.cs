using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProject
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Math mathOperation = new Math();
            
            
            Console.WriteLine("Please enter a number to perform the operation on");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int resultAdd = mathOperation.Addition(userNum);
            int resultSubtract = mathOperation.Subtraction(resultAdd);
            int resultDivide = mathOperation.Division(resultSubtract);

            Console.WriteLine("After adding 100, subtracting 33, and dividing by 7, the number you entered amounts to " + resultDivide);
            Console.ReadLine();
        }
    }
}
