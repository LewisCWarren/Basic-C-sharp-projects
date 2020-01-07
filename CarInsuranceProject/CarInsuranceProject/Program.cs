using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your age");
            string personAge = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer either \"true\" or \"false\".");
            string personDUI = Console.ReadLine();
            Console.WriteLine("How man speeding tickets do you have?");
            string personTickets = Console.ReadLine();

            int age = Convert.ToInt32(personAge);
            bool DUI = Convert.ToBoolean(personDUI);
            int tickets = Convert.ToInt32(personTickets);

            bool allowedInsurance = age > 15 && DUI == false && tickets <= 3;
            Console.WriteLine("Your application for car insurance has been accepted: ");
            Console.WriteLine(allowedInsurance);
            Console.ReadLine();
        }
    }
}
