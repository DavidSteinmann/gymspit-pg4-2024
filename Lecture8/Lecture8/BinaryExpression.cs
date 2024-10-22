using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    public abstract class BinaryExpression : IExpression
    {
        public IExpression left;
        public IExpression right;

        public BinaryExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public abstract double Evaluate();
    }
}
