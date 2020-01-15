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
            Console.WriteLine("please enter a number.");
            mathOperation.Division(out int userNum);
            Console.WriteLine("the number provided divided by 2 = " + userNum);
            
            Console.ReadLine();
            

        }


    }

   
}
