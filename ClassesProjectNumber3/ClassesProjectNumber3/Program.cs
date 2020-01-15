using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathOperation = new Math();
            
            Console.WriteLine("Please enter a number for the math operation");
            int userNumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may now enter a second number to perform the operation on, or leave it blank.");
            string numTwo = Console.ReadLine();
            if (numTwo == "")
            {
                Console.WriteLine("The number / s you provided + 35 = " + mathOperation.Addition(userNumOne));
            }
            else
            {
                int userNumTwo = Convert.ToInt32(numTwo);
                Console.WriteLine("The number/s you provided + 35 = " + mathOperation.Addition(userNumOne, userNumTwo));
            }
            
            Console.ReadLine();


        }
    }
}
