using System;
using System.Collections.Generic;




    class Program
    {
        static void Main()
        {
            string[] stringArray = { "Red", "Blue", "Green", "Yellow", "Orange", "Purple", "Grey", };
            Console.WriteLine("Please select which color from the string array you would like to view");
            int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput > 6)
                {
                    Console.WriteLine("Sorry, that index does not exist");
                    Environment.Exit(0);
                }

            Console.WriteLine(stringArray[userInput]);
            Console.ReadLine();

            int[] intArray = { 3, 11, 24, 37, 29 };
            Console.WriteLine("Please select a number from the array to view via its index");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

                 if (userInput > 4)
                {
                    Console.WriteLine("Sorry, that index does not exist");
                    Environment.Exit(0);
                }

            Console.WriteLine(intArray[userInput1]);
            Console.ReadLine();


            List<string> stringList = new List<string>();
        stringList.Add("U.S.A.");
        stringList.Add("Canada");
        stringList.Add("Mexico");
        stringList.Add("United kingdom");
        stringList.Add("Japan");
        stringList.Add("Russia");

        Console.WriteLine("Please select a valid index from the list. Options 0 - 5");
        int listPick = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringList[listPick]);

        if (userInput > 5)
        {
            Console.WriteLine("Sorry, that index does not exist");
            Environment.Exit(0);
        }
        Console.ReadLine();

    }
    }

