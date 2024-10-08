namespace Lecture6;

/*
    Problem Statement:
You are tasked with implementing a Factory Method Design Pattern to create
different types of Document objects. The factory method will allow you to
instantiate various types of documents (like InvoiceDocument, ReportDocument, etc.)
without specifying the exact class of object that will be created.

Classes to be Implemented:
Document (Abstract Class): This class will be the base class representing a generic document.
It will have a method called Display(), which will be implemented in the derived classes to
show the document's content.

Concrete Document Classes (InvoiceDocument, ReportDocument, etc.):
These classes will inherit from Document and implement the Display()
method with their own specific content.

DocumentFactory (Abstract Class):
This will be the base factory class that declares the factory method CreateDocument().
It will be the base for specific document factories.

Concrete Factories (InvoiceDocumentFactory, ReportDocumentFactory, etc.):
These classes will inherit from DocumentFactory and override the CreateDocument()
method to return a specific type of document object.
 */


internal class Program
{
    static void Main(string[] args)
    {

        CarBuilder carBuilder = new CarBuilder();
        carBuilder.WithName("My Skoda");
        carBuilder.WithDescription("skoda octavia 3 2017");
        carBuilder.WithId(1235);
        // I don't have to call all methods

        // Crete the final car
        Car car = carBuilder.Build();






        RenderDocument(new InvoiceDocumentFactory());

        RenderDocument(new ReportDocumentFactory());

        RenderDocument(new InvoiceDocumentFactory());
    }

    static void RenderDocument(IDocumentFactory factory)
    {
        IDocument document = factory.CreateDocument();

        Console.WriteLine("Rendering document:");
        Console.WriteLine();
        document.Display();
        Console.WriteLine();
        Console.WriteLine("Document rendering finished!");
        Console.WriteLine();
        Console.WriteLine();
    }
}