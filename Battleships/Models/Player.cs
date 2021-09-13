using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Board GameBoard { get; set; }
        public Board FiringBoard { get; set; }
        public List<Ship> Ships { get; set; }
        public bool HasLost
        {
            get
            {
                return Ships.All(x => x.isDestroyed);
            }
        }

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>();
            GameBoard = new Board();
            FiringBoard = new Board();

            for (int i = 1; i < 6; i++)
            {
                Ships.Add(new Ship(i));
            }
        }
    }
}
