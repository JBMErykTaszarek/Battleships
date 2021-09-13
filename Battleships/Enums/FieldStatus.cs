using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Battleships.Enums
{
    public enum FieldStatus
    {
        [Description("o")]
        Empty,

        [Description("B")]
        Battleship,

        [Description("D")]
        Destroyed,

        [Description("X")]
        Hit,

        [Description("M")]
        Miss
    }
}
