# SudokuSolver
A simple SudokuSolver made as a Console Application. The application uses a backtracking algorithm to solve any sudoku puzzle in an efficient manner.  

## Puzzle files
There are 5 puzzles that are included with this application. Puzzles need to be in a text format and use an "X" to indicate a blank cell. These are currently stored in the PuzzleFiles directory.

## Puzzle Solutions
When the program is ran against a selected puzzle, it will solve the puzzle. The solution will be displayed in the console window as well as written to a text file. These solutions are stored in the PuzzleSolutions directory.

## Execution
This solution was written to solve 1 puzzle at a time. It can easily be updated to allow a user to keep selecting puzzles or even type a file path instead of using the provided puzzles.


## Technical aspects
1. ### Interfaces
* IMessageProvider is an interface for writing messages. Currently this is used in the ConsoleMessageProvider class to print standard messages to the console.
* IPuzzleReader is an interface for reading in a puzzle file. Currently this is implemented in the TxtPuzzleFile class to read in a text file. Other classes could implement this to allow for reading from different files like .csv or excel if required.
* IPuzzleSelector is an interface for prompting the user to select a puzzle and actually selcting the correct file location. This is currently implemented in the PuzzleSelector class but could be implemented in other classes if the user interface needs changed.
* IPuzzleSolver is an interface for solving a puzzle. This is currently implemented in the BacktrackSolver class but could be implemented in other classes if different algorithms were desired.
* IPuzzleWriter is an interface for writing out the solutions. This is currently implemented in the PuzzleTextWriter class but could be implemented in other classes if the output is needed in different formats.

2. ### Classes
* SudokuPuzzle - Represents a puzzle with a 9X9 grid
* TxtPuzzleFile - Used to read in a text file puzzle
* PuzzleSelector - Used to prompt the user to select a puzzle in the command line and gets the correct puzzle file path
* PuzzleTextWriter - Used to write the solution of the puzzle to the output file
* BacktrackSolver - Uses a backtrack algorithm to solve a puzzle
* ConsoleMessageProvider - Used to print standard messages to the console

3. ### Tests
* BacktrackSolverTests - This is a series of unit tests for the backtracking algorithm to validate that everything is working correctly.
* Unit tests have only been implemented for the BacktrackSolver class at this time.
