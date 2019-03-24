using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateText
{
    class NumberOfWords
    {
        int _number;
        string _word;

        public string Word { get { return _word; } set { _word = value; } }
        public int Number { get { return _number; } set { _number = value; } }

        public NumberOfWords(int number, string word )
        {
            Word = word;
            Number = number;
        }

    }
}
