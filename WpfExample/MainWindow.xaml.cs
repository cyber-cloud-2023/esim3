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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textUsername.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username=textUsername.Text;
            string password=textPassword.Text;
            if(String.Compare(username,"admin")==0 && String.Compare(password, "1234") == 0)
            {
                BookWindow book = new BookWindow();
                book.Show();
                book.Username = username;
                book.SetInfo();
                this.Close();
            }
            else if (String.Compare(username, "teppo") == 0 && String.Compare(password, "testi") == 0)
            {
                BookWindow book = new BookWindow();
                book.Show();
                book.Username = username;
                book.SetInfo();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tunnus/salasana ei täsmää");
                textUsername.Clear();
                textPassword.Clear();  
            }

        }
    }
}
