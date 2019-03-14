using System;

namespace Valid_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = { 121, 14641,361 ,20736 , 25921, 361, 20736, 361 };
            MyConsoleWrite(a, b);
            MyConsoleWrite(ValidArrays(a, b));//true
            int[] c = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] d = { 132, 14641, 20736, 361, 25921, 361, 20736, 361 };
            MyConsoleWrite(c, d);
            MyConsoleWrite(ValidArrays(c, d));//false
            int[] e = { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] f = { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
            MyConsoleWrite(e, f);
            MyConsoleWrite(ValidArrays(e, f));//false
            int[] g = null;
            int[] h = null;
            MyConsoleWrite(ValidArrays(g, h));//false
            int[] j = new int[6];
            int[] i = new int[6];
            MyConsoleWrite(ValidArrays(j, i));//false
            Console.ReadKey();
        }
        static bool ValidArrays(int [] a, int [] b)
        {
            int index = 0;
            try
            {
               for (int i = 0; i < a.Length; i++)
                  {
                           for (int j = 0; j < b.Length; j++)
                           {
                             if (a[j] * a[j] == b[i])
                             {
                             index = index + 1;
                                b[i] = 0;
                             } 
                           }
                  }
                  if (index == a.Length)
                  {
                       return true;
                  }
                  else
                 {
                      return false;
                 }     
            }
            catch (Exception)
            {
                return false;
            } 
           
        }
        static void MyConsoleWrite(bool iftrue)
        {
            if (iftrue == true)
            {
                Console.WriteLine("{0}",iftrue);
            }
            else
            {
                Console.WriteLine("{0}", iftrue);
            }

        }
        static void MyConsoleWrite(int[] a, int[] b)
        {
            foreach (var item in a)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            foreach (var item in b)
            {
                Console.Write(" " + item);
            }

        }
    }
}
