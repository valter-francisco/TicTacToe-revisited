using System;
using System.Collections;
using System.Collections.Generic;

namespace TicTacToe_revisited
{
    public class Board
    {
        public int line { get; set; }
        public int collumn { get; set; }

        public string[,] board = new string[3, 3]
        {
            {" "," "," "},
            {" "," "," "},
            {" "," "," "},
        };

        public void SetX(string[,] board, int line, int collumn)
        {
            board[line, collumn] = "X";
        }

        public void SetO(string[,] board, int line, int collumn)
        {
            board[line, collumn] = "O";
        }

        public void DrawBoard (string[,] board)
        {
            Console.WriteLine("    C o l u m n s");
            Console.WriteLine("    | 1 | 2 | 3 ");
            Console.WriteLine("  ---------------");
            Console.WriteLine("L 1 | {0} | {1} | {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("i ---------------");
            Console.WriteLine("n 2 | {0} | {1} | {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("e ---------------");
            Console.WriteLine("s 3 | {0} | {1} | {2}", board[2, 0], board[2, 1], board[2, 2]);
        }
    }
}
