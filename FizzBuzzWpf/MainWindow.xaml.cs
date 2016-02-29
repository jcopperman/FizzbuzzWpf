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

namespace FizzBuzzWpf
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

        private void btnFizz_Click(object sender, RoutedEventArgs e)
        {
            FizzbuzzCalculator fizzbuzz = new FizzbuzzCalculator();

            fizzbuzz.value = Convert.ToDouble(txtValue.Text);
            fizzbuzz.Fizzbuzz();

            lblOutput.Content = fizzbuzz.output.ToString();
            lblFizzBuzzAge.Content = fizzbuzz.age.ToString();

        }
    }
}
