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
                var cells = puzzle.getCells();
                for (int i = 0; i < cells.GetLength(0); i++)
                {

                    for (int j = 0; j < cells.GetLength(1); j++)
                    {

                        if (j == 8)
                        {
                            sw.WriteLineAsync(cells[i, j] + " ");
                        }
                        else
                        {
                            sw.WriteAsync(cells[i, j] + " ");
                        }
                    }
                }
            }
            
        }
    }
}
