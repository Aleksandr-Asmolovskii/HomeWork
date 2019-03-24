using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeperateText
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Мама мыла раму, раму мыла мама";
            Words word = new Words(str);
            word.CalculateSameWords();
            word.PrintWords();
            Console.ReadKey();
        }
    }
}
