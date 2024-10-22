namespace Lecture8;

internal class Program
{
    static void Main(string[] args)
    {
        var num1 = new NumberExpression(7);
        var num2 = new NumberExpression(16);
        var num3 = new NumberExpression(4);

        var add = new AdditionExpression(num1, num2);
        var divide = new DivisionExpression(add, num3);

        var result = new ExpressionBuilder(0)
            .Add(new AdditionExpression(num1, num2)).Subtract(2).Multiply(8).Calculate();

        Console.WriteLine($"result: {result}");
    }
}