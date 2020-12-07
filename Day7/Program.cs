using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region convert Text to list..
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\MN\source\repos\Adventofcode\Day7\Day7.txt");
            string line;

            var rules = new Dictionary<string, List<(int, string)>>();

            while ((line = file.ReadLine()) != null)
            {
                string bagColor = ExtractBagColor(line, true);
                var newLine = line.Replace(bagColor + " bags contain ", "");
                var innerBags = newLine.Split(',');

                var values = new List<(int, string)>();
                if (!line.Contains("contain no other bags"))
                {
                    foreach (var b in innerBags)
                    {
                        var color = ExtractBagColor(b.Trim().TrimEnd('.'), false);
                        int count = 0;

                        count = ExtractBagCount(b.Trim().TrimEnd('.'));

                        values.Add((count, color));
                    }
                }
                rules.Add(bagColor, values);
            }
            #endregion
            var part1 = 0;
            foreach (var rule in rules)
            {
                if (HandelInherits(rules, rule.Key))
                    part1++;
            }

            var part2Root = rules.FirstOrDefault(q => q.Key == "shiny gold").Value;
            var part2 = Part2Calculation(rules, part2Root);

            Console.WriteLine($"Part1 result : {part1}");
            Console.WriteLine($"Part2 result : {part2}");
        }

        public static bool HandelInherits(Dictionary<string, List<(int, string)>> rules, string bagColor, bool result = false)
        {
            if (rules.ContainsKey(bagColor))
            {
                foreach (var color in rules[bagColor])
                {
                    if (color.Item2 == "shiny gold")
                        result = true;
                    else
                        result = HandelInherits(rules, color.Item2, result);
                }
            }
            return result;
        }

        public static int Part2Calculation(Dictionary<string, List<(int, string)>> rules, List<(int, string)> bag, int result = 0)
        {
            foreach (var item in bag)
                result = result + item.Item1 * (1 + Part2Calculation(rules, rules.FirstOrDefault(q => q.Key == item.Item2).Value));
            return result;
        }

        public static string ExtractBagColor(string str, bool isMainBag)
        {
            string[] splits = str.Split(' ');
            if (!isMainBag)
                return splits[1] + " " + splits[2];

            return splits[0] + " " + splits[1];
        }

        public static int ExtractBagCount(string str)
        {
            string[] splits = str.Split(' ');
            return Convert.ToInt32(splits[0]);
        }

    }
}
