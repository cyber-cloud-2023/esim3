using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfBookClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static async Task<string> GetBookFromApi()
        {
            var response = string.Empty;
            var url = Environment.GetUrl() + "/book";
            var client = new HttpClient();
            
            HttpResponseMessage result = await client.GetAsync(url);
            response = await result.Content.ReadAsStringAsync();
            return response;
        }
        private void btnShowBooks_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var data = Task.Run(() => GetBookFromApi());
                data.Wait();
                Console.WriteLine(data.Result);
                if (data.Result.Length > 3) //Result is not []
                {
                    dynamic books = JsonConvert.DeserializeObject(data.Result);

                    gridBooks.ItemsSource = books;//writes the data to DataGrid
                }
                else
                {
                    MessageBox.Show("There is no books");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Virhe yhteydessä");
            }

            }
    }
}
