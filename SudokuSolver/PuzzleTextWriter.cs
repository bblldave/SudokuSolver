using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SudokuSolver
{
    public class PuzzleTextWriter : IPuzzleWriter
    {
        public void WritePuzzle(SudokuPuzzle puzzle, string filePath)
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                for (int i = 0; i < puzzle.cells.GetLength(0); i++)
                {

                    for (int j = 0; j < puzzle.cells.GetLength(1); j++)
                    {

                        if (j == 8)
                        {
                            sw.WriteLineAsync(puzzle.cells[i, j] + " ");
                        }
                        else
                        {
                            sw.WriteAsync(puzzle.cells[i, j] + " ");
                        }
                    }
                }
            }
            
        }
    }
}
