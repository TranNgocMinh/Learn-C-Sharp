// download and run DoStatement.exe file
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

namespace DoStatement
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

        private void showStepsClick(object sender, RoutedEventArgs e)
        {
            int amount = int.Parse(number.Text);
            steps.Text = "";
            string current = "";

            do
            {
                int nextDigit = amount % 8;
                amount /= 8;
                int digitCode = '0' + nextDigit;
                char digit = Convert.ToChar(digitCode);
                current = digit + current;
                steps.Text += current + "\n";
            }
            while (amount != 0);
        }
    }
}
