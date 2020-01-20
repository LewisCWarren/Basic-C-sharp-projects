using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a day of the week");





            try
            {

                string value = Console.ReadLine();
                bool success = Enum.TryParse<DaysOfTheWeek>(value, true, out DaysOfTheWeek result);

                if (success == true)
                {
                    Console.WriteLine("Yes, that is a day of the week: {0}", result);
                }
                else
                {
                    throw new Exception();
                }
            }

            catch 
            {
                Console.WriteLine("Please enter a valid day of the week");
            }

            Console.ReadLine();




        }
    }

    
      

        

    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}
