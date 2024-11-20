using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace AOC23.Days
{
    class Game
    {
        int Red;
        int Green;
        int Blue;
        public Game() { }
        public Game(int[] cubes) 
        {
            Red = cubes[0];
            Green = cubes[1];
            Blue = cubes[2];
        }
        public Game(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
    internal class Day2 : DayTemplate.DayTemplate
    {
        public Day2(string name) : base(name) { }
        public override void Act()
        {
            //Part1();
            Part2();
        }

        void Part1()
        {
            Dictionary<string, int> target = new Dictionary<string, int>()
            {
                { "red", 12 },
                { "green", 13 },
                { "blue", 14 },
            };

            int failedIdSum = 0;
            var lines = Lines.Select(x => x.Split(":")[1]).ToArray();
            for (int i = 0; i < lines.Length; i++)
            {
                int tempSum = lines[i].Split(';', ',').Select(x =>
                {
                    string[] str = x.Split(" ");
                    return (Convert.ToInt32(str[1]) > target[str[2]]) ? 1 : 0;
                }).Sum();

                failedIdSum += (tempSum > 0) ? (i + 1) : 0;
            }
            Console.WriteLine(5050 - failedIdSum);
        }

        void Part2()
        {
            int sum = 0;
            var lines = Lines.Select(x => x.Split(":")[1]).ToArray();
            for (int i = 0; i < lines.Length; i++)
            {
                Dictionary<string, int> target = new Dictionary<string, int>()
                {
                    { "red", 1 },
                    { "green", 1 },
                    { "blue", 1 },
                };

                var temp = lines[i].Split(';', ',');

                foreach (var x in temp)
                {
                    string[] str = x.Split(" ");
                    target[str[2]] = Math.Max(Convert.ToInt32(str[1]), target[str[2]]);   
                }

                sum += (target["red"] * target["green"] * target["blue"]);
            }
            Console.WriteLine(sum);
        }
    }
}
