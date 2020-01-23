using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg._231Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            
    
        

                Console.WriteLine("Please enter your name");
                string userName = Console.ReadLine();
                var person = new Person(userName);
                const string farewell = "have a great day";
            Console.WriteLine(person.Name + " " + person.FavColor + " " + person.FavNumber + "\n" + farewell);

                Console.ReadLine();
            
        }
    }


 
    
}
