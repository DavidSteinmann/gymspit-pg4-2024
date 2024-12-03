using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Demo;

internal class Book : INotifyPropertyChanged
{
    private string title;

    public string Title
    {
        get => title;
        set {
            title = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
        }
    }

    public string Description { get; set; }
    public string Author { get; set; }

    public Book(string title, string description, string author)
    {
        Title = title;
        Description = description;
        Author = author;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public override string? ToString()
    {
        return $"{Title} {Description} {Author}";
    }
}
