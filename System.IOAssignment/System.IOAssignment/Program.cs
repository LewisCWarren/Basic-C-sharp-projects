using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number");
            string userNum = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Logs\Assignment.txt", userNum);
            string readIt = File.ReadAllText(@"C:\Users\Student\Logs\Assignment.txt");
            Console.WriteLine(readIt);
            Console.ReadLine();
        }
    }
}
