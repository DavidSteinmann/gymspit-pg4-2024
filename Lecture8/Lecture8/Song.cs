using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal class Song
    {
        public int Year { get; set; }
        public string Name { get; set; }

        public Song(int year, string name)
        {
            Year = year;
            Name = name;
        }
    }
}
