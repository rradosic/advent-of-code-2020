using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Advent_of_Code._02
{
    class Day2:IDaySolution
    {
        private string filePath = "01/Inputs.txt";

        public void Solve()
        {
            string[] values = File.ReadAllLines(filePath);
            string unseparated = values[0];
            List<int> intcode = unseparated.Split(',').Select(Int32.Parse).ToList();

            int pos = 0;
            bool error = false;
            while (!error)
            {
                int opcode = intcode[pos];
                int input1 = intcode[pos + 1];
                int input2 = intcode[pos + 2];
                int output = intcode[pos + 3];

                switch (opcode)
                {
                    case 1:
                        int result = input1 + input2;
                        intcode[output] = result;
                        break;
                    case 2:
                        int result2 = input1 * input2;
                        intcode[output] = result2;
                        break;
                    case 99:
                        error = true;
                        break;
                }

                if (error) break;

                pos += 4;
            }
            Console.WriteLine("Result: " + intcode[0]);
        }
    }
}
