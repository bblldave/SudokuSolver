using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudokuSolver
{
    public class SudokuPuzzle
    {
        private char[,] cells = new char[9, 9];
        private IPuzzleReader _reader { get; set; }

        public SudokuPuzzle(string filePath, IPuzzleReader reader)
        {
            _reader = reader;
            cells = _reader.readPuzzleFile(filePath);

        }

        public char[,] getCells()
        {
            return cells;
        }
    }
}
