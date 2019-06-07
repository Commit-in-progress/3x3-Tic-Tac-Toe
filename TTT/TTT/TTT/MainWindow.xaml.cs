using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TTT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int gamemod = 1;
        public static bool win = false;
        public static bool jatekoskezd = true;
        public static int playerpoint = 0, comppoint = 0;
        public static Char[,] table = new char[3, 3];

        public MainWindow()
        {
            InitializeComponent();
            jatekoskezd = true;
            nyertelLabel.Visibility = Visibility.Hidden;
            easybutton.IsEnabled = false;
            b1.Content = " ";
            b2.Content = " ";
            b3.Content = " ";
            b4.Content = " ";
            b5.Content = " ";
            b6.Content = " ";
            b7.Content = " ";
            b8.Content = " ";
            b9.Content = " ";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = ' ';
                }
            }
        }
        public void OneRound()
        {
            if (!win)
            {
                Functions functions = new Functions();
                if (functions.Draw(table))
                {
                    nyertelLabel.Content = "Döntetlen !";
                    nyertelLabel.Visibility = System.Windows.Visibility.Visible;
                }
                if (functions.PlayerWin(table))
                {
                    nyertelLabel.Content = "Nyertél !";
                    playerpoint++;
                    nyertelLabel.Visibility = System.Windows.Visibility.Visible;
                    Scoreboard.Content = "Játekos : Gép " + Environment.NewLine + playerpoint + " : " + comppoint;
                }
                if (!functions.Draw(table) && !functions.PlayerWin(table))
                {
                    if (gamemod == 1)
                    {
                        EasyComputerRound();
                    }
                    else
                    {
                        MidComputerRound();
                    }
                    if (functions.Draw(table))
                    {
                        nyertelLabel.Content = "Döntetlen !";
                        nyertelLabel.Visibility = System.Windows.Visibility.Visible;
                    }
                    if (functions.ComputerWin(table))
                    {
                        nyertelLabel.Content = "Vesztettél !";
                        nyertelLabel.Visibility = System.Windows.Visibility.Visible;
                        comppoint++;
                        Scoreboard.Content = "Játekos : Gép " + Environment.NewLine + playerpoint + " : " + comppoint;
                    }
                }
            }
        }
        public void MidComputerRound()
        {
            bool CanMove = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table[i, j] == ' ')
                    {
                        CanMove = true;
                    }
                }
            }
            bool PlacedO = false;
            Random rnum = new Random();
            int xcoord = 0, ycoord = 0;

            if (!PlacedO)
            {
                if (table[0, 0] == 'O' && table[0, 1] == 'O')
                {
                    if (b3.IsEnabled)
                    {
                        b3.Content = "O";
                        table[0, 2] = 'O';
                        b3.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 2] == 'O' && table[0, 1] == 'O')
                {
                    if (b1.IsEnabled)
                    {
                        b1.Content = "O";
                        table[0, 0] = 'O';
                        b1.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'O' && table[0, 2] == 'O')
                {
                    if (b2.IsEnabled)
                    {
                        b2.Content = "O";
                        table[0, 1] = 'O';
                        b2.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 0] == 'O' && table[1, 1] == 'O')
                {
                    if (b6.IsEnabled)
                    {
                        b6.Content = "O";
                        table[1, 2] = 'O';
                        b6.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 2] == 'O' && table[1, 1] == 'O')
                {
                    if (b4.IsEnabled)
                    {
                        b4.Content = "O";
                        table[1, 0] = 'O';
                        b4.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 0] == 'O' && table[1, 2] == 'O')
                {
                    if (b5.IsEnabled)
                    {
                        b5.Content = "O";
                        table[1, 1] = 'O';
                        b5.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[2, 0] == 'O' && table[2, 1] == 'O')
                {
                    if (b9.IsEnabled)
                    {
                        b9.Content = "O";
                        table[2, 2] = 'O';
                        b9.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[2, 1] == 'O' && table[2, 2] == 'O')
                {
                    if (b7.IsEnabled)
                    {
                        b7.Content = "O";
                        table[2, 0] = 'O';
                        b7.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[2, 0] == 'O' && table[2, 2] == 'O')
                {
                    if (b8.IsEnabled)
                    {
                        b8.Content = "O";
                        table[2, 1] = 'O';
                        b8.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'O' && table[1, 0] == 'O')
                {
                    if (b7.IsEnabled)
                    {
                        b7.Content = "O";
                        table[2, 0] = 'O';
                        b7.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'O' && table[2, 0] == 'O')
                {
                    if (b4.IsEnabled)
                    {
                        b4.Content = "O";
                        table[1, 0] = 'O';
                        b4.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 0] == 'O' && table[2, 0] == 'O')
                {
                    if (b1.IsEnabled)
                    {
                        b1.Content = "O";
                        table[0, 0] = 'O';
                        b1.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 1] == 'O' && table[1, 1] == 'O')
                {
                    if (b8.IsEnabled)
                    {
                        b8.Content = "O";
                        table[2, 1] = 'O';
                        b8.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 1] == 'O' && table[2, 1] == 'O')
                {
                    if (b5.IsEnabled)
                    {
                        b5.Content = "O";
                        table[1, 1] = 'O';
                        b5.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 1] == 'O' && table[2, 1] == 'O')
                {
                    if (b2.IsEnabled)
                    {
                        b2.Content = "O";
                        table[0, 1] = 'O';
                        b2.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 2] == 'O' && table[1, 2] == 'O')
                {
                    if (b9.IsEnabled)
                    {
                        b9.Content = "O";
                        table[2, 2] = 'O';
                        b9.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 2] == 'O' && table[2, 2] == 'O')
                {
                    if (b6.IsEnabled)
                    {
                        b6.Content = "O";
                        table[1, 2] = 'O';
                        b6.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 2] == 'O' && table[2, 2] == 'O')
                {
                    if (b3.IsEnabled)
                    {
                        b3.Content = "O";
                        table[0, 2] = 'O';
                        b3.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'O' && table[2, 2] == 'O')
                {
                    if (b5.IsEnabled)
                    {
                        b5.Content = "O";
                        table[1, 1] = 'O';
                        b5.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 2] == 'O' && table[2, 0] == 'O')
                {
                    if (b5.IsEnabled)
                    {
                        b5.Content = "O";
                        table[1, 1] = 'O';
                        b5.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 1] == 'X' && table[0, 2] == 'X' || table[1, 0] == 'X' && table[2, 0] == 'X')
                {
                    if (b1.IsEnabled)
                    {
                        b1.Content = "O";
                        table[0, 0] = 'O';
                        b1.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'X' && table[1, 1] == 'X')
                {
                    if (b9.IsEnabled)
                    {
                        b9.Content = "O";
                        table[2, 2] = 'O';
                        b9.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 2] == 'X' && table[1, 1] == 'X')
                {
                    if (b7.IsEnabled)
                    {
                        b7.Content = "O";
                        table[2, 0] = 'O';
                        b7.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[2, 2] == 'X' && table[1, 1] == 'X')
                {
                    if (b1.IsEnabled)
                    {
                        b1.Content = "O";
                        table[0, 0] = 'O';
                        b1.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[2, 0] == 'X' && table[1, 1] == 'X')
                {
                    if (b3.IsEnabled)
                    {
                        b3.Content = "O";
                        table[0, 2] = 'O';
                        b3.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 1] == 'X' && table[2, 1] == 'X' || table[1, 0] == 'X' && table[1, 2] == 'X')
                {
                    if (b5.IsEnabled)
                    {
                        b5.Content = "O";
                        table[1, 1] = 'O';
                        b5.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 1] == 'X' && table[2, 1] == 'X')
                {
                    if (b2.IsEnabled)
                    {
                        b2.Content = "O";
                        table[0, 1] = 'O';
                        b2.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'X' && table[0, 1] == 'X' || table[1, 2] == 'X' && table[2, 2] == 'X')
                {
                    if (b3.IsEnabled)
                    {
                        b3.Content = "O";
                        table[0, 2] = 'O';
                        b3.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 0] == 'X' && table[1, 1] == 'X')
                {
                    if (b6.IsEnabled)
                    {
                        b6.Content = "O";
                        table[1, 2] = 'O';
                        b6.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 2] == 'X' && table[1, 2] == 'X' || table[2, 1] == 'X' && table[2, 0] == 'X')
                {
                    if (b9.IsEnabled)
                    {
                        b9.Content = "O";
                        table[2, 2] = 'O';
                        b9.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 1] == 'X' && table[1, 1] == 'X')
                {
                    if (b8.IsEnabled)
                    {
                        b8.Content = "O";
                        table[2, 1] = 'O';
                        b8.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[0, 0] == 'X' && table[1, 0] == 'X' || table[2, 1] == 'X' && table[2, 2] == 'X')
                {
                    if (b7.IsEnabled)
                    {
                        b7.Content = "O";
                        table[2, 0] = 'O';
                        b7.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            if (!PlacedO)
            {
                if (table[1, 1] == 'X' && table[1, 2] == 'X')
                {
                    if (b4.IsEnabled)
                    {
                        b4.Content = "O";
                        table[1, 0] = 'O';
                        b4.IsEnabled = false;
                        PlacedO = true;
                    }
                }
            }
            bool placedo2 = false;
            if (CanMove && !PlacedO)
            {
                while (!placedo2 && !placedo2)
                {
                    xcoord = rnum.Next(0, 3);
                    ycoord = rnum.Next(0, 3);
                    if (table[ycoord, xcoord] == ' ')
                    {
                        table[ycoord, xcoord] = 'O';
                        placedo2 = true;
                    }
                }
            }
            if (placedo2)
            {
                if (ycoord == 0 && xcoord == 0)
                {

                    b1.Content = 'O';
                    b1.IsEnabled = false;
                }
                if (ycoord == 0 && xcoord == 1)
                {

                    b2.Content = 'O';
                    b2.IsEnabled = false;
                }
                if (ycoord == 0 && xcoord == 2)
                {

                    b3.Content = 'O';
                    b3.IsEnabled = false;
                }
                if (ycoord == 1 && xcoord == 0)
                {

                    b4.Content = 'O';
                    b4.IsEnabled = false;
                }
                if (ycoord == 1 && xcoord == 1)
                {

                    b5.Content = 'O';
                    b5.IsEnabled = false;
                }
                if (ycoord == 1 && xcoord == 2)
                {

                    b6.Content = 'O';
                    b6.IsEnabled = false;
                }
                if (ycoord == 2 && xcoord == 0)
                {

                    b7.Content = 'O';
                    b7.IsEnabled = false;
                }
                if (ycoord == 2 && xcoord == 1)
                {

                    b8.Content = 'O';
                    b8.IsEnabled = false;
                }
                if (ycoord == 2 && xcoord == 2)
                {

                    b9.Content = 'O';
                    b9.IsEnabled = false;
                }
            }
        }
        public void EasyComputerRound()
        {
            bool CanMove = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table[i, j] == ' ')
                    {
                        CanMove = true;
                    }
                }
            }

            bool PlacedO = false;
            Random rnum = new Random();
            int xcoord = 0, ycoord = 0;

            if (CanMove)
            {
                while (!PlacedO)
                {
                    xcoord = rnum.Next(0, 3);
                    ycoord = rnum.Next(0, 3);
                    if (table[ycoord, xcoord] == ' ')
                    {
                        table[ycoord, xcoord] = 'O';
                        PlacedO = true;
                    }
                }
            }
            if (ycoord == 0 && xcoord == 0)
            {
                b1.Content = 'O';
                b1.IsEnabled = false;
            }
            if (ycoord == 0 && xcoord == 1)
            {
                b2.Content = 'O';
                b2.IsEnabled = false;
            }
            if (ycoord == 0 && xcoord == 2)
            {
                b3.Content = 'O';
                b3.IsEnabled = false;
            }
            if (ycoord == 1 && xcoord == 0)
            {
                b4.Content = 'O';
                b4.IsEnabled = false;
            }
            if (ycoord == 1 && xcoord == 1)
            {
                b5.Content = 'O';
                b5.IsEnabled = false;
            }
            if (ycoord == 1 && xcoord == 2)
            {
                b6.Content = 'O';
                b6.IsEnabled = false;
            }
            if (ycoord == 2 && xcoord == 0)
            {
                b7.Content = 'O';
                b7.IsEnabled = false;
            }
            if (ycoord == 2 && xcoord == 1)
            {
                b8.Content = 'O';
                b8.IsEnabled = false;
            }
            if (ycoord == 2 && xcoord == 2)
            {
                b9.Content = 'O';
                b9.IsEnabled = false;
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e) //new game button
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    table[i, j] = ' ';
                }
            }
            win = false;
            nyertelLabel.Visibility = Visibility.Hidden;
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            b1.Content = " ";
            b2.Content = " ";
            b3.Content = " ";
            b4.Content = " ";
            b5.Content = " ";
            b6.Content = " ";
            b7.Content = " ";
            b8.Content = " ";
            b9.Content = " ";
            if (jatekoskezd)
            {
                jatekoskezd = false;
            }
            else
            {
                OneRound();
                jatekoskezd = true;
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = "X";
            table[0, 0] = 'X';
            b1.IsEnabled = false;
            OneRound();
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            b2.Content = "X";
            table[0, 1] = 'X';
            b2.IsEnabled = false;
            OneRound();
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {   
            b3.Content = "X";
            table[0, 2] = 'X';
            b3.IsEnabled = false;
            OneRound();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
            b4.Content = "X";
            table[1, 0] = 'X';
            b4.IsEnabled = false;
            OneRound();
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {   
            b5.Content = "X";
            table[1, 1] = 'X';
            b5.IsEnabled = false;
            OneRound();
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {   
            b6.Content = "X";
            table[1, 2] = 'X';
            b6.IsEnabled = false;
            OneRound();
        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {   
            b7.Content = "X";
            table[2, 0] = 'X';
            b7.IsEnabled = false;
            OneRound();
        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {   
            b8.Content = "X";
            table[2, 1] = 'X';
            b8.IsEnabled = false;
            OneRound();
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {   
            b9.Content="X";
            table[2, 2] = 'X';
            b9.IsEnabled = false;
            OneRound();
        }

        private void easybutton_Click(object sender, RoutedEventArgs e) //könnyű gomb
        {
            gamemod = 1;
            easybutton.IsEnabled = false;
            mediumbutton.IsEnabled = true;
        }

        private void mediumbutton_Click(object sender, RoutedEventArgs e) //közepes gomb
        {
            gamemod = 2;
            mediumbutton.IsEnabled = false;
            easybutton.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)   //kilépés gomb
        {
            Application.Current.Shutdown();
        }
    }
}
