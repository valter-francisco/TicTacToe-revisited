using System;
using System.Collections;
using System.Collections.Generic;

namespace TicTacToe_revisited
{
    public class Board
    {
        public int Line;
        public int Collumn;

        private string[,] board;// = new string[5, 5];

        public static void DrawBoard (string[,] board, int line, int collumn)
        {
            board = new string[5, 5];

            for (line = 0; line < 5; line++)
            {
                for (collumn = 0; collumn < 5; collumn++)
                {
                    if (line % 2 != 0)
                    {
                        board[line,collumn] = "---";
                    }
                    else if (collumn % 2 != 0)
                    {
                        board[line, collumn] = " | ";
                    }
                    Console.Write(board[line,collumn]);
                }
                Console.WriteLine();
            }
        }
    }
}
