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
        public LinkedList<int> MarkedUser0;
        public LinkedList<int> MarkedUser1;

        public int Turn { get; set; }
        public MainWindow()
        {
            MarkedUser0 = new LinkedList<int>();
            MarkedUser1 = new LinkedList<int>();
            Turn = 0;
            InitializeComponent();
            SetTurnInformation();

        }

        private void SetTurnInformation()
        {
            if (Turn == 0)
                label.Content = "User 1's (X) Turn";
            else
                label.Content = "User 2's (O) Turn";
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!button1.Content.Equals(""))
                return;

            if (Turn == 0)
            {
                button1.Content = "X";
                MarkedUser0.AddFirst(1);
            }
            else
            {
                button1.Content = "O";
                MarkedUser1.AddFirst(1);
            }

            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (!button2.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button2.Content = "X";
                MarkedUser0.AddFirst(2);

            }
            else
            {
                button2.Content = "O";
                MarkedUser1.AddFirst(2);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (!button3.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button3.Content = "X";
                MarkedUser0.AddFirst(3);

            }
            else
            {
                button3.Content = "O";
                MarkedUser1.AddFirst(3);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (!button4.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button4.Content = "X";
                MarkedUser0.AddFirst(4);

            }
            else
            {
                button4.Content = "O";
                MarkedUser1.AddFirst(4);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (!button5.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button5.Content = "X";
                MarkedUser0.AddFirst(5);

            }
            else
            {
                button5.Content = "O";
                MarkedUser1.AddFirst(5);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (!button6.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button6.Content = "X";
                MarkedUser0.AddFirst(6);

            }
            else
            {
                button6.Content = "O";
                MarkedUser1.AddFirst(6);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (!button7.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button7.Content = "X";
                MarkedUser0.AddFirst(7);

            }
            else
            {
                button7.Content = "O";
                MarkedUser1.AddFirst(7);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (!button8.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button8.Content = "X";
                MarkedUser0.AddFirst(8);

            }
            else
            {
                button8.Content = "O";
                MarkedUser1.AddFirst(8);

            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();

        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (!button9.Content.Equals(""))
                return;
            if (Turn == 0)
            {
                button9.Content = "X";
                MarkedUser0.AddFirst(9);

            }
            else
            {
                button9.Content = "O";
                MarkedUser1.AddFirst(9);
            }


            Turn = (Turn + 1) % 2;
            SetTurnInformation();
            CheckWin();
        }

        private void Reset()
        {
            MarkedUser0 = new LinkedList<int>();
            MarkedUser1 = new LinkedList<int>();
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            Turn = 0;
            label.Content = "";
            this.Title = "Tic Tac Toe";
        }

        private void CheckWin()
        {
            if ((MarkedUser0.Contains(1) && MarkedUser0.Contains(5) && MarkedUser0.Contains(9)) ||
               (MarkedUser0.Contains(3) && MarkedUser0.Contains(5) && MarkedUser0.Contains(7)) ||

               (MarkedUser0.Contains(1) && MarkedUser0.Contains(2) && MarkedUser0.Contains(3)) ||
               (MarkedUser0.Contains(4) && MarkedUser0.Contains(5) && MarkedUser0.Contains(6)) ||
               (MarkedUser0.Contains(7) && MarkedUser0.Contains(8) && MarkedUser0.Contains(9)) ||

               (MarkedUser0.Contains(1) && MarkedUser0.Contains(4) && MarkedUser0.Contains(7)) ||
               (MarkedUser0.Contains(2) && MarkedUser0.Contains(5) && MarkedUser0.Contains(8)) ||
               (MarkedUser0.Contains(3) && MarkedUser0.Contains(6) && MarkedUser0.Contains(9)))
            {
                this.Title = "Winner is User 1 (X)";
                this.label.Content = "Winner is User 1 (X)";
            }

            else if ((MarkedUser1.Contains(1) && MarkedUser1.Contains(5) && MarkedUser1.Contains(9)) ||
               (MarkedUser1.Contains(3) && MarkedUser1.Contains(5) && MarkedUser1.Contains(7)) ||

               (MarkedUser1.Contains(1) && MarkedUser1.Contains(2) && MarkedUser1.Contains(3)) ||
               (MarkedUser1.Contains(4) && MarkedUser1.Contains(5) && MarkedUser1.Contains(6)) ||
               (MarkedUser1.Contains(7) && MarkedUser1.Contains(8) && MarkedUser1.Contains(9)) ||

               (MarkedUser1.Contains(1) && MarkedUser1.Contains(4) && MarkedUser1.Contains(7)) ||
               (MarkedUser1.Contains(2) && MarkedUser1.Contains(5) && MarkedUser1.Contains(8)) ||
               (MarkedUser1.Contains(3) && MarkedUser1.Contains(6) && MarkedUser1.Contains(9)))
            {
                this.Title = "Winner is User 2 (O)";
                this.label.Content = "Winner is User 2 (O)";
            }

            else if (MarkedUser1.Count + MarkedUser0.Count == 9)
            {
                this.Title = "Game Draw.";
                this.label.Content = "Game Draw.";
            }
        }

        private void button_reset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }
    }




}
