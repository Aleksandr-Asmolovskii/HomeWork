using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1___Наследование
{
    class Teacher:Man
    {
        public Teacher(string name, string sex) :base( name, sex)
        {
            Console.WriteLine("Новый учитель {0}" ,Name);
        }
        List <Student> _group = new List<Student>();
        public List <Student> Group
        {
            get {          
                return _group; }
            set { _group = value; }
        }

        public void GetStudentToGroup(Student newstudent)
        {
            _group.Add(newstudent);
            Console.WriteLine("Новый студент {0} зачислен в группу",newstudent.Name);
            Console.Write("Новый сотав группы:");
          
            foreach (Student student in Group)
            {
                Console.Write(" {0}",student.Name);
            }
            Console.WriteLine();
        }
        public void CheckStudent(Student student)
        {

            int index;
                if (student.GoodStudent==false)
                {
                    index = Group.IndexOf(student);                  
                    Console.WriteLine("Студент {0} исключен из группы за неуспеваемость",student.Name);
                    Group.RemoveAt(index);
                }
                
                
            }
        }

    }

