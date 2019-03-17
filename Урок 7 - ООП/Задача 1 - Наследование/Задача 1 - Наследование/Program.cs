using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1___Наследование
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Tom = new Student("Tom","man", 18, 61);
            Student Jerry = new Student("Jerry", "man", 18, 62);
            Student Karson = new Student("Karson", "man", 18, 63);
            Student Steve = new Student("Steve", "man", 18, 64);
           
            Teacher MrsGoogle = new Teacher("Mrs Google","women");
            
            MrsGoogle.GetStudentToGroup(Tom);
            MrsGoogle.GetStudentToGroup(Jerry);
            MrsGoogle.GetStudentToGroup(Karson);
            MrsGoogle.GetStudentToGroup(Steve);

            Karson.GoodStudent = false;
            MrsGoogle.CheckStudent(Karson);

            Console.WriteLine("Новый состав группы");
            foreach (var item in MrsGoogle.Group)
            {
                Console.Write(" {0}",item.Name);
            }
            Console.ReadKey();
        }
    }
}
