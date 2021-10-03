using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageProvider messageService = new ConsoleMessageProvider();
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            IPuzzleWriter textWriter = new PuzzleTextWriter();
            PuzzleSelector selector = new PuzzleSelector(messageService);
            var puzzleFilePath = selector.SelectPuzzle();
            var solutionFilePath = "../../../PuzzleSolutions/" + puzzleFilePath.Substring(14, 7) + ".sln.txt";
            SudokuPuzzle puzzle = new SudokuPuzzle(puzzleFilePath, puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();
            messageService.printPuzzle(puzzle);
            Console.WriteLine("___________________");
            Console.WriteLine(" ");
            if (solver.Solve(puzzle))
            {
                messageService.printPuzzle(puzzle);

                messageService.printExitMessage();
                textWriter.WritePuzzle(puzzle, solutionFilePath);
            }
            else
            {
                Console.WriteLine("Puzzle unsolvable. Please check the puzzle for accuracy.");
            }
            
        }
    }
}
