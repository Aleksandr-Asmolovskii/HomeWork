using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Полиморфизм
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Gladiolus flower1 = new Gladiolus();
            Tulip flower2 = new Tulip();
            Сarnation flower3 = new Сarnation();
            Rose flower4 = new Rose();
            Сarnation flower5 = new Сarnation();
            Console.WriteLine("Стоимость букета: {0} руб", Flower.TotalPrice);
            Console.ReadKey(); 
              
        }
    }
}
