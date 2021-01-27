using System;

namespace BowlingScoreCalculator
{
    /// <summary>
    /// Description: https://docs.google.com/document/d/1J2TzjNmipwFEDh4gMl3TIdhRHBf4Ajq2Ig85MHnyT2w/edit#heading=h.euwzsooaoopd
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Type your score and press enter:"); 
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Frame {i}, Roll 1:");
                var roll1 = readAnInteger();
                
                if (roll1 == 10)
                {
                    //todo call your method, e.g.: frame(roll1,null)
                }
                else if (roll1 < 10)
                {
                    Console.WriteLine($"Frame {i}, Roll 2:");
                    var roll2 = readAnInteger();
                    //todo call your method, e.g.: frame(roll1,roll2)
                }
            }

            Console.WriteLine("Result:");
            Console.ReadLine();
        }

        private static int readAnInteger()
        {
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToLower().Replace("x", "10");
            }

            if (!int.TryParse(input, out var integer) || integer>10)
            {
                Console.WriteLine("Again! It can be number between 0..10 or X!");
                return readAnInteger();
            }

            return integer;
        }
    }
}
