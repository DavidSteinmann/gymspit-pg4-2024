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

        public ExpressionBuilder Subtract(double num)
        {
            var exp = new NumberExpression(num);
            return Subtract(exp);
        }

        public ExpressionBuilder Subtract(IExpression exp)
        {
            expression = new SubtractionExpression(expression, exp);
            return this;
        }

        public ExpressionBuilder Multiply(double num)
        {
            var exp = new NumberExpression(num);
            return Multiply(exp);
        }

        public ExpressionBuilder Multiply(IExpression exp)
        {
            expression = new MultiplicationExpression(expression, exp);
            return this;
        }

        public ExpressionBuilder Divide(double num)
        {
            var exp = new NumberExpression(num);
            return Divide(exp);
        }

        public ExpressionBuilder Divide(IExpression exp)
        {
            expression = new DivisionExpression(expression, exp);
            return this;
        }

        public IExpression Build()
        {
            return expression;
        }
    }
}
