using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public class ConsoleMessageProvider : IMessageProvider
    {
        public void printExitMessage()
        {
            Console.WriteLine("Puzzle solved.");
        }

        public void printPuzzle(SudokuPuzzle puzzle)
        {
            for (int i = 0; i < puzzle.cells.GetLength(0); i++)
            {
                if (i % 3 == 0 && i !=0)
                {
                    Console.WriteLine("----------------------");
                }

                for (int j = 0; j < puzzle.cells.GetLength(1); j++)
                {
                    if (j %3 == 0 && j != 0)
                    {
                        Console.Write("| ");
                    }

                    if (j == 8)
                    {
                        Console.WriteLine(puzzle.cells[i,j] + " ");
                    }
                    else
                    {
                        Console.Write(puzzle.cells[i, j] + " ");
                    }
                }
            }
        }

        public void printPuzzleSelect()
        {
            Console.WriteLine("There are currently 5 puzzles to choose from. Please press 1 - 5 to select the puzzle you wish to use.");
        }

        public void printSelectionAlphaError()
        {
            Console.WriteLine("You did not select a number. Please try again.");
        }

        public void printSelectionGreater()
        {
            Console.WriteLine("Your selection was higher than 5. Please try again.");
        }

        public void printSelectionLess()
        {
            Console.WriteLine("Your selection was less than 1. Please try again.");
        }

        public void printWelcomeMessage()
        {
            Console.WriteLine("Welcome to Sudoku BacktrackSolver.");
        }
    }
}
