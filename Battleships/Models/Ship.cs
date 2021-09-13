using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Models
{
    public class Ship
    {
        public int Size { get; set; }
        public int Hits { get; set; }
        public bool isDestroyed { get { return Hits == Size; }}

        public Ship(int size)
        {
            this.Size = size;
            this.Hits = 0;
        }

    }
}
