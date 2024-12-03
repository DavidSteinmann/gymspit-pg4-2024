using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> Strings = new ObservableCollection<string>();
        //List<string> Strings = new List<string>();

        ObservableCollection<Book> books = new ObservableCollection<Book>();
        Book MyBook { get; set; } = new Book("CC", "DD", "EE");

        public MainWindow()
        {
            InitializeComponent();
            //TestList.DataContext = Strings;
            TestList.DataContext = books;
            TitleLabel.DataContext = MyBook;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //TitleLabel.Content = "Hello world!";
            Strings.Add("Hello world");
            books.Add(new Book("A", "B", "C"));
            MyBook.Title = "AAWDAWD";
        }
    }
}
