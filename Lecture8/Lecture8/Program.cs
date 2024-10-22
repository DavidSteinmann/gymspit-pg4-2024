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

        IExpression resultExpression = new ExpressionBuilder(7)
            .Add(16).Divide(
                new ExpressionBuilder(8).Subtract(1).Build()
            ).Build();

        Console.WriteLine($"result: {resultExpression.Evaluate()}");


        // Iterator design pattern:

        var playlist = new Playlist(new List<Song>() { 
            new Song(2024, "Song1"),
            new Song(2023, "Song2"),
            new Song(1999, "Darude sandstorm"),
        });

        // Iterator design pattern allows us to easily get all
        // from a collection. We don't need to know the exact implementation
        foreach (var song in playlist)
        {
            Console.WriteLine(song.Name);
        }
    }
}