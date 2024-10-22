using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal class NegationExpression : UnaryExpression
    {
        public NegationExpression(IExpression child) : base(child)
        {
        }

        public override double Evaluate()
        {
            return -child.Evaluate();
        }
    }
}
