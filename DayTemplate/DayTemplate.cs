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
        public string FileName { get; set; }
        public DayTemplate(string fileName)
        {
            FileName = fileName;
        }
        public void Execute()
        {
            Lines = File.ReadLines(Path.Combine(Directory.GetCurrentDirectory(), "Input", FileName));
            Act();
        }
        public virtual void Act()
        {

        }
    }
}