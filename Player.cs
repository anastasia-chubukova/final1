using System;

namespace final1
{
    public class Player
    {
        public string Name { get; set; }
        public CellState Symbol { get; set; }

        public Player(string name, CellState symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}
