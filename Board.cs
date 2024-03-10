using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_echecs
{
    internal class Board
    {
        private string[,] chess_board;

        public Board(string order)
        {
            this.chess_board = new string[8,8];
            if (order == "empty")
            {
                int counter = 0;
                this.chess_board = new string[8, 8];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (counter%2 == 0)
                        {
                            chess_board[i, j] = "black_empty";
                        }
                        else
                        {
                            chess_board[i, j] = "white_empty";
                        }
                        counter++;
                    }
                    counter++;
                }
            }
        }

        public string[,] Chess_board
        {
            get { return chess_board; }
            set { chess_board = value; }
        }

        public void Board_Update_Square(int x, int y)
        {
            chess_board[x, y] = chess_board[x, y].Substring(0, Math.Min(5, chess_board[x, y].Length)) + "_selec";
        }

    }

}
