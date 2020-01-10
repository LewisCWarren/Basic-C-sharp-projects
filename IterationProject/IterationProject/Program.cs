using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {

        string[] countries = { "U.S.A", "Canada", };

        Console.WriteLine("name a country. U.S.A., and Canada are already present");

        string userCountry = Console.ReadLine();



        for (int i = 0; i < countries.Length; i++)
        {
            Console.WriteLine(countries[i] + " " + userCountry);

        }

        


        Console.ReadLine();

        //for (int i = 0; i < countries.Length; i++)
        //{
        //    Console.WriteLine(countries[i] + "\n");
        //}

        //Console.WriteLine(userCountry);
        //Console.ReadLine();

        //for (int i = 0; i < countries.Length; i--)//source of the infinite loop on this line
        //{
        //    Console.WriteLine(countries[0]);
        //}

        //for (int i = 0; i < countries.Length; i++)
        //{
        //    Console.WriteLine(countries[0]);
        //}

        //for (int i = 0; i <= 1; i++)
        //{
        //    Console.WriteLine(countries[i]);
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Lewis", "Grant", "Dave", "Ryan", "Mick", "Kayla", "Thea" };

        //Console.WriteLine("Please enter a search term for the string");
        //string userSearch = Console.ReadLine();

        //for (int i = 0; i < names.Count; i++)
        //{
        //    if (userSearch == names[i])
        //    {
        //        Console.WriteLine(i);
        //        break;

        //    }

        //    else if (i == 6)
        //    {
        //        Console.WriteLine("That value is not included in the array");
        //    }
        //}


        //Console.ReadLine();

        //List<string> names = new List<string>() { "Lewis", "Grant", "Dave", "Ryan", "Mick", "Kayla", "Thea", "Lewis" };

        //Console.WriteLine("Please enter a search term for the string");
        //string userSearch = Console.ReadLine();



        //for (int i = 0; i < names.Count; i++)
        //{
        //    int result = 0;
        //    if (userSearch == names[i])
        //    {
        //        Console.WriteLine(i);
        //        result++;

        //    }

        //    else if (i == names.Count && result == 0)
        //    {
        //        Console.WriteLine("That value is not included in the array");
        //    }
        //}


        //Console.ReadLine();

        //List<string> names = new List<string>() { "Lewis", "Grant", "Dave", "Ryan", "Mick", "Kayla", "Thea", "Lewis", "Lewis" };

        //Console.WriteLine("Please enter a search term for the string");
        //string userSearch = Console.ReadLine();
        //List<string> newList = new List<string>();

        
        //foreach (string name in names)
        //{

        //  if (newList.Contains(name))
        //    {
        //        Console.WriteLine(name + "This name is already present on new list");
                
        //    }

        //  else if (!newList.Contains(name))
        //    {
        //        newList.Add(name);
        //    }
        //}

        

        //Console.ReadLine();


    }
}

