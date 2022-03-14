using System;
using System.Collections;
using System.Collections.Generic;

namespace TicTacToe_revisited
{
    public class Program
    {
        static void Main(string[] args)
        {


            Board board1 = new Board();

            board1.line = 1;
            board1.collumn = 1;

            board1.SetX(board1.board, board1.line, board1.collumn);
            board1.DrawBoard(board1.board);


        }
    }
}
