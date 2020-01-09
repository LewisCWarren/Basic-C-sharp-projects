using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {

        //    string[] countries =  { "U.S.A", "Canada", };

        //    Console.WriteLine("name a country. U.S.A., and Canada are already present");

        //    string userCountry = Console.ReadLine();

        

        //for (int i = 0; i < countries.Length; i++)
        //{
        //    Console.WriteLine(countries[i]);  
            
        //}

        //Console.WriteLine(userCountry);


        //Console.ReadLine();

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

        //for (int i = 0; i <= countries.Length + 1; i++)
        //{
        //    Console.WriteLine(countries[i]);
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Lewis", "Grant", "Dave", "Ryan", "Mick", "Kayla", "Thea" };

        //Console.WriteLine("Please enter a search term for the string");
        //string userSearch = Console.ReadLine();


        //foreach (string name in names)
        //{
        //    bool found = name.Contains(userSearch);
        //    if (found == true)
        //    {
        //        Console.WriteLine(name);
        //        break;

        //    }

        //    else if (!found)
        //    {
        //        Console.WriteLine("No matching text found in the list.");
        //        break;
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Lewis", "Grant", "Dave", "Ryan", "Mick", "Kayla", "Thea", "Lewis" };

        //Console.WriteLine("Please enter a search term for the string");
        //string userSearch = Console.ReadLine();



        //for (int i = 0; i < names.Count; i++)
        //{

        //bool found = names[i].Contains(userSearch);
        //    if(found == true)
        //    {
        //        Console.WriteLine(i);


        //    }

        //    else
        //    {
        //        Console.WriteLine("There is no matching text found.");
        //    }
        //}
        //Console.ReadLine();

        List<string> names = new List<string>() { "Lewis", "Grant", "Dave", "Ryan", "Mick", "Kayla", "Thea", "Lewis", "Lewis" };

        Console.WriteLine("Please enter a search term for the string");
        string userSearch = Console.ReadLine();
        int i = 0;

        foreach (string name in names)
        {
            bool found = name.Contains(userSearch);
            


            if (found == true)
            {
                i++;
                
                Console.WriteLine(name);
                if (i >= 2)
                {
                        Console.WriteLine("This value has appeared " + i + " times.");
                }
                

                
            }
            
        }
        Console.ReadLine();


    }
}

