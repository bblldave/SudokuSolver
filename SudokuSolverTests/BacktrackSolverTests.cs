using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace SudokuSolverTests
{
    [TestClass]
    public class BacktrackSolverTests
    {
        [TestMethod]
        public void IsValidNumber_ShouldReturnTrue_WhenPosistionValid()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle1.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver(); 
            var number = 6;
            var position = new int[] { 0, 0 };

            //Act
            var result = solver.IsValidNumber(puzzle, number, position);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void IsValidNumber_ShouldReturnFaluse_WhenPosistionValid()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle1.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();
            var number = 1;
            var position = new int[] { 0, 0 };

            //Act
            var result = solver.IsValidNumber(puzzle, number, position);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void IsValidNumber_ShouldThrowException_WithInvalidPosition()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle1.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();
            var number = 1;
            var position = new int[] { 50, 50 };

            //Act and Assert
            Assert.ThrowsException<System.IndexOutOfRangeException>(() => solver.IsValidNumber(puzzle, number, position));

        }

        [TestMethod]
        public void FindBlankCell_ShouldReturnPosition_WhenFirstBlankCellFound()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle1.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();
            var firstBlankRow = 0;
            var firstBlankCol = 0;

            //Act
            var position = solver.FindBlankCell(puzzle);

            //Assert
            Assert.AreEqual(position[0], firstBlankRow);
            Assert.AreEqual(position[0], firstBlankCol);

        }

        [TestMethod]
        public void FindBlankCell_ShouldReturnNull_WhenNoBlankCellExists()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle6.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();

            //Act
            var result = solver.FindBlankCell(puzzle);

            //Assert
            Assert.IsNull(result);

        }

        [TestMethod]
        public void Solve_ShouldReturnTrue_WhenPuzzleIsSolved()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle1.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();

            //Act
            var result = solver.Solve(puzzle);

            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Solve_ShouldReturnFalse_WhenPuzzleIsUnsolveable()
        {
            //Arrange
            IPuzzleReader puzzleReader = new TxtPuzzleFile();
            SudokuPuzzle puzzle = new SudokuPuzzle("./PuzzleFiles/puzzle7.txt", puzzleReader);
            BacktrackSolver solver = new BacktrackSolver();

            //Act
            var result = solver.Solve(puzzle);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
