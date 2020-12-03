using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Advent_of_Code;
namespace Advent_of_Code._01
{
    class Day1 : IDaySolution
    {
        private string filePath = "01/Inputs.txt";
        public void Solve()
        {
            PartOne();
            PartTwo();
        }

        private void PartOne()
        {
            string[] values = File.ReadAllLines(filePath);

            int total = 0;
            Tuple<int, int> tuple = new Tuple<int, int>(0,0);

            for (int i = 0; i < values.Length; i++)
            {
                int expenseNumber = Int32.Parse(values[i]);

                for (int y = i; y < values.Length; y++)
                {
                    int secondExpenseNumber = Int32.Parse(values[y]);
                    int sum = expenseNumber + secondExpenseNumber;

                    if (sum == 2020)
                    {
                        tuple = new Tuple<int,int>(expenseNumber, secondExpenseNumber);

                        break;
                    }
                }

                if (tuple.Item1 != 0)
                {
                    break;
                }
            }
            total = tuple.Item1 * tuple.Item2;
            Console.WriteLine("Result part one: " + total);
        }

        private void PartTwo()
        {
            string[] values = File.ReadAllLines(filePath);

            int total = 0;

            Tuple<int, int, int> tuple = new Tuple<int, int, int>(0, 0, 0);

            for (int i = 0; i < values.Length; i++)
            {
                int expenseNumber = Int32.Parse(values[i]);

                for (int y = i; y < values.Length; y++)
                {
                    int secondExpenseNumber = Int32.Parse(values[y]);

                    for (int z = y; z < values.Length; z++)
                    {
                        int thirdExpenseNumber = Int32.Parse(values[z]);
                        int sum = expenseNumber + secondExpenseNumber + thirdExpenseNumber;

                        if (sum == 2020)
                        {
                            tuple = new Tuple<int, int, int>(expenseNumber, secondExpenseNumber, thirdExpenseNumber);

                            break;
                        }
                    }

                    if (tuple.Item1 != 0)
                    {
                        break;
                    }

                }

                if (tuple.Item1 != 0)
                {
                    break;
                }
            }
            total = tuple.Item1 * tuple.Item2 * tuple.Item3;
            Console.WriteLine("Result part one: " + total);
        }
    }
}
