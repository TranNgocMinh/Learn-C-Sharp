// run and download Selection.exe
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Selection
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime first;
        private DateTime second;

        public MainWindow()
        {
            InitializeComponent();

            first = DateTime.Now;
            second = DateTime.Now;

            firstDate.Text = first.ToString("d MMMM yyyy");
            secondDate.Text = second.ToString("d MMMM yyyy");
        }

        private void firstDateAdjusterValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            first = DateTime.Now.AddDays(e.NewValue);
            firstDate.Text = first.ToString("d MMMM yyyy");
        }

        private void secondDateAdjusterValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            second = DateTime.Now.AddDays(e.NewValue);
            secondDate.Text = second.ToString("d MMMM yyyy");
        }

        private void compareClick(object sender, RoutedEventArgs e)
        {
            int diff = dateCompare(first, second);
            info.Text = "";
            show("firstDate == secondDate", diff == 0);
            show("firstDate != secondDate", diff != 0);
            show("firstDate <  secondDate", diff < 0);
            show("firstDate <= secondDate", diff <= 0);
            show("firstDate >  secondDate", diff > 0);
            show("firstDate >= secondDate", diff >= 0);
        }

        private void show(string exp, bool result)
        {
            info.Text += exp;
            info.Text += " : " + result.ToString();
            info.Text += "\n";
        }

        private int dateCompare(DateTime leftHandSide, DateTime rightHandSide)
        {
            int result;

            if (leftHandSide.Year < rightHandSide.Year)
            {
                result = -1;
            }
            else if (leftHandSide.Year > rightHandSide.Year)
            {
                result = 1;
            }
            else if (leftHandSide.Month < rightHandSide.Month)
            {
                result = -1;
            }
            else if (leftHandSide.Month > rightHandSide.Month)
            {
                result = 1;
            }
            else if (leftHandSide.Day < rightHandSide.Day)
            {
                result = -1;
            }
            else if (leftHandSide.Day > rightHandSide.Day)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }
    }
}
