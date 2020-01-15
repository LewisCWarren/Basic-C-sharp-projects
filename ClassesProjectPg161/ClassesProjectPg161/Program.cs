using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectPg161
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathOperation = new Math();

            Console.WriteLine("please enter a number");
            int userNumOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int userNumTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first number has had 20 added to it. the second number has been left alone.");
            mathOperation.Addition(userNumOne, userNumTwo);
            Console.ReadLine();
        }
    }
}
