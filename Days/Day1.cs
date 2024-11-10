using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace AOC23.Days
{
    internal class Day1 : DayTemplate.DayTemplate
    {
        Dictionary<string, int> digitStrings = new()
        {
            { "one", 1},
            { "two", 2},
            { "three", 3},
            { "four", 4 },
            { "five", 5 }, 
            { "six", 6 }, 
            { "seven", 7 }, 
            { "eight", 8 },
            { "nine", 9 }
        };
            
        public Day1(string name) : base(name) { }
        public override void Act()
        {
            int sum = 0;

            foreach (var line in Lines)
            {
                List<int> digits = new List<int>();
                for (int i = 0; i < line.Length; i++)
                {
                    if (Char.IsDigit(line[i]))
                    {
                        digits.Add((int)Char.GetNumericValue(line[i]));
                    }
                    else
                    {   // part 2
                        foreach (KeyValuePair<string, int> pair in digitStrings)
                        {
                            if (line.IndexOf(pair.Key, i) == i)
                            {
                                digits.Add(pair.Value);
                                break;
                            }
                        }
                        // ---
                    }
                }
                sum += (digits.First() * 10 + digits.Last());
            }
            Console.WriteLine(sum);
        }
    }
}
