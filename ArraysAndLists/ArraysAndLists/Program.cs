﻿using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

        List<string> intList = new List<string>();
        intList.Add("Hello,");
        intList.Add("World");
        intList.Remove("World");

        Console.WriteLine(intList[0]);
        Console.ReadLine();



        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };

        //numArray2[3] = 650;

        //Console.WriteLine(numArray2[3]);
        //Console.ReadLine();

        
        }
    }

