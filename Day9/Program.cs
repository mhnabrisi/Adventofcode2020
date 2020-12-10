using System;
using System.Collections.Generic;
using System.Linq;

namespace Day9
{
    class Program
    {
        public const int rangeCount = 25;
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\MN\source\repos\Adventofcode\Day9\Day9.txt");
            string line;

            var numbers = new List<double>();
            while ((line = file.ReadLine()) != null)
            {
                numbers.Add(Convert.ToDouble(line));
            }

            var part1 = Part1Calculation(numbers, rangeCount);
            var part2 = Part2Calculation(numbers, part1);
            Console.WriteLine($"Part1 Result : {part1}");
            Console.WriteLine($"Part2 Result : {part2}");
        }

        public static double Part1Calculation(List<double> numbers, int prevCount)
        {
            var result = 0d;
            for (int c = prevCount; c < numbers.Count; c++)
            {
                var num = numbers[c];
                var flag = false;
                var lastNNumber = numbers.GetRange(c - prevCount, prevCount).Where(q => q < numbers[c]).OrderBy(q => q).ToList();
                for (int i = 0; i < lastNNumber.Count; i++)
                {
                    var num1 = lastNNumber[i];
                    for (int j = 0; j < lastNNumber.Count; j++)
                    {
                        var num2 = lastNNumber[j];
                        if (i != j)
                        {
                            if (num == num1 + num2)
                            {
                                flag = true;
                                break;
                            }
                        }
                    }
                    if (flag)
                        break;
                    else
                    {
                        lastNNumber.RemoveAt(i);
                        i--;
                    }
                }
                if (!flag)
                    return numbers[c];
            }
            return result;
        }
        public static double Part2Calculation(List<double> numbers, double number)
        {
            var result = 0d;
            var lst = new List<double>();
            for (int i = 0; i < numbers.Count; i++)
            {
                lst.Add(numbers[i]);
                if (HandelList(lst, number).Sum() == number)
                {
                    result = lst.Min() + lst.Max();
                    break;
                }
            }
            return result;
        }
        public static List<double> HandelList(List<double> numbers, double number)
        {
            if (numbers.Sum() > number)
            {
                numbers.RemoveAt(0);
                HandelList(numbers, number);
            }
            return numbers;
        }
    }
}
