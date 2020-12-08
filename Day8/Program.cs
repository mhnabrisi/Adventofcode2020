using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\MN\source\repos\Adventofcode\Day8\Day8.txt");
            string line;


            var codes = new List<(int, string, int)>();
            var index = 0;
            while ((line = file.ReadLine()) != null)
            {
                var splits = line.Split(' ');
                codes.Add((index, splits[0].Trim(), Convert.ToInt32(splits[1].Trim())));
                index++;
            }

            var part1 = Part1Calculation(codes);
            var part2 = Part2Calculation(codes);

            Console.WriteLine($"Part1 Result : { part1 }");
            Console.WriteLine($"Part2 Result : { part2 }");
        }

        public static int Part1Calculation(List<(int, string, int)> codes)
        {
            var result = 0;
            var checkedList = new List<int>();

            for (int c = 0; !checkedList.Contains(c);)
            {
                var code = codes.First(q => q.Item1 == c);
                NewMethod(ref result, checkedList, ref c, code);
            }
            return result;
        }
        public static int Part2Calculation(List<(int, string, int)> codes)
        {
            var result = 0;

            foreach (var item in codes.Where(q => q.Item2 == "nop" || q.Item2 == "jmp").ToList())
            {
                result = 0;
                var checkedList = new List<int>();
                for (int c = 0; !checkedList.Contains(c);)
                {
                    if (c == codes.Count)
                        return result;

                    var code = codes.First(q => q.Item1 == c);
                    if (item.Item1 == c)
                    {
                        if (code.Item2 == "nop")
                            code.Item2 = "jmp";
                        else if (code.Item2 == "jmp")
                            code.Item2 = "nop";
                    }
                    NewMethod(ref result, checkedList, ref c, code);
                }
            }
            return result;
        }
        private static void NewMethod(ref int result, List<int> checkedList, ref int c, (int, string, int) code)
        {
            switch (code.Item2)
            {
                case "acc":
                    result = result + code.Item3;
                    checkedList.Add(c);
                    c++;
                    break;
                case "jmp":
                    checkedList.Add(c);
                    c = c + code.Item3;
                    break;
                case "nop":
                    checkedList.Add(c);
                    c++;
                    break;
            }
        }
    }
}
