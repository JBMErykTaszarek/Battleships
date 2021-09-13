using Battleships.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Models
{
    public class Board
    {
        public List<Field> Fields { get; set; }

        public Board()
        {
            Fields = new List<Field>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Fields.Add(new Field(i,j));
                }
            }
        }

        public List<Field> Range(List<Field> fields,
                                    int startRow,
                                    int startColumn,
                                    int endRow,
                                    int endColumn)
        {
            return fields.Where(x => x.YCord >= startRow
                                     && x.XCord >= startColumn
                                     && x.YCord <= endRow
                                     && x.XCord <= endColumn).ToList();
        }
    }
}
