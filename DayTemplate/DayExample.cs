using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC23.DayTemplate
{
    public class DayExample : DayTemplate
    {
        public DayExample(string fileName) : base(fileName) { }
        public override void Act()
        {
            Console.WriteLine(Lines.First());
        }
    }
}