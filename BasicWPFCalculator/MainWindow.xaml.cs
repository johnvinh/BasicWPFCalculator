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

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            // Make sure the first number is valid
            try
            {
                num1 = int.Parse(TxtNum1.Text);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please ensure number 1 is a valid number.");
                return;
            }
            // Make sure the second number is valid
            try
            {
                num2 = int.Parse(TxtNum2.Text);
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Please ensure number 2 is a valid number.");
                return;
            }
            // Both numbers are valid
            LblResult.Content = num1 + num2;
        }
    }
}