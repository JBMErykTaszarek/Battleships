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

        
    }
}
