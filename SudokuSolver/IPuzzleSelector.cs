using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public interface IPuzzleSelector
    {
        public string SelectPuzzle();
    }
}
