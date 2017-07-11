using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    class Program
    {
        //gives correct values for all valid roman numerals
        static void Main(string[] args)
        {
            //dictionary containing base numerical values
            Dictionary<char, int> letterValues = new Dictionary<char, int>();
            letterValues.Add('I', 1);
            letterValues.Add('V', 5);
            letterValues.Add('X', 10);
            letterValues.Add('L', 50);
            letterValues.Add('C', 100);
            letterValues.Add('D', 500);
            letterValues.Add('M', 1000);

            //string containing descending order of char values
            string charPriority = "MDCLXVI";

            //input
            Console.WriteLine("Input numerals");
            string input = Console.ReadLine().ToUpper();

            //loop values
            int runningTotal = 0;
            bool negative = false;

            for (int i = 0; i <= input.Length-1; i++)
            {
                negative = false;
                if (i!=input.Length-1) //if not last number, ie not def. positive
                {
                    if (charPriority.IndexOf(input[i]) > charPriority.IndexOf(input[i + 1])) //if situation like IV or IX occurs
                    {
                        runningTotal -= letterValues[input[i]];
                        negative = true;
                    }
                }
                
                if (!negative)
                    runningTotal += letterValues[input[i]];
            }
            Console.WriteLine("Total is: " + runningTotal.ToString());
            Console.ReadLine();
        }
    }
}
