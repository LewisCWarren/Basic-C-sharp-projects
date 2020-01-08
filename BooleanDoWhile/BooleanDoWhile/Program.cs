using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please write in you favorite color");
            string color = Console.ReadLine();
            bool rightColor = false;
            
            do
            {
                switch (color)
                {
                    default:
                        Console.WriteLine("meh, that colors okay, what else do you like?");
                        color = Console.ReadLine();
                        break;

                    case "red" :
                        Console.WriteLine("Great choice");
                        rightColor = true;
                        break;

                    case "blue":
                        Console.WriteLine("Great choice");
                        rightColor = true;
                        break;

                }
                
            }
            while (!rightColor);
            Console.ReadLine();

            Console.WriteLine("Guess a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool rightNumber = false;

            while (!rightNumber)
            {
                switch(number)
                    {
                    case 11:
                        Console.WriteLine("That's correct!");
                        rightNumber = true;
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("That's not the right number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
            }
        }
    }
}
