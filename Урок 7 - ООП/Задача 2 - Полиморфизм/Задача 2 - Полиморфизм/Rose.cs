using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Полиморфизм
{
    class Rose:Flower
    {
        public Rose(string color="Красный", int price=10) : base (color, price)
        {
            
        }

    }
}
