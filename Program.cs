using AOC23.DayTemplate;
using AOC23.Days;

namespace AOC23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day2();
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
        static void Day2()
        {
            Day2 day = new Day2("Input2.txt");
            day.Execute();
        }
    }
}