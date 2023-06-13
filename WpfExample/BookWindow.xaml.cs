using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        List<Book> bookCollection;
        public string Username { get; set; }
        public void SetInfo()
        {
            tbInfo.Text = "Tervetuloa " + Username;
        }
        public BookWindow()
        {
            InitializeComponent();
            InitializeBooks();
        }

        private void InitializeBooks()
        {
            bookCollection = new List<Book>();
            bookCollection.Add(new Book("C#","Teppo Testi","12-34-56-77-x"));
            bookCollection.Add(new Book("C++", "Matti Virta", "22-34-56-77-x"));
            bookCollection.Add(new Book("Java", "Liisa Joki", "55-34-56-77-x"));
            bookCollection.Add(new Book("Python", "Teppo Testi", "88-34-56-77-x"));
        }

        private void btnShowBooks_Click(object sender, RoutedEventArgs e)
        {
            gridBooks.ItemsSource= bookCollection;
        }
    }
}
