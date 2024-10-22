using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal class DivisionExpression : BinaryExpression
    {
        public DivisionExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Evaluate()
        {
            return left.Evaluate() / right.Evaluate();
        }
    }
}
