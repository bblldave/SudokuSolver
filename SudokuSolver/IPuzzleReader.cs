using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public interface IPuzzleReader
    {
        char[,] readPuzzleFile(string filePath);
    }
}
