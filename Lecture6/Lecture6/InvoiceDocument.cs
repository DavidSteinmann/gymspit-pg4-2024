namespace Lecture6;

public class InvoiceDocument : IDocument
{
    public void Display()
    {
        Console.WriteLine("Displaying invoice");
        Console.WriteLine("Customer:    JohnDoe");
        Console.WriteLine("Price:       6543");
    }
}
