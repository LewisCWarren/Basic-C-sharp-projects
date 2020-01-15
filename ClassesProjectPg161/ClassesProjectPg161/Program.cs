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
            
            mathOperation.Addition(10, 10);
            Console.ReadLine();
            mathOperation.Addition(userNumOne: 40, userNumTwo: 10);
            Console.ReadLine();
        }
    }
}
