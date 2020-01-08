using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter package weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            string refusal = packageWeight > 50 ? "Package is too heavy to be shipped via package express" : "Please enter package width";

            Console.WriteLine(refusal);
            
            

            if (packageWeight > 50)
            {
                Environment.Exit(0);
            }

            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter package height");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            int packageDimensions = packageWidth + packageHeight + packageLength;

            int price = packageDimensions * packageWeight;

            if (packageDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via package express.");
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("The price to ship this packe will be " + price + ".00");
                Console.ReadLine();
            }






        }
    }
}
