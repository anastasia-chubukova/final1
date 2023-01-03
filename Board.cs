using System;

namespace final1
{
    public class Board
    {
        public CellState[,] Cells { get; set; }

        
        public Board()
        {
            Cells = new CellState[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Cells[i, j] = CellState.Empty;
                }
            }
        }

        
        public bool MakeMove(int row, int col, CellState symbol)
        {
            
            if (Cells[row, col] != CellState.Empty)
            {
                return false;
            }

            Cells[row, col] = symbol;
            return true;
        }

        public bool IsFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Cells[i, j] == CellState.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool IsWin(CellState symbol)
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (Cells[i, 0] == symbol && Cells[i, 1] == symbol && Cells[i, 2] == symbol)
                {
                    return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (Cells[0, i] == symbol && Cells[1, i] == symbol && Cells[2, i] == symbol)
                {
                    return true;
                }
            }

            if (Cells[0, 0] == symbol && Cells[1, 1] == symbol && Cells[2, 2] == symbol)
            {
                return true;
            }
            if (Cells[2, 0] == symbol && Cells[1, 1] == symbol && Cells[0, 2] == symbol)
            {
                return true;
            }
            return false;
        }
    }
}