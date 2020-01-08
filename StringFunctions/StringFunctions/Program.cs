using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lewis";
            string quote = "The man said, \"hello, Lewis\". \n \t hello on a new line";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Lewis");
            Console.WriteLine(sb);
            Console.ReadLine();

            string one = "This sentence";
            string two = " is actually three variables, ";
            string three = "the last of which is all in caps.";

            three = three.ToUpper();

            Console.WriteLine(one + two + three);
            Console.ReadLine();

            sb.AppendLine("Hello World, this paragraph brought to you by the power of \n StringBuilder!");
            sb.AppendLine("If all goes well, String builder will print all of these out without me");
            sb.AppendLine("needing to create a new variable and assign the value.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
