using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1___Наследование
{
    class Student:Man
    {
        bool _goodStudent = true;
        int _yearOfStudy = 0;
        public bool GoodStudent
        {
            get { return _goodStudent; }
            set { _goodStudent = value; }
        }

        public Student(string name, string sex, int yearsOld, double weight) : base( name,  sex, yearsOld, weight)
        {
            Console.WriteLine("Новый студент. Его зовут {0}", Name); 
        }

        public void StudySomeYears(int years)
        {
            _yearOfStudy = _yearOfStudy + years;
            if (_yearOfStudy<5)
            {
                Console.WriteLine("{0} все еще учится и сейчас на {1} курсе", Name, _yearOfStudy);
            }
            else if (_yearOfStudy == 5)
            {
                Console.WriteLine("{0} закончил весь курс обучения", Name);
            }
            else
            {
                Console.WriteLine("{0} отчислили и ему пришлось восстанавливаться поэтому срок его обучения затягивается",Name );
            }
           
            YearsOld = YearsOld + years;
        }

    }
}
