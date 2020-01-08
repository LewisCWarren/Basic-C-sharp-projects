using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {



            int roomTemp = 70;

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", what is the temp where you are?");
            int currentTemp = Convert.ToInt32(Console.ReadLine());

            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperature");    

            }   

            else
            {
                Console.WriteLine("It is not room temperature");
            }

            Console.ReadLine();



            //int currentTemp = 70;
            //int roomTemp = 70;

            //string comparison = currentTemp == roomTemp ? "It is room Temp." : "It is not room temp.";

            //Console.WriteLine(comparison);

            //if (currentTemp == roomTemp)

            //{
            //    Console.WriteLine("It is exactly room temp.");
            //    Console.ReadLine();
            //}

            //else

            //{
            //    Console.WriteLine("Its not room temp currently.");
            //}
            //Console.ReadLine();
        }
    }
}
