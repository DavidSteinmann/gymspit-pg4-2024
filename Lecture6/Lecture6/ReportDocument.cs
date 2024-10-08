namespace Lecture6;

public class ReportDocument : IDocument
{
    public void Display()
    {
        Console.WriteLine("Displaying report");
        Console.WriteLine("Year:        1234");
        Console.WriteLine("Budget:      4321");
    }
}
