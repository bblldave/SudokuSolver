using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageProvider messageService = new ConsoleMessageProvider();
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            PuzzleSelector selector = new PuzzleSelector(messageService);
            var puzzleFilePath = selector.SelectPuzzle();
            SudokuPuzzle puzzle = new SudokuPuzzle(puzzleFilePath, puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();
            messageService.printPuzzle(puzzle);
            Console.WriteLine("___________________");
            Console.WriteLine(" ");
            if (solver.Solve(puzzle))
            {
                messageService.printPuzzle(puzzle);
                messageService.printExitMessage();
            }
            else
            {
                Console.WriteLine("Puzzle unsolvable. Please check the puzzle for accuracy.");
            }
            
        }
    }
}
