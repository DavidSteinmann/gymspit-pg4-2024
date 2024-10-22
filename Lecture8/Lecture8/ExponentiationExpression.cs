using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal class ExponentiationExpression : BinaryExpression
    {
        public ExponentiationExpression(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Evaluate()
        {
            return Math.Pow(left.Evaluate(), right.Evaluate());
        }
    }
}
