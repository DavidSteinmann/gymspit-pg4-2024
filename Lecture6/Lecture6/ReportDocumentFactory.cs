namespace Lecture6;

public class ReportDocumentFactory : IDocumentFactory
{
    public IDocument CreateDocument()
    {
        return new ReportDocument();
    }
}
