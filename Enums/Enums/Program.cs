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
            string userDay = Console.ReadLine();
            

       


        List<DaysOfTheWeek> days = new List<DaysOfTheWeek>();
            days.Add(DaysOfTheWeek.Sunday);
            days.Add(DaysOfTheWeek.Monday);
            days.Add(DaysOfTheWeek.Tuesday);
            days.Add(DaysOfTheWeek.Wednesday);
            days.Add(DaysOfTheWeek.Thursday);
            days.Add(DaysOfTheWeek.Friday);
            days.Add(DaysOfTheWeek.Saturday);

            for (int i = 0; i < days.Count; i++)
            {
                string day = Convert.ToString(days[i]);
                
                bool userInput = userDay == day;

                if (userInput == true)
                {
                    Console.WriteLine(day);
                    Console.WriteLine("yes, that is a day of the week.");
                }

                
                

                
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
