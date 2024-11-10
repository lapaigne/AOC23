using AOC23.DayTemplate;
using AOC23.Days;

namespace AOC23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day1();
        }

        static void Example()
        {
            DayExample day = new DayExample("InputExample.txt");
            day.Execute();
        }
        static void Day1()
        {
            Day1 day = new Day1("Input1.txt");
            day.Execute();
        }
    }
}