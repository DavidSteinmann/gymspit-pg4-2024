using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    internal abstract class UnaryExpression : IExpression
    {
        public IExpression child;

        public UnaryExpression(IExpression child)
        {
            this.child = child;
        }

        public abstract double Evaluate();
    }
}
