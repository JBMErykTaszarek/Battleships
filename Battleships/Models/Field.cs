using Battleships.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Models
{
    public class Field
    {

        public int XCord { get; set; }
        public int YCord { get; set; }
        public FieldStatus FieldStatus{ get; set; }

        public Field(int x, int y)
        {
            this.XCord = x;
            this.YCord = y;
            this.FieldStatus = FieldStatus.Empty;
        }

        public static List<Field> getNeighbors(Field field)
        {
            var neighbourList = new List<Field>();
            if (field.XCord > 1)
            {
                neighbourList.Add(new Field(field.XCord - 1, field.YCord));
            }
            if (field.XCord < 10)
            {
                neighbourList.Add(new Field(field.XCord + 1, field.YCord));
            }
            if (field.YCord > 1)
            {
                neighbourList.Add(new Field(field.XCord, field.YCord - 1));

            }
            if (field.YCord < 10)
            {
                neighbourList.Add(new Field(field.XCord, field.YCord + 1));

            }

            return neighbourList;
        }


    }
}
