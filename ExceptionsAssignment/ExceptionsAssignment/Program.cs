using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("please enter your age");
                int userAge = Convert.ToInt32(Console.ReadLine());
                bool lieDetector = userAge > 0;
                if (!lieDetector)
                {
                    throw new NotUserAgeException();
                }
                DateTime currentYear = new DateTime(2020);
                DateTime userNum = new DateTime(userAge);
                TimeSpan yearBorn = currentYear - userNum ;

                
                

                Console.WriteLine(yearBorn);
                Console.ReadLine();
                
            }
            catch (NotUserAgeException)
            {
                Console.WriteLine("Uh oh! You've set off the BS alarm, there's no incentive to lie here...");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, there has been an error..");
                Console.ReadLine();
                return;
            }
        }
    }
}
