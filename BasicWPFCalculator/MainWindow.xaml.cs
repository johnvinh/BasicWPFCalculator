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

namespace BasicWPFCalculator
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

        /// <summary>
        /// Determine whether the two numbers are valid.
        /// </summary>
        /// <returns>
        /// A tuple containing a boolean
        /// determining the numbers are valid, the first number, and the second number.
        /// </returns>
        private (bool, int, int) CheckNumberValidity()
        {
            int num1 = 0;
            int num2 = 0;
            // Make sure the first number is valid
            try
            {
                num1 = int.Parse(TxtNum1.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please ensure number 1 is a valid number.");
                return (false, 0, 0);
            }
            // Make sure the second number is valid
            try
            {
                num2 = int.Parse(TxtNum2.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Please ensure number 2 is a valid number.");
                return (false, 0, 0);
            }

            return (true, num1, num2);
        }
        
        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            (bool, int, int) result = CheckNumberValidity();
            // Both numbers are valid
            LblResult.Content = result.Item2 + result.Item3;
        }

        private void BtnMultiply_OnClick(object sender, RoutedEventArgs e)
        {
            (bool, int, int) result = CheckNumberValidity();
            // Both numbers are valid
            LblResult.Content = result.Item2 * result.Item3;
        }

        private void BtnSubtract_OnClick(object sender, RoutedEventArgs e)
        {
            (bool, int, int) result = CheckNumberValidity();
            LblResult.Content = result.Item2 - result.Item3;
        }

        private void BtnDivide_OnClick(object sender, RoutedEventArgs e)
        {
            (bool, int, int) result = CheckNumberValidity();
            LblResult.Content = (double) result.Item2 / result.Item3;
        }

        private void BtnPower_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}