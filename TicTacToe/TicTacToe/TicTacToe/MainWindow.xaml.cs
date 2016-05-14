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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string User0 { get; set; }
        public string User1 { get; set; }

        public int Turn { get; set; }
        public MainWindow()
        {

            Turn = 0;            
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(Turn == 0)
            {
                button1.Content = "X";
            }
            else
            {
                button1.Content = "O";
            }


            Turn  = ( Turn + 1 ) % 2;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button2.Content = "X";
            }
            else
            {
                button2.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button3.Content = "X";
            }
            else
            {
                button3.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button4.Content = "X";
            }
            else
            {
                button4.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button5.Content = "X";
            }
            else
            {
                button5.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button6.Content = "X";
            }
            else
            {
                button6.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button7.Content = "X";
            }
            else
            {
                button7.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button8.Content = "X";
            }
            else
            {
                button8.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (Turn == 0)
            {
                button9.Content = "X";
            }
            else
            {
                button9.Content = "O";
            }


            Turn  = ( Turn + 1 )% 2;

        }
    }



    
}
