using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter hourly rate");
            string person1Rate = Console.ReadLine();
            Console.WriteLine("Please enter hours worked per week");
            string person1Hours = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter hourly rate");
            string person2Rate = Console.ReadLine();
            Console.WriteLine("Please enter hours worked per week");
            string person2Hours = Console.ReadLine();

            int rate1 = Convert.ToInt32(person1Rate);
            int hours1 = Convert.ToInt32(person1Hours);
            int salary1 = rate1 * hours1;
            Console.WriteLine("Weekly salary of person 1:");
            Console.WriteLine(salary1);

            int rate2 = Convert.ToInt32(person2Rate);
            int hours2 = Convert.ToInt32(person2Hours);
            int salary2 = rate2 * hours2;
            Console.WriteLine("Weekly salary of person 2:");
            Console.WriteLine(salary2);


            bool comparison = salary1 > salary2;
            Console.WriteLine("Does person 1 make more than person 2?");
            Console.WriteLine(comparison);
            Console.ReadLine();





        }
    }
}
