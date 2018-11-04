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

namespace Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Operations operations = new Operations();
        string ops="";
        float number1=0;
        float number2=0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 1;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 1;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 2;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 2;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 3;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 3;
                resultBox.Text = number2.ToString();
            }
        }


        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 4;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 4;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 5;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 5;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 6;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 6;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 7;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 7;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 8;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 8;
                resultBox.Text = number2.ToString();
            }
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * 10 + 9;
                resultBox.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + 9;
                resultBox.Text = number2.ToString();
            }
        }

        //operations
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "+")
            {
                resultBox.Text.Insert(resultBox.Text.Last(), "+");
                number1 += number2;
            }
            else if (operation == "-")
                number1 -= number2;
            else if (operation == "*")
                number1 *= number2;
            else
            {
                if (number2 != 0)
                    number1 /= number2;
                else
                {
                    resultBox.Text = "Cannot divide by zero";
                    number1 = 0;
                }
            }
            number2 = 0;
            operation = "";
        }

    }

}
