using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\MN\source\repos\Adventofcode\Day6\Day6.txt");
            string line;
            var part1Result = 0;
            var part2Result = 0;

            var answers = new List<char>();

            var lines = new List<string>();
            var groups = new List<List<string>>();
            while ((line = file.ReadLine()) != null)
            {
                if (line != string.Empty)
                {
                    lines.Add(line);
                    foreach (var c in line)
                    {
                        answers.Add(c);
                    }
                }
                if (line == string.Empty)
                {
                    part1Result += CalculateValue(answers);
                    groups.Add(lines);
                    lines = new List<string>();
                    answers = new List<char>();
                }
            }
            groups.Add(lines);
            part1Result = part1Result + CalculateValue(answers);
            part2Result = Part2Calculation(groups);

            Console.WriteLine($"Part1 Result : {part1Result}");
            Console.WriteLine($"Part2 Result : {part2Result}");
        }

        public static int CalculateValue(List<char> answers)
        {
            var count = 0;
            foreach (var c in answers.Distinct())
            {
                count++;
            }
            return count;
        }

        public static int Part2Calculation(List<List<string>> groups)
        {

            var result = 0;

            foreach (var group in groups)
            {
                var checkedList = new List<char>();
                foreach (var line in group)
                {
                    foreach (var c in line)
                    {
                       
                        if (!checkedList.Contains(c))
                        {
                            checkedList.Add(c);
                            var count = 0;
                            foreach (var i in group)
                            {
                                if (i.Contains(c))
                                    count++;
                            }
                            if (count == group.Count()) { 
                                result++;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
