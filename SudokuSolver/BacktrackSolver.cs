using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public class BacktrackSolver : IPuzzleSolver
    {

        public bool Solve(SudokuPuzzle puzzle)
        {
            var blankCell = FindBlankCell(puzzle);
            if (blankCell == null)
            {
                return true;
            }

            var row = blankCell[0];
            var col = blankCell[1];

            for (int i = 1; i < 10; i++)
            {
                if (IsValidNumber(puzzle, i, blankCell))
                {
 
                    puzzle.cells[row, col] = char.Parse(i.ToString());

                    //backtrack with recursion
                    if (Solve(puzzle))
                    {
                        return true;
                    }

                    puzzle.cells[row, col] = char.Parse("X");
                }
            }
            return false;
        }

        public int[] FindBlankCell(SudokuPuzzle puzzle)
        {
            for (int i = 0; i < puzzle.cells.GetLength(0); i++)
            {
                for (int j = 0; j < puzzle.cells.GetLength(1); j++)
                {
                    if (puzzle.cells[i,j].ToString() == "X")
                    {
                        var pos = new int[] { i, j }; //row,column
                        return pos;
                    }
                }
            }
            return null;
        }

        public bool IsValidNumber(SudokuPuzzle puzzle, int number, int[] position)
        {
            var row = position[0];
            var col = position[1];
            var startingRow = (row / 3) * 3;
            var startingCol = (col / 3) * 3;

            for (int i = 0; i < puzzle.cells.GetLength(0); ++i)
            {
                if (puzzle.cells[row, i].ToString() == number.ToString())
                {
                    return false;
                }
                if (puzzle.cells[i, col].ToString() == number.ToString())
                {
                    return false;
                }
                if (puzzle.cells[startingRow + (i % 3), startingCol + (i / 3)].ToString() == number.ToString())
                {
                    return false;
                }
            }
            return true;
        }

    }
}

