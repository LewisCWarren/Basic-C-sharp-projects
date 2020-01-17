using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClassProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employeeString = new Employee<string>();
            employeeString.things = new List<string>();
            employeeString.things.Add("stuff");
            employeeString.things.Add("nouns not including person, or places");
            employeeString.things.Add("hullabaloo");

            Employee<int> employeeNum = new Employee<int>();
            employeeNum.things = new List<int>();
            employeeNum.things.Add(11);
            employeeNum.things.Add(78143);
            employeeNum.things.Add(99);


            for (int i = 0; i < employeeNum.things.Count; i++)
            {
                Console.WriteLine(employeeNum.things[i]);
            }
            for (int i = 0; i < employeeString.things.Count; i++)
            {
                Console.WriteLine(employeeString.things[i]);
            }
            Console.ReadLine();











        }
    }
}
