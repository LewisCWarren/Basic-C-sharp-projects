using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesProjectPg164
{
    static class Program
    {
        static void Main(string[] args)
        {
            Math mathOperation = new Math();

            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number provided divided by 2 = ");
            mathOperation.Division(userNum);
            Console.ReadLine();
            

        }


    }
}
