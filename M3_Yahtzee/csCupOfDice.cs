using System;
using System.Collections.Generic;
using Helpers;

namespace M3_Yahtzee
{
    //Sprint 2
    /// <summary>
    /// Cup with 1 to 10 dice
    /// </summary>
    class csCupOfDice : ICupOfDice
    {
        csSeedGenerator _rnd = new csSeedGenerator();
        protected List<enDiceFace> _dices;

        public int Count => _dices.Count;
        public enDiceFace this[int idx] => _dices[idx];

        public enDiceFace Highest
        {
            get
            {
                Sort();
                return this[Count - 1];
            }
        }
        public enDiceFace Lowest
        {
            get
            {
                Sort();
                return this[0];
            }
        }

        public ICupOfDice Sort()
        {
            _dices.Sort();
            return this;
        }
        public ICupOfDice Shake()
        {
            for (int i = 0; i < _dices.Count; i++)
            {
                _dices[i] = _rnd.FromEnum<enDiceFace>();
            }
            return this;
        }

        public override string ToString()
        {
            string sRet = $"";
            for (int i = 0; i < Count; i++)
            {
                sRet += $"{this[i],8},";
                if ((i + 1) % 10 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public csCupOfDice(int nrOfDices)
        {
            if (nrOfDices < 1 || nrOfDices > 10)
                throw new IndexOutOfRangeException("Wrong number of Dices");

            _dices = new List<enDiceFace>();
            for (int i = 0; i < nrOfDices; i++)
            {
                _dices.Add(_rnd.FromEnum<enDiceFace>());
            }
        }
    }
}
