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

namespace Calculator
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(txtVal1.Text);
            int b = int.Parse(txtVal2.Text);
            int c = a + b;
            txtResult.Text = c.ToString();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtVal1.Text = "";
            txtVal2.Text = "";
            txtResult.Text = "";
        }
    }
}
