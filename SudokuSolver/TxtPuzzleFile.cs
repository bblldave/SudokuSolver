using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudokuSolver
{
    public class TxtPuzzleFile : IPuzzleReader
    {

        public char[,] readPuzzleFile(string filePath)
        {
            char[,] cells = new char[9, 9];
            StreamReader reader = new StreamReader(filePath);

            for (int x = 0; x < 9; x++)
            {
                string row = reader.ReadLine();
                for (int y = 0; y < 9; y++)
                {
                    cells[x, y] = row[y];
                }
            }

            return cells;
        }
    }
}
