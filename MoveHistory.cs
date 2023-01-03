using System;
using System.Collections.Generic;


namespace final1
{
    public class MoveHistory
    {
        public List<Tuple<Player, int, int>> Moves { get; set; }

        public MoveHistory()
        {
            Moves = new List<Tuple<Player, int, int>>();
        }

        public void AddMove(Player player, int row, int col)
        {
            Moves.Add(new Tuple<Player, int, int>(player, row, col));
        }
    }
}