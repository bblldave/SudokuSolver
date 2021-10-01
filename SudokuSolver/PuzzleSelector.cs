using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuSolver
{
    public class PuzzleSelector : IPuzzleSelector
    {
        public IMessageProvider _messageService { get; set; }
        public PuzzleSelector(IMessageProvider messageService)
        {
            _messageService = messageService;
        }

        public string SelectPuzzle()
        {
            string filePath;
            int selectedPuzzle = 0;
            var selected = false;
            var error = false;
            while (!selected)
            {
                error = false;
                _messageService.printPuzzleSelect();
                var selection = Console.ReadLine();

                if (!int.TryParse(selection, out _))
                {
                    _messageService.printSelectionAlphaError();
                    error = true;
                }
                else if (int.Parse(selection) > 5)
                {
                    _messageService.printSelectionGreater();
                    error = true;
                }
                else if (int.Parse(selection) < 1)
                {
                    _messageService.printSelectionLess();
                    error = true;
                }

                if (error == false)
                {
                    selected = true;
                    selectedPuzzle = int.Parse(selection);
                }

                
            }

            if (selected)
            {
                filePath = $"./PuzzleFiles/puzzle{selectedPuzzle}.txt";
                return filePath;
            }
            else
            {
                throw new Exception("There was a problem finding the puzzle you selected. Closing solver!");
            }
        }
    }
}
