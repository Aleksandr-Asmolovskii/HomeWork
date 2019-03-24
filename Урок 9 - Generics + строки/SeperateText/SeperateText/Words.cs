using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateText
{
    class Words
    {
        string[] _words;

        List<NumberOfWords> _listOfwords = new List<NumberOfWords>();
        /// <summary>
        /// Делим строку на слова
        /// </summary>
        /// <param name="words"></param>
        public Words(string words)
        {
             _words = words.Split(new char[] { ' ',',','.','!','?',';',':','"','-' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < _words.Length; i++)
            {
                _words[i] = _words[i].ToLower();
            }
        }

        /// <summary>
        /// Считаем количество слов в строке
        /// </summary>
        public void CalculateSameWords()
        {
            NumberOfWords word = new NumberOfWords(1,_words[0]);
            _listOfwords.Add(word);
            for (int i = 1; i <_words.Length; i++)
            {
                bool same = false;
                foreach (var itemList in _listOfwords)
                {
                    if (_words[i] == itemList.Word)
                    {
                        itemList.Number++;
                        same = true;
                    }
                 }
                if (same == false)
                {
                    NumberOfWords word1 = new NumberOfWords(1, _words[i]);
                    _listOfwords.Add(word1);
                }
            }
           
               
            
        }

        /// <summary>
        /// Печать подсчета количества слов в формате: слово - количество
        /// </summary>
        public void PrintWords()
        {
            foreach (var item in _listOfwords)
            {
                Console.WriteLine(" {0} - {1}", item.Word,item.Number);
            }
        }
    }
}
