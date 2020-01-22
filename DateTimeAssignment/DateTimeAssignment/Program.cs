using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            
            Console.WriteLine("\n Please enter a number.");
            double userInput = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine( DateTime.Now.AddHours(userInput));
            Console.ReadLine();
            

        }
    }
}
