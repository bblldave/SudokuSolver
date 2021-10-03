using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public interface IPuzzleWriter
    {
        public void WritePuzzle(SudokuPuzzle puzzle, string filePath);
    }
}
