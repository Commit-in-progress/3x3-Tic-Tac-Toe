using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT
{
    class Functions
    {
        public bool PlayerWin(char[,] table)
        {
            if (table[0, 0] == 'X' && table[0, 1] == 'X' && table[0, 2] == 'X')
            {
                return true;
            }
            else if (table[1, 0] == 'X' && table[1, 1] == 'X' && table[1, 2] == 'X')
            {
                return true;
            }
            else if (table[2, 0] == 'X' && table[2, 1] == 'X' && table[2, 2] == 'X')
            {
                return true;
            }
            else if (table[0, 0] == 'X' && table[1, 0] == 'X' && table[2, 0] == 'X')
            {
                return true;
            }
            else if (table[0, 1] == 'X' && table[1, 1] == 'X' && table[2, 1] == 'X')
            {
                return true;
            }
            else if (table[0, 2] == 'X' && table[1, 2] == 'X' && table[2, 2] == 'X')
            {
                return true;
            }
            else if (table[0, 0] == 'X' && table[1, 1] == 'X' && table[2, 2] == 'X')
            {
                return true;
            }
            else if (table[0, 2] == 'X' && table[1, 1] == 'X' && table[2, 0] == 'X')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Draw(char[,] table)
        {
            bool itsdraw = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (table[i, j] == ' ')
                    {
                        itsdraw = false;
                        break;
                    }
                }
                if (!itsdraw)
                {
                    break;
                }
            }
            return itsdraw;
        }

        public bool ComputerWin(char[,] table)
        {
            if (table[0, 0] == 'O' && table[0, 1] == 'O' && table[0, 2] == 'O')
            {
                return true;
            }
            else if (table[1, 0] == 'O' && table[1, 1] == 'O' && table[1, 2] == 'O')
            {
                return true;
            }
            else if (table[2, 0] == 'O' && table[2, 1] == 'O' && table[2, 2] == 'O')
            {
                return true;
            }
            else if (table[0, 0] == 'O' && table[1, 0] == 'O' && table[2, 0] == 'O')
            {
                return true;
            }
            else if (table[0, 1] == 'O' && table[1, 1] == 'O' && table[2, 1] == 'O')
            {
                return true;
            }
            else if (table[0, 2] == 'O' && table[1, 2] == 'O' && table[2, 2] == 'O')
            {
                return true;
            }
            else if (table[0, 0] == 'O' && table[1, 1] == 'O' && table[2, 2] == 'O')
            {
                return true;
            }
            else if (table[0, 2] == 'O' && table[1, 1] == 'O' && table[2, 0] == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
