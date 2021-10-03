using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageService = SetupMessageService();
            var puzzleFilePath = SelectPuzzle(messageService);
            var puzzle = SetupPuzzle(puzzleFilePath);
            PrintPuzzleToConsole(puzzle, messageService);
            SolvePuzzle(puzzle, messageService, puzzleFilePath);  
        }

        static string SelectPuzzle(IMessageProvider messageService)
        {
            PuzzleSelector selector = new PuzzleSelector(messageService);
            var puzzleFilePath = selector.SelectPuzzle();
            return puzzleFilePath;
        }

        static IMessageProvider SetupMessageService()
        {
            IMessageProvider messageService = new ConsoleMessageProvider();
            return messageService;
        }

        static SudokuPuzzle SetupPuzzle(string puzzleFilePath)
        {
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle(puzzleFilePath, puzzleReader);
            return puzzle;
        }

        static void PrintSolutionToFile(SudokuPuzzle puzzle, string puzzleFilePath)
        {
            IPuzzleWriter textWriter = new PuzzleTextWriter();
            var solutionFilePath = "../../../PuzzleSolutions/" + puzzleFilePath.Substring(14, 7) + ".sln.txt";
            textWriter.WritePuzzle(puzzle, solutionFilePath);
        }

        static void PrintPuzzleToConsole(SudokuPuzzle puzzle, IMessageProvider messageService)
        {
            messageService.printPuzzle(puzzle);
            messageService.PrintPuzzleGap();
        }

        static void SolvePuzzle(SudokuPuzzle puzzle, IMessageProvider messageService, string puzzleFilePath)
        {
            BacktrackSolver solver = new BacktrackSolver();

            if (solver.Solve(puzzle))
            {
                messageService.printPuzzle(puzzle);

                messageService.printExitMessage();
                PrintSolutionToFile(puzzle, puzzleFilePath);

                Console.ReadLine();
            }
            else
            {
                messageService.printUnsolveable();
                Console.ReadLine();
            }
        }
    }
}
