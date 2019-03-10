using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_методы
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите числа от 1 до 999");
           int[] Numbers = GetNumbers(Console.ReadLine());
            if (Numbers[0] == 0)
            {
                Console.WriteLine("-1 - Все числа на месте");
            }
            else
            {
                if (Numbers.Length > 1)
                {
                    Console.WriteLine("-1 - Пропущено более одного числа");
                }
                Console.WriteLine("Пропущенные числа:");
                for (int i = 0; i < Numbers.Length-1; i++)
                    {
                    Console.Write(" {0}",Numbers[i]);  
                    } 
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Определяем пропущенные числа
        /// </summary>
        /// <param name="mainstring">Исходная строка</param>
        /// <returns></returns>
        static int[] GetNumbers(string mainstring)
        {
           
            int[] numbers = new int[1] {0};
            int[] mainMass = {-1};
            try
            {
                int [] mass = GetMainMass(mainstring);
                Array.Resize(ref mainMass, mass.Length);
                for (int i = 0; i < mass.Length; i++)
                {
                    mainMass[i] = mass[i];
                }

            }
            catch (Exception)
            {
                numbers[0] = -1;
                Console.WriteLine("-1 - неверный ввод данных");
            }
            
            for (int i = 0; i < mainMass.Length-1; i++)
            {
                int delta = mainMass[i + 1] - mainMass[i];
                if (delta!=1)
                {
                    for (int j = 0; j < delta-1; j++)
                    {
                        numbers[numbers.Length - 1] = mainMass[i] + 1 + j;
                        Array.Resize(ref numbers, numbers.Length +1);
                    }
                }
            }
            return numbers;
        }
        /// <summary>
        /// Определяем массив int, числа которого расположены по возрастанию
        /// </summary>
        /// <param name="mainstring">Исходная строка</param>
        /// <returns></returns>
        static int[] GetMainMass(string mainstring)
        {    // для чисел от 1 до 99
            for (int i = 0; i <= mainstring.Length; i = i + 2)
            {
                int[] arrint = GetMass2(mainstring, i);
                int[] refArrInt = new int[arrint.Length];
                for (int h = 0; h < refArrInt.Length; h++)
                {
                    refArrInt[h] = arrint[h];
                }
                // если: отсортированный массив будет равен исходному и первsq элемент 
                //не равен второму, то числа определены верно.
                Array.Sort(arrint);
                //Сравниваем исходный и отсортированный массив
                int chek = 0;
                for (int d = 0; d < refArrInt.Length; d++)
                {
                    if (arrint[0]==arrint[1])
                      {
                        chek = -1;
                        break;
                    }
                    chek = chek + arrint[d] - refArrInt[d];
                    if (chek!=0)
                    {
                        break;
                    }
                }
                if (chek == 0)
                {
                    return refArrInt;
                }
                     for (int h = 0; h < refArrInt.Length; h++)
                    {
                       arrint[h] = refArrInt[h];
                    }
           }
            //Если выхода из метода не получилось то проверяем наличие цифр из трех чисел
            // для чисел от 100 до 999
            for (int i = 3; i <= mainstring.Length; i = i + 3)
            {
                int[] arrint = GetMass3(mainstring, i);
                int[] refArrInt = new int[arrint.Length];
                for (int h = 0; h < refArrInt.Length; h++)
                {
                    refArrInt[h] = arrint[h];
                }
                // если: отсортированный массив будет равен исходному и первый элемент 
                //не равен второму, то числа определены верно.
                Array.Sort(arrint);
                //Сравниваем исходный и отсортированный массив
                int chek = 0;
                for (int d = 0; d < refArrInt.Length; d++)
                {
                    if (arrint[0] == arrint[1])
                    {
                        chek = -1;
                        break;
                    }
                    chek = chek + arrint[d] - refArrInt[d];
                    if (chek != 0)
                    {
                        break;
                    }
                }
                if (chek == 0)
                {
                    return refArrInt;
                }
                for (int h = 0; h < refArrInt.Length; h++)
                {
                    arrint[h] = refArrInt[h];
                }

            }
            // Если не удалось определить последовательность
            //чисел в строке возвращаем null
            return null;
        }
        /// <summary>
        /// Создает массив int из строки, группируя по два нужное количество последних символов строки 
        /// </summary>
        /// <param name="mainstring">Входная строка</param>
        /// <param name="index">Количестов символов с конца строки, которые необходимо сгрупировать по 2 </param>
        /// <returns></returns>
        static int[] GetMass2(string mainstring, int index)
        {
            int Lengs = mainstring.Length;
            int Backindex = index / 2; //определяем колтчество цифр из двух чисел
            int[] arrint = new int[mainstring.Length - index + Backindex];
            for (int i = arrint.Length - 1; i > arrint.Length - Backindex - 1; i--)
            {
                //присваевыем 2 последних символа к i - элементу массива (начинаем с конца)
                string lastnumber = Convert.ToString(mainstring[mainstring.Length - 2])
                                  + Convert.ToString(mainstring[mainstring.Length - 1]);
                arrint[i] = Convert.ToInt32(lastnumber);
                // уменьшаем исходную строку на 2 символа
                char[] arrchar = mainstring.ToCharArray();
                Array.Resize(ref arrchar, arrchar.Length - 2);
                mainstring = "";
                for (int h = 0; h < arrchar.Length; h++)
                {
                    mainstring = mainstring + Convert.ToString(arrchar[h]);
                }
            }
            // Заполняем первые элементы массива которые не надо группировать
            for (int i = 0; i < arrint.Length - Backindex; i++)
            {
                string lastnumber = Convert.ToString(mainstring[i]);
                arrint[i] = Convert.ToInt32(lastnumber);
            }
            return arrint;
        }
        /// <summary>
        /// Создает массив int из строки, группируя по три и по два нужное количество последних символов строки 
        /// </summary>
        /// <param name="mainstring">Входная строка</param>
        /// <param name="index">Количестов символов с конца строки, которые необходимо сгрупировать по 3, остальные группируются по два </param>
        /// <returns></returns>
        static int[] GetMass3(string mainstring, int index)
        {
            int Length = mainstring.Length;
            int Backindex = index / 3; //определяем колтчество цифр из трех чисел
            // Проверяем можно ли сгрупировать оставшиеся числа по два
            do
            {
                if ((Length - Backindex*3)%2==0)
                   {
                   break;
                   }
                 else
                   {
                    Backindex = Backindex + 1;
                    index = index + 3;
                   }
            } while (true);
                //присваевыем 3 последних символа к i - элементу массива (начинаем с конца)
            int[] arrint = new int[(mainstring.Length - index)/2 + Backindex];
            for (int i = arrint.Length - 1; i > arrint.Length - Backindex - 1; i--)
            {
               string lastnumber = Convert.ToString(mainstring[mainstring.Length - 3])
                                 + Convert.ToString(mainstring[mainstring.Length - 2])
                                 + Convert.ToString(mainstring[mainstring.Length - 1]);
                arrint[i] = Convert.ToInt32(lastnumber);
                // уменьшаем исходную строку на 3 символа
                char[] arrchar = mainstring.ToCharArray();
                Array.Resize(ref arrchar, arrchar.Length - 3);
                mainstring = "";
                for (int h = 0; h < arrchar.Length; h++)
                {
                    mainstring = mainstring + Convert.ToString(arrchar[h]);
                }
            }
            // Заполняем первые элементы массива, используя метод GetMass2,
            // когда все цифры группируются в числа по два 
            if (mainstring!="")
            {
             int[] arrint2 = new int[mainstring.Length];
             arrint2 = GetMass2(mainstring, mainstring.Length);
                 for (int i = 0; i < arrint2.Length; i++)
                  {
                      arrint[i] = arrint2[i];
                  }
            }
            return arrint;
        }
    }
}
