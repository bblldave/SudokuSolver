using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public interface IMessageProvider
    {
        void printPuzzle(SudokuPuzzle puzzle);
        void printWelcomeMessage();

        void printExitMessage();

        void printPuzzleSelect();
        void printSelectionAlphaError();
        void printSelectionGreater();
        void printSelectionLess();
        void PrintPuzzleGap();

        void printUnsolveable();

    }
}
