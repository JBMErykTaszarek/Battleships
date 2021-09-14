using Battleships.Enums;
using Battleships.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.GameActions
{
    public static class Shooting
    {
        public static Field RandomShot(Board board)
        {
            var avilableFields = board.Fields.Where(x => x.FieldStatus == FieldStatus.Empty).ToList();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var panelID = rand.Next(avilableFields.Count);
            return avilableFields[panelID];

        }

        public static Field AccurateShoot(Field field)
        {
            var fieldsToShot = Field.getNeighbors(field).Where(x => x.FieldStatus == FieldStatus.Empty).ToList() ;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            var panelID = rand.Next(fieldsToShot.Count);
            return fieldsToShot[panelID];
        }
    }
}
