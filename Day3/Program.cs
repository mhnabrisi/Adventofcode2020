﻿using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entries = {
                ".##.............##......#.....#",
                ".#.#................#..........",
                "...#..#.##..#.#......#.#.#.#..#",
                "..#......#........#..#..#.#.#..",
                ".......#....#..#..#.......#....",
                "..#..#..##.#...#........#.###..",
                "..#...#..#.....#.##....#.......",
                "....#..###.#......#.##..#...##.",
                "..#..........#.##.#...#........",
                "#...#............##....#..##...",
                ".......##....#.....##..#.#..#.#",
                "..#..#..#...#....#....#....#...",
                ".#...#.##........#####........#",
                "..#..#......#.....##...#.......",
                "....#......##....#.#....#.#..##",
                "#.#.##....##..#.........#.###..",
                "##..###..#..#.......###.......#",
                "...#.#......#.........#....#...",
                ".....#..........#.....##..#.#..",
                "....##......#.#..#....#.#......",
                "..#.....#..##.......##......#..",
                ".........##.##.#..##...........",
                "....#...#.....#....#.#.###....#",
                ".##.#..#...##..#.......#......#",
                "##..#..#..####..#.#..#...#.....",
                "..###..#..#..#.###..#....#.##..",
                "......#...###.#.#.....#........",
                ".....#...#.#...#.......#.....#.",
                "#........#..##...........#..#..",
                ".#.##.##...#.....#.#....#..#...",
                "..##.##....#.....#....#....##..",
                "#.........##...##..#.....#..#..",
                "........#.####....#...##.....#.",
                ".#.#...#..#..#.#......##.....#.",
                "..#..........##..#.#.#....#...#",
                "#.......#...#...#.....#.##.#...",
                "..#.....#..#.....####.#..#.#.##",
                "...#.#..#...#.....#...#.#.#.#.#",
                ".#..##....##.....#..#....###...",
                "....#......##.#.#.....#......#.",
                "..#.#...#......#.....##.......#",
                "..#...###...#..#.#...#..#.....#",
                "#..............#.....#....##..#",
                ".#...#.......#.............#...",
                "..###....#.##........#.#.......",
                "#.##.......#..#............###.",
                "#...#..##.#.#............######",
                "..##..#....#.#.###...#..##.##..",
                ".#...#.###.#....#...#....#...#.",
                "#...#.......#...........#...##.",
                "##.#......#####.............#..",
                "....#..#......##..#..........#.",
                "#.....#.....#.#.......#...#...#",
                "....#...#.#..##........#.#..##.",
                "..##.....##............#.#.###.",
                "#.........#........#..###......",
                "............#..................",
                ".#.###...####...#.#..#......#..",
                "...##.###.#....##.#..####..#.##",
                "..#####.#.##...#.#...##.##....#",
                "........##...#...#....##.....##",
                "#...........###...#.#...##.#...",
                "##......#...#.......###........",
                "..#..#.##.#..###....#..#.###.#.",
                "...#.#.#...#....#.##..#...#....",
                "........#.##...##.#.....##...##",
                ".#..........##..#..#..#.#...#..",
                "#.#...#.##.#....#.##..#........",
                ".#.#.#....##..##.####.....###..",
                "..#....##....#..#..#..##.......",
                "..##...#.......#...##.#....#...",
                "...####.#.#...........#.#...#..",
                "....####.....#.#.....#....##.##",
                "..#.....#.#.............##....#",
                "#.#....#####.##..####.#...#.#..",
                "#.#....#.##.#.#.##..#.#...#....",
                "......#.......#.......#.....#..",
                "..#.....#....###.###..#..#..#..",
                "#..#....##.###...##.....#......",
                "..#..#...#..#.##..........#....",
                "...#.#.#......#....#.##..#..##.",
                "....##.#....#..#...##....###...",
                "##.#.###.....#..#.#.#..#.....##",
                "##..#.#........#...#..#.#......",
                "....#.#.......##.#...........#.",
                ".......##...#...#...#.....#....",
                ".....#....#..#..###.#...#......",
                "............#.#..#......#.#....",
                "...##..#.##....##..##.#......#.",
                "#.#.#......#.#.....#.#.#..#.#.#",
                "...###..........#..#..#.##.....",
                "......#......#......###..##....",
                "#...##...#....#....#..#...#.#..",
                ".......#..#......##.......#....",
                "...#..#..#.....#.....#......##.",
                "..#....###..........##..#...#..",
                "..........#..#.#...#......#..#.",
                "#...#....#.##.........#.#.#...#",
                ".#.#.#...#.#...#.#..#..#....#.#",
                "#.##....#..#.........#.##.##..#",
                "..#.#..##.#....#.###.#...#....#",
                ".#.......#...#.#.........#....#",
                ".......#...#..........#.#..#...",
                "...#.....##..#....#...###...#.#",
                "#....##.##..........#.......#..",
                ".##..##......#...#....#.##....#",
                "....#.....##...##.#..#.........",
                "...#.#..##.#.#..#.......#....#.",
                ".#...#.#.#.#..#..#.##.......#..",
                "..#..##...#.#..#.......#.#####.",
                ".......#.#...........#....#.#..",
                ".#.###..........#...#..#...#...",
                "..#.#............##......##....",
                "...##..#...###...##....#.#.##..",
                "....#.##...#..#.#.#...........#",
                "....#..#....##.....#.##.#.....#",
                "..##......##.#.........#....#.#",
                "###...#...#..#.#...#...........",
                ".####.....#.....#.#....#..#....",
                ".#....#..#..#..#...##.....###.#",
                "#....##.#....#.##..#......##..#",
                ".........#..#.#.....#.#....##.#",
                ".....#.#...#....#.#...#....#..#",
                ".#...#.#.....#.#......#.#......",
                "#....##.......#.............#..",
                "#..#...#........##..#..#......#",
                "####..##.#..##..#.........####.",
                ".#.##..#.#..#.#.#.##...#..#.#.#",
                ".##.#..#............#......#...",
                "###....#.##....#..#...#........",
                ".....#..###..........#..#......",
                ".##..##.....#..##....#...#.....",
                "#...##...........#..#...###..#.",
                "#..##....#...#.##.##....#......",
                "...#...#..#.#.......##.......##",
                "....#.....#..#...#.........#.#.",
                ".#...##.#......#.#..#..#...##..",
                "...##...##.##...##...#..#......",
                "#..##.#..#..#............#...#.",
                "..#.....#.........#........#.#.",
                "#.#...#...#......#.#......#....",
                ".##.....##.#.#....#.##...##.#..",
                ".##..##.#.#....#.##............",
                ".#.##.....##.#...#...###....#..",
                ".#..............#.#....###.###.",
                "....#..#...#.#.#..........#.#.#",
                ".#.#..#.#.#...###..#...##......",
                ".#.#.....###......#..........#.",
                "........#.##...............#.#.",
                "...#.#.#......#..#..##........#",
                "..#.##......#.......#..#......#",
                "...#...#...#...#..#..#........#",
                "..#....#.....#....#..##........",
                ".....#..#...##....#......##....",
                "...##..##..#..........##....#.#",
                "..#....#..#...#.##..#.....##...",
                "###...#.#....#........#.......#",
                "......#...#..#....###.........#",
                "..###.#...#...#...#.#..###.#...",
                ".##.#.......#.#..#..#......#.#.",
                "...##...........#.#..#.#..#....",
                ".......#.....####.#.....#...#.#",
                "......##......##.#.#.#...#.#..#",
                "..###.#####..#....#.#...#..##..",
                ".....#..#......#........#......",
                "#..##....#.#.##....#....#......",
                ".#....#.##.####.##..#..#......#",
                "#...##...#.#...##.#.##.##...#..",
                "........#.#........#.#...#..#..",
                ".#....###..#......#.##.###..#..",
                ".#..#..#..#..#...#.#.........##",
                "....#...#..#..............#....",
                "........#...##.....#.......#...",
                "..#......#.#..#.#..#.#.#...###.",
                "....#...####....###....#......#",
                "#...#.#...................#.##.",
                "..#.#.###...#....##....##......",
                "#..##..#.........#....#....####",
                ".#....###...#.#...#......#...#.",
                "......#..#.#..#.##...#.#.#..#..",
                ".#...#.#.....#..##......#..#...",
                "##.#..##.....##.#.#.......##...",
                ".##.##.##..#...#.#.##.##.......",
                ".#.#......#.....#...#.#..#.....",
                "...#...........#..#.##..##..#..",
                ".....#...##......#........#.#..",
                "....#..............##.........#",
                "..####.#....##..##......##.#.#.",
                ".#.#..#...#..........#...###..#",
                "....#.#.##.....###.#..#.##.....",
                ".......##.#.#..#...#...##.#....",
                "...#.##.....#....#...#...#.....",
                "##.#.##..#..#.#.....#.#..#.....",
                "..#..##........#....###..#..#..",
                "..#.........##.....#......#...#",
                "...##..........##......#.#.#...",
                "#.....#..#..#......#......#....",
                ".##...#..##....#.......##..#.#.",
                ".#...##...##......####.##.#....",
                ".....#.........#.#.####......#.",
                "...#.....#.#.........##..#.....",
                "##.#.###.#..#.#..#............#",
                "...##..#.#....#....#..#........",
                "..#.###......#...#.#.....#...#.",
                "....##.##..#.....#...#.#.#....#",
                ".......#.#..#...........#.#....",
                ".#.#..##.#.......#.#..#.....###",
                "...#.#.....#.#..#.##..#...#.#..",
                "...#......##....#..............",
                "......#...#....................",
                "..#........#...##.##.#..#.#.#..",
                ".#.###.#.##..##..#....##....#..",
                ".....#..#.#...#.#..#..#.......#",
                "..........#.##.#..##..####.....",
                "............#.#......#.........",
                ".#....#..#......#.....##.......",
                ".....#........#.....##.#..#.#..",
                "#..#.##...#.#.....#...#.####...",
                "......#...#....#.##..##.#...#..",
                ".#.#.##......##....#.#....#.##.",
                "#.#.#....#.###....##....##.....",
                ".##..#...#.##......#..#..#...##",
                "...#....###....#...........#.#.",
                "#.#.##.##...##....#....##.#...#",
                ".#.#######.......#......#......",
                "#......#...#.#.#.###....#.##..#",
                "......##..#..##.........##.#.##",
                "....##...#.#....##.....#.....#.",
                "..#.#........##........#.#..##.",
                ".....#..#.##.....#.....#..#.#..",
                ".#..............#.......#......",
                ".............#..#..........#...",
                ".#..#.##....##.#..#...##.......",
                "...........#..#.......#.#....#.",
                ".#..#..........##...#.#.#...#..",
                "......#....#..###....#......#..",
                ".#...#...##..#..#..##..#..#.#..",
                "#.#.........#....#..........##.",
                "...##..#..##...#....##...##.##.",
                "..#....#.####.........#.....##.",
                ".....#.#...#.#...#.##.#...##..#",
                "#...#.....#..#.......#...#..#..",
                "..#.......#..##.#.....#....#...",
                ".#.....#..##.#.....#...#.#...#.",
                ".....#.##..........##....#...#.",
                "...#....#...#........##...#...#",
                "....##...#....#..........#.....",
                "...#....##..#..####..##.#...#.#",
                "#...###.###..#....##.#.........",
                ".#.......#......#.........#....",
                "..#..##..#.........##..........",
                "#......#.#.##...#...#####......",
                "......#.....####......#....#...",
                ".........#..#..#...#....#.#....",
                "....#........#...##....#.......",
                "...##.#...#..........#....#....",
                "........#.......#.##..#..#...#.",
                "....#..##...........#.....#..#.",
                "#....#...............#.#....#..",
                ".#........#....#.#...#.......#.",
                "#.......##..........#.......#..",
                "...#....#...##.#..#.......#....",
                "#..#.##...#.#...#...#...#....#.",
                "###...#...#....#....#....#...#.",
                "##......#.#.......#....#..#....",
                "......#......#....#.#.#..###..#",
                ".#.#.##.....#..#..........#....",
                "##...#.#.#..##....#.....#.#....",
                "#.##...#...#.#...####..#.......",
                ".....##..#.#.#....#..##..#.#...",
                "....###.#.........##.....#.....",
                "......##...........#........#.#",
                ".#.........##..................",
                ".........##...#.............#.#",
                "......##...#...#.........#..##.",
                "#..#.......#..##.......###.....",
                "....#.#.....#............##....",
                ".....#..#......#....#.....##...",
                "##......##...................#.",
                "#....#............#.#.###.##...",
                ".#.....#........#.....#...#....",
                "......##.......######......##..",
                ".#....##....#..###....#.......#",
                "..............##.#..#.......#.#",
                ".#..#..........#..#.##.........",
                "......##.#..#......#.#....##.#.",
                "#.....#.##...#.....#...#..#...#",
                ".#....#..##.....#.....#.#.#....",
                "..#......#.##..#.........#.#.#.",
                ".#..##...#...#.....#..#..#.#..#",
                "#.#.##.##.................#.#.#",
                ".#..#.#..##.#.......#.......##.",
                "#...#...#..##...#...##...#...#.",
                "....#......#..#...#.....##..#..",
                "..............##......#...#.#..",
                "..##..#.......#..#..###.#.#....",
                ".#..#..#...#.......#...#...##.#",
                ".#...#.......###..#.##.###.....",
                "##.#...#......#.....#..#.......",
                "##....##............#.....#..#.",
                ".....#...##......##.....#....##",
                "#...##..#....#..##....###.#...#",
                ".....#..#.#.....#.##..##....#..",
                ".#.....#.#........#...#.#......",
                "......#....#.#........#.#......",
                ".##..#...............###...##.#",
                ".......###.#.#......###.....#..",
                ".......#..##...#....#.##..#.##.",
                "..#.......##.......#.....#....#",
                ".#......#....#..##..#.#.#..##..",
                "###......#...#..#.............#",
                ".#....#..#.#......##...........",
                ".#....#.##.....#..#.......#..##",
                "....#...#...#..#.....#..##..#.#",
                "#.#.#.......##.#..#.#....#.....",
                "##.#.......#...#...#.#......##.",
                "#....#.#...........#######.....",
                "...#.#.##.#......##..###.......",
                "..#.#....#..#.................#",
                "........#..##..#.....#....#.##.",
                "...#.#..#..#..#..............##",
                ".##.......###.#......#....#..##",
                "..##.##.#......#....#..#...#..#",
            };



            var slopes = new List<(int, int)> {
                (1, 1),
                (3, 1),
                (5, 1),
                (7, 1),
                (1, 2)
            };

            var result = 1d;
            foreach (var (right, down) in slopes)
            {
                var value = CalculateValues(entries, down, right);
                result = result * value;
            }
            Console.WriteLine(result);
        }

        private static double CalculateValues(string[] entries, int down, int right)
        {
            var currentPoint = right;
            var count = 0;
            var rowsCount = entries.Length;
            for (int item = down; item < rowsCount; item += down)
            {
                var currentRow = entries[item];
                if (currentPoint >= currentRow.Length)
                    currentPoint -= currentRow.Length;

                if (currentRow[currentPoint] == '#')
                    count++;

                currentPoint += right;
            }
            return count;
        }
    }
}
