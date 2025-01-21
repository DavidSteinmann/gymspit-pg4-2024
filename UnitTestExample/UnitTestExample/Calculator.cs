using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class Calculator
    {
        public Calculator() { }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int v1, int v2)
        {
            int result = v1 * v2;
            return result;
        }
    }
}
