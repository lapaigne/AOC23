using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC23.DayTemplate
{
    public abstract class DayTemplate
    {
        public IEnumerable<string> Lines { get; set; }
        public void Execute(string filename)
        {
            Lines = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Input", filename));
            Act();
        }
        public virtual void Act()
        {

        }
    }
}