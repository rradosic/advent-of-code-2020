using Advent_of_Code._01;
using Advent_of_Code._02;
using System;
using System.Collections.Generic;

namespace Advent_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDaySolution> solutions = new List<IDaySolution>();

            solutions.Add(new Day1());
            solutions.Add(new Day2());

            Console.WriteLine("ADVENT OF CODE 2020");
            WriteChristmasLights(35);
            Console.WriteLine("Input 'x' to exit");
            string day;
            do
            {
                WriteChristmasLights(35);
                Console.Write("Day: ");
                day = Console.ReadLine();
                int dayValue = Int32.Parse(day) - 1;
                solutions[dayValue].Solve();
            } while (day != "x"); 
        }

        static void WriteChristmasLights(int length)
        {
            Random random = new Random();

            ConsoleColor[] availableConsoleColors = { ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Green };

            for (int i = 0; i < length; i++)
            {
                if (i%2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("-");
                }
                else
                {
                    Console.ForegroundColor = availableConsoleColors[random.Next(0, availableConsoleColors.Length)];
                    Console.Write("*");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
