using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public interface IPuzzleSolver
    {
        public bool Solve(SudokuPuzzle puzzle);
        public int[] FindBlankCell(SudokuPuzzle puzzle);
        public bool IsValidNumber(SudokuPuzzle puzzle, int number, int[] position);
    }
}
