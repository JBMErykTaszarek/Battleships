using Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.GameActions
{
    public static class BoardSetters
    {
        public static void PlaceShips(this Player player)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in player.Ships)
            {
                bool continueLoop = true;
                while (continueLoop)
                {
                    var startColumn = rand.Next(1, 11);
                    var startRow = rand.Next(1, 11);
                    var orientation = rand.Next(1, 3);


                    int endColumn = startColumn,
                        endRow = startRow;

                    if (orientation == 1)
                    {
                        for (int i = 1; i < ship.Size; i++)
                        {
                            endRow++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < ship.Size; i++)
                        {
                            endColumn++;
                        }
                    }

                    if (endRow > 10 || endColumn > 10)
                    {
                        continueLoop = true;
                        continue; 
                    }

                    var affectedFields = player.GameBoard.Range(player.GameBoard.Fields,startRow, startColumn, endRow, endColumn);

                    if (affectedFields.Any(x=>x.FieldStatus == Enums.FieldStatus.Battleship))
                    {
                        continueLoop = true;
                        continue;
                    }

                    foreach (var field in affectedFields)
                    {
                        field.FieldStatus = Enums.FieldStatus.Battleship;
                    }

                    continueLoop = false;

                }
            }
        }
    }
}
