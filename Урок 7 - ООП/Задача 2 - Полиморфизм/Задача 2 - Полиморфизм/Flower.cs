using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Полиморфизм
{
   abstract class Flower
    {
        string _color;
        int _price;
        static int _totalPrice;


        public string Color { get { return _color; } set { _color = value; }  }
        public int Price { get { return _price; } set { _price = value; } }
        public static int TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }

        public Flower(string color, int price)
        {
            Color = color;
            Price = price;
            TotalPrice = TotalPrice + Price;
        }

    }
}
