using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 23, 40, 31, 11, 18, 75 };
        Console.WriteLine("Please enter a number, this number will be used to divide all numbers in the list seperately");
        


        try
        {
            int userNum = Convert.ToInt32(Console.ReadLine());
            foreach (int num in numbers)
            {
                int result = num / userNum;
                Console.WriteLine(result);
            }
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You may not divide by zero");
            return;
        }

        catch (FormatException ex)
        {
            Console.WriteLine("Please enter only a whole number");
            return;
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }
        finally
        {
            Console.WriteLine("Program has returned to execution.");
            Console.ReadLine();
            
        }
        Console.ReadLine();
    }
}

