using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Yahtzee
{
    class csCupDoubleDice : csCupOfDice, ICupDoubleDice
    {
        public bool IsPair => this[0] == this[1];
        public csCupDoubleDice() : base(2) { }
    }
}
