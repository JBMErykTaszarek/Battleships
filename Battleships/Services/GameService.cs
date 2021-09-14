using Battleships.GameActions;
using Battleships.Models;
using Battleships.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Services
{
    public class GameService : IGameService
    {
        public List<Board> GetGame()
        {
            var player1 = new Player("p1");
            var player2 = new Player("p2");

            BoardSetters.PlaceShips(player1);
            BoardSetters.PlaceShips(player2);
            //algortyhm gry 
            //return historiagry
            var retList = new List<Board>();
            retList.Add(player1.GameBoard);
            retList.Add(player2.GameBoard);

            return retList;
        }

        public Field PlayRound(Player player)
        {
            var hitedFields = player.FiringBoard.Fields.Where(x => x.FieldStatus == Enums.FieldStatus.Hit).ToList();
            if (hitedFields.Count > 0)
            {
                Shooting.AccurateShoot(hitedFields.FirstOrDefault());
            }
            else
            {
                Shooting.RandomShot(player.FiringBoard);
            }

        }
    }
}
