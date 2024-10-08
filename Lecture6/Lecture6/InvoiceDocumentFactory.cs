namespace Lecture6;

public class InvoiceDocumentFactory : IDocumentFactory
{
    public IDocument CreateDocument()
    {
        return new InvoiceDocument();
    }
}
