using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string userNumber = Console.ReadLine();
            int userNum1 = Convert.ToInt32(userNumber);
            Console.WriteLine(userNum1 * 50);
            string userAddNum = Console.ReadLine();
            int addNum = Convert.ToInt32(userAddNum);
            Console.WriteLine(addNum + 25);
            string userDivNum = Console.ReadLine();
            int divNum = Convert.ToInt32(userDivNum);
            Console.WriteLine(divNum / 12.5);
            string userGreaterThan = Console.ReadLine();
            int GreaterThan = Convert.ToInt32(userGreaterThan);
            bool isIt = GreaterThan > 50;
            Console.WriteLine(isIt);
            string userRemainder = Console.ReadLine();
            int remainder = Convert.ToInt32(userRemainder);
            Console.WriteLine(remainder % 7);
            Console.ReadLine();




        }
    }
}
