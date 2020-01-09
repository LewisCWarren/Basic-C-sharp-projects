using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
        {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 92, 95 };

        for (int i = 0; i < testScores.Length; i++)

        {
            if (testScores[i] > 85)

            {
                Console.WriteLine(testScores[i]);
            }

        }

        Console.ReadLine();




        List<int> testScores = new List<int>();

        testScores.Add(98);
        testScores.Add(99);
        testScores.Add(32);
        testScores.Add(89);
        testScores.Add(78);
        testScores.Add(92);

        foreach (int score in testScores)

        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score:" + score);
            }
        }
        Console.ReadLine();


        List<string> names = new List<string>() { "Lewis", "Ryan", "Grant", "Mick" };

        foreach (string name in names)
        {
            Console.WriteLine(name);

        }

        Console.ReadLine();


        List<int> testScores = new List<int>() { 99, 97, 29, 49, 89, 90, 75 };

        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);
        Console.ReadLine();


    }
    }

