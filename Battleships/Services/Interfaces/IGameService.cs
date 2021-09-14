using Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services.Interfaces
{
    public interface IGameService
    {
        public List<Board> GetGame();
        public Field PlayRound(Player player);
    }
}
