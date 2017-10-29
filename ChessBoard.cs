﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_Assign_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowSize = 8;
            int colSize = 8;
            var board = "";

            for (int row = 0; row < rowSize; row++)
            {
                for (int col = 0; col < colSize; col++)
                {
                    if ((row + col) % 2 == 0)
                    {
                        board += " X ";
                    }
                    else
                    {
                        board += " # ";
                    }
                }
                board += "\n";
            }

            // Skriva ut Chess board
            Console.WriteLine(board + "\n");
        }
    }
}