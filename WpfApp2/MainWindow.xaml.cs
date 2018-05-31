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

namespace WpfApp2
{
   
    public partial class MainWindow
    {
        Double ResultValue = 0.0;
        char OperationPreformed;
        int i, i2;

        private void Enter_9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "9";
        }

        private void Enter_8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "8";
        }

        private void Enter_7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "7";
        }

        private void Enter_6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "6";
        }

        private void Enter_5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "5";
        }

        private void Enter_4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "4";
        }

        private void Enter_3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "3";
        }

        private void Enter_2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "2";
        }

        private void Enter_1_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "1";
        }

        private void Enter_0_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }

            TextBox_Result.Text = TextBox_Result.Text + "0";
        }

        private void Enter_Add_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }
            i = Int32.Parse(TextBox_Result.Text);
            OperationPreformed = 'A';
            TextBox_Result.Text = "";
        }

        private void Enter_C_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Result.Text = "0";
        }

        private void Enter_Minus_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }
            i = Int32.Parse(TextBox_Result.Text);
            OperationPreformed = 'M';
            TextBox_Result.Text = "";
        }

        private void Enter_Multiple_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }
            i = Int32.Parse(TextBox_Result.Text);
            OperationPreformed = 'T';
            TextBox_Result.Text = "";
        }

        private void Enter_Divide_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }
            i = Int32.Parse(TextBox_Result.Text);
            OperationPreformed = 'D';
            TextBox_Result.Text = "";
        }

        private void Enter_Equals_Click(object sender, RoutedEventArgs e)
        {
            i2 = Int32.Parse(TextBox_Result.Text);
            switch (OperationPreformed)
            {
                case 'A':
                    ResultValue = i + i2;
                    TextBox_Result.Text = Convert.ToString(ResultValue);
                    break;
                case 'M':
                    ResultValue = i - i2;
                    TextBox_Result.Text = Convert.ToString(ResultValue);
                    break;
                case 'T':
                    ResultValue = i * i2;
                    TextBox_Result.Text = Convert.ToString(ResultValue);
                    break;
                case 'D':
                    ResultValue = i / i2;
                    TextBox_Result.Text = Convert.ToString(ResultValue);
                    break;
                case 'N':
                    ResultValue = i / i2;
                    TextBox_Result.Text = Convert.ToString(ResultValue);
                    break;
            }
        }

        private void Enter_Decimel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Enter_History_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_Result.Text == "0")
            {
                TextBox_Result.Clear();
            }
            i = Int32.Parse(TextBox_Result.Text);
            OperationPreformed = 'N';
            TextBox_Result.Text = "";
        }

        private void Enter_CE_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Result.Text = "0";
            ResultValue = 0.0;
        }

    }
}
