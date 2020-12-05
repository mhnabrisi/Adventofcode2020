using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\MN\source\repos\Adventofcode\Day4\Day4.txt");
            string line;

            var passportInfo = new List<(string, string)>();
            var count = 0;

            while ((line = file.ReadLine()) != null)
            {
                if (line != string.Empty)
                {
                    var splits = line.Split(" ");
                    foreach (var split in splits)
                    {
                        var items = split.Split(":");
                        passportInfo.Add((items[0], items[1]));
                    }
                }
                if (line == string.Empty)
                {
                    if (CheckifValid(passportInfo))
                        count++;

                    passportInfo = new List<(string, string)>();
                }
            }
            if (CheckifValid(passportInfo))
                count++;
            Console.WriteLine(count);
        }

        public static bool CheckifValid(List<(string, string)> passportInfo)
        {
            bool isValid = false;

            if (passportInfo.Any(q => q.Item1 == "byr") && passportInfo.Any(q => q.Item1 == "iyr") && passportInfo.Any(q => q.Item1 == "eyr")
                && passportInfo.Any(q => q.Item1 == "hgt") && passportInfo.Any(q => q.Item1 == "hcl") && passportInfo.Any(q => q.Item1 == "ecl")
                && passportInfo.Any(q => q.Item1 == "pid"))
                isValid = true;

            if (isValid)
            {
                var birthYear = Convert.ToInt32(GetValue(passportInfo, "byr"));
                if (!(birthYear >= 1920 && birthYear <= 2002))
                    return false;

                var issueYear = Convert.ToInt32(GetValue(passportInfo, "iyr"));
                if (!(issueYear >= 2010 && issueYear <= 2020))
                    return false;

                var expirationYear = Convert.ToInt32(GetValue(passportInfo, "eyr"));
                if (!(expirationYear >= 2020 && expirationYear <= 2030))
                    return false;

                var height = GetValue(passportInfo, "hgt");
                if (!(height.Contains("cm") || height.Contains("in")))
                    return false;

                var heightType = height.Substring(height.Length - 2);
                var intHeight = Convert.ToInt32(height.Substring(0, height.Length - 2));
                if (heightType == "cm")
                {
                    if (!(intHeight >= 150 && intHeight <= 193))
                        return false;
                }
                else if (heightType == "in")
                {
                    if (!(intHeight >= 59 && intHeight <= 76))
                        return false;
                }

                var hairColor = GetValue(passportInfo, "hcl");
                string colorRegex = @"^#(?:[0-9a-fA-F]{3}){1,2}$";
                Regex re = new Regex(colorRegex);
                if (!re.IsMatch(hairColor.Trim()))
                    return false;

                string[] validEyeColor = { "amb", "blu", "brn", "gry", "grn", "hzl", "oth" };
                var eyeColor = GetValue(passportInfo, "ecl");
                if (!validEyeColor.Contains(eyeColor.Trim()))
                    return false;

                var passportID = GetValue(passportInfo, "pid");
                string passportIDRegex = @"^[0-9]{9}$";
                Regex reg = new Regex(passportIDRegex);
                if (!reg.IsMatch(passportID.Trim()))
                    return false;
            }


            return isValid;
        }

        public static string GetValue(List<(string, string)> passportInfo, string prop)
        {
            return passportInfo.FirstOrDefault(q => q.Item1 == prop).Item2;
        }

    }
}
