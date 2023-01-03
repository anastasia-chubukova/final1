using System;

namespace final1
{

    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Board Board { get; set; }
        public MoveHistory History { get; set; }

        public Game(string player1, string player2)
        {
            Player1 = new Player(player1, CellState.X);
            Player2 = new Player(player2, CellState.O);
            Board = new Board();
            History = new MoveHistory();
        }

        
        public void Play()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            Player currentPlayer = Player1;
            while (true)
            {
                
                Console.WriteLine("Current board:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(Board.Cells[i, j] == CellState.Empty ? "-" : Board.Cells[i, j].ToString());
                    }
                    Console.WriteLine();
                }

                
                Console.WriteLine($"{currentPlayer.Name}, enter your move (row column):");
                int row = int.Parse(Console.ReadLine());
                int col = int.Parse(Console.ReadLine());

                bool isValidMove = Board.MakeMove(row, col, currentPlayer.Symbol);
                if (isValidMove)
                {
                    History.AddMove(currentPlayer, row, col);
                }
                else
                {
                    Console.WriteLine("Invalid move, try again.");
                    continue;
                }

                if (Board.IsWin(currentPlayer.Symbol))
                {
                    Console.WriteLine($"{currentPlayer.Name} wins!");
                    break;
                }

                if (Board.IsFull())
                {
                    Console.WriteLine("The game is a draw.");
                    break;
                }

                currentPlayer = currentPlayer == Player1 ? Player2 : Player1;
            }
        }
    }
}
