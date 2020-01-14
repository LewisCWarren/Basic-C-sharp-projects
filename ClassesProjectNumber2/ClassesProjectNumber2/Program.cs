using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectNumber2
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Math MathOperation = new Math();

            Console.WriteLine("Please provide a number for the operation");
            int userNumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number you provided + 25 is = to " + MathOperation.Addition(userNumOne));
            Console.ReadLine();
            Console.WriteLine("Please enter a decimal number for a different operation");
            decimal userNumTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("The decimal number provided times 3 is = " + MathOperation.Addition(userNumTwo));
            Console.ReadLine();
            Console.WriteLine("Please enter a final number for an operation");
            string userString = Console.ReadLine();
            Console.WriteLine("Your input x 5 = " + MathOperation.Conversion(userString));
            Console.ReadLine();
        }
    }
}
