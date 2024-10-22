using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lecture8
{
    public class ExpressionBuilder
    {
        private IExpression expression;

        public ExpressionBuilder(double num)
        {
            expression = new NumberExpression(num);
        }


        public ExpressionBuilder Add(double num)
        {
            var exp = new NumberExpression(num);
            return Add(exp);
        }

        public ExpressionBuilder Add(IExpression exp)
        {
            var newResult = new AdditionExpression(expression, exp);
            expression = newResult;

            return this;
        }

        public ExpressionBuilder Subtract(IExpression exp)
        {
            expression = new SubtractionExpression(expression, exp);
            return this;
        }

        public ExpressionBuilder Multiply(IExpression exp)
        {
            expression = new MultiplicationExpression(expression, exp);
            return this;
        }

        public double Calculate()
        {
            return expression.Evaluate();
        }
    }
}
