using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\MN\source\repos\Adventofcode\Day5\Day5.txt");
            string line;

            var seatIDs = new List<decimal>();
            while ((line = file.ReadLine()) != null)
            {
                var row = CalculateRowValue(0, 127, line.Trim());
                var column = CalculateColumnValue(0, 7, line.Trim());
                seatIDs.Add(row * 8 + column);
            }

            seatIDs = seatIDs.OrderBy(q => q).ToList();
            var mySeat = 0m;
            for (var x = 0; x <= seatIDs.Count() - 1; x++)
            {
                if (seatIDs[x + 1] - seatIDs[x] > 1)
                {
                    mySeat = seatIDs[x] + 1;
                    break;
                }
            }

            Console.WriteLine($"The highest seat ID on a boarding pass : {seatIDs.Max()}");
            Console.WriteLine($"My Seat Id : {mySeat}");
        }
        public static decimal CalculateRowValue(decimal min, decimal max, string line)
        {
            var returnValue = 0m;
            for (var i = 0; i <= 6; i++)
            {
                if (line[i] == 'F')
                {
                    max = Math.Floor((min + max) / 2);
                    returnValue = max;
                }
                else if (line[i] == 'B')
                {
                    min = Math.Ceiling((max + min) / 2);
                    returnValue = min;
                }
            }
            return returnValue;
        }
        public static decimal CalculateColumnValue(decimal min, decimal max, string line)
        {
            var returnValue = 0m;
            for (var i = 7; i <= 9; i++)
            {
                if (line[i] == 'L')
                {
                    max = Math.Floor((min + max) / 2);
                    returnValue = max;
                }
                else if (line[i] == 'R')
                {
                    min = Math.Ceiling((max + min) / 2);
                    returnValue = min;
                }
            }
            return returnValue;
        }
    }
}


