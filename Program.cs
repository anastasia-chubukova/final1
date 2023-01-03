using System;
using System.Collections.Generic;

namespace final1
{
    public enum CellState
    {
        Empty,
        X,
        O
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player 1 name:");
            string player1 = Console.ReadLine();
            Console.WriteLine("Enter player 2 name:");
            string player2 = Console.ReadLine();

            Game game = new Game(player1, player2);
            game.Play();
            while (true)
            {
                Console.WriteLine($"Enter 1 to see the history of moves:");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    foreach (var move in game.History.Moves)
                    {
                        Console.WriteLine($"{move.Item1.Name} made a move at ({move.Item2}, {move.Item3})");
                    }
                }
                else
                {
                    Console.WriteLine($"Thanks for game!");
                }
            }

        }
    }

}
