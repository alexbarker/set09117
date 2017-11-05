﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkers
{
    public class Board
    {     
        public int[,] squares = new int[8, 8];
        Piece piece = new Piece();

        public Board()
        {
            squares = new int[,]{ { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 },
                                  { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 },
                                  { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 },
                                  { 0, 1, 0, 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1, 0, 1, 0 } };
        }

        public void DrawBoard()
        {
            Console.Clear();

            Console.WriteLine("                                                                                                                              ");
            Console.WriteLine("          ╔═════════════════════╗         ╔══════════════════════════════════════════════════╗         ╔═════════════════════╗");
            Console.WriteLine("          ║       LEGEND        ║         ║       ██████      ██████      ██████      ██████ ║         ║        SCORE        ║");
            Console.WriteLine("          ╚═════════════════════╝         ║       ██████      ██████      ██████      ██████ ║         ╚═════════════════════╝");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║                                ");
            Console.WriteLine("        (spacebar) - Pickup & Drop        ║ ██████      ██████      ██████      ██████       ║                PLAYER ONE      ");
            Console.WriteLine("        (u) - Undo Move                   ║ ██████      ██████      ██████      ██████       ║         ╔═════════════════════╗");
            Console.WriteLine("        (r) - Redo Move                   ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        (s) - Save to File                ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("        (i) - Instant Replay              ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("        (q) - Quit                        ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ╔═════════════════════╗         ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("          ║    INSTRUCTIONS     ║         ║       ██████      ██████      ██████      ██████ ║         ╚═════════════════════╝");
            Console.WriteLine("          ╚═════════════════════╝         ║       ██████      ██████      ██████      ██████ ║                                ");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║                PLAYER TWO      ");
            Console.WriteLine("        Use the Spacebar to pick up       ║ ██████      ██████      ██████      ██████       ║         ╔═════════════════════╗");
            Console.WriteLine("        and drop a piece.                 ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("        Navigate using the arrow keys.    ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║    <██> ║                     ║");
            Console.WriteLine("                                          ║       ██████      ██████      ██████      ██████ ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ║                     ║");
            Console.WriteLine("                                          ║ ██████      ██████      ██████      ██████       ║         ╚═════════════════════╝");
            Console.WriteLine("                                          ╚══════════════════════════════════════════════════╝                                ");
            Console.WriteLine("                                                                                                                              ");

            //-----------------------------------------------------------------------//

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(104, 5);
            Console.Write("██    PLAYER ONE");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(104, 16);
            Console.Write("██    PLAYER TWO");

            //-----------------------------------------------------------------------//

            for (int z = 0; z < 8; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (squares[z,y])
                    {
                        case 0:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z]-2), ((piece.piecePositionsY[y]-1)+x));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("██████");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
         return;
        }

        public void ReDrawBoard()
        {
            for (int z = 0; z < 8; z++)
            {
                for (int y = 0; y < 8; y++)
                {
                    switch (squares[z, y])
                    {
                        case 0:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z] - 2), ((piece.piecePositionsY[y] - 1) + x));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("██████");
                            }
                            break;
                        case 1:
                            for (int x = 0; x < 3; x++)
                            {
                                Console.SetCursorPosition((piece.piecePositionsX[z] - 2), ((piece.piecePositionsY[y] - 1) + x));
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("██████");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}

