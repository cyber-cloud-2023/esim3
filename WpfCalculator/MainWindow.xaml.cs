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

namespace WpfCalculator
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            int selection=0;
            if(radioSum.IsChecked == true)
            {
                selection = 1;
            }
            else if (radioDiscount.IsChecked==true) { 
                selection = 2;
            }
            else if (radioMultiply.IsChecked == true)
            {
                selection = 3;
            }
            else if (radioDivision.IsChecked == true)
            {
                selection = 4;
            }
            try
            {
                num1 = int.Parse(textNum1.Text);
                num2 = int.Parse(textNum2.Text);
                if(selection == 0)
                {
                    labelResult.Content = "Valitse ensin laskutoimitus";
                }
                else if(selection == 1)
                {
                    labelResult.Content = "Lukujen summa = " + (num1 + num2);
                }
                else if (selection == 2)
                {
                    labelResult.Content = "Lukujen erotus = " + (num1 - num2);
                }
                else if (selection == 3)
                {
                    labelResult.Content = "Lukujen tulo = " + (num1 * num2);
                }
                else if (selection == 4)
                {
                    if(num2 == 0)
                    {
                        MessageBox.Show("Nimittäjä ei voi olla nolla");
                        textNum2.Focus();
                    }
                    else
                    {
                    double division=(double)num1/(double)num2;
                    labelResult.Content = "Lukujen osamäärä = " + Math.Round(division,2);
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Anna kokonaisluvut");
            }

        }
    }
}
