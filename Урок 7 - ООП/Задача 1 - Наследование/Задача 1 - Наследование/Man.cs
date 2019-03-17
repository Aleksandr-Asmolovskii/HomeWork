using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1___Наследование
{
    /*1) Создать класс Man (человек), с полями: имя, возраст, пол и вес. 
     * Определить методы задания имени, возраста и веса. 
     * Создать производный класс Student, имеющий поле года обучения.
     *  Определить методы задания и увеличения года обучения. 
     *  Создать производный класс Teacher, разработать его функциональность 
     *  самостоятельно.*/
   public class Man
    {
        string _name;
        int _yearsOld;
        string _sex;
        double _weight;
       
        public Man (string name, string sex)
        {
            Name = name;
            Sex = sex;
        }
        public Man (string name,  string sex, int yearsOld, double weight)
        {
            Name = name;
            YearsOld = yearsOld;
            Sex = sex;
            Weight = weight;
        }
        public void Grow(int age, double weight)
        {
          YearsOld = YearsOld + age;
          Weight = Weight + weight;
        }
        public string Name
        {
          get { return _name; }
          set { _name = value; }  
        }
        public int YearsOld
        {
            get { return _yearsOld; }
            set { _yearsOld = value; }
        }
        private string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }



    }
}
