using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrxxivv
{
    class convert
    {
        public string[] Lines { get; set; } 
        public string Text { get; set; }

        public string Adress { get; set; }
        public string AdressResult { get; set; }

        public string TextResult { get; set; }
        public string[] LinestResult { get; set; }

        public string[] MyDictionary= {""};
        public convert()
        {
             try
            {
                
                Text =System.IO.File.ReadAllText(@"D:\1.txt");
                Lines = System.IO.File.ReadAllLines(@"D:\1.txt");
            }                                  
            catch (Exception)
            {
                Console.WriteLine("Ошибка");
            }
        }

        public void TakeWords()
        {
            string[] linesResult = Text.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '"', '-' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < linesResult.Length; i++)
            {
                string word = linesResult[i];
                int count = 0;
                for (int j = i; j < linesResult.Length; j++)
                {
                    if (word == linesResult[j]&& word.Length>5)
                    {
                        count = count + 1;
                    }
                }
                if (count>10&& Convert.ToString(MyDictionary.Length).Length+3<word.Length)
                {
                    if (!MyDictionary.Contains(word) && word.Length > 5)
                    {
                    MyDictionary[MyDictionary.Length-1]= word;
                    Array.Resize(ref MyDictionary, MyDictionary.Length + 1);
                    CodeWords(word, MyDictionary.Length-2);
                    }
                   
                }
            }
        }

        public void CodeWords(string word,int start)
        {
            string Line;
              for (int i = 0; i < Lines.Length; i++)
                {
                    if (Lines[i].Contains(word))
                    {
                        Line = Lines[i];
                        for (int j = Line.Length - word.Length-1; j>0; j--)
                        {
                            int lengs=0;
                             int index = 0;
                            for (int k = j; k <j+word.Length; k++)
                            {

                                if (Line[k]== word[index])
                                {
                                    lengs++;
                                }
                                else
                                {
                                    break;
                                }
                            index++;
                                if (lengs == word.Length)
                            {
                                   Line = Line.Remove(j, word.Length);
                                    string code = "#" + Convert.ToString(start);
                                  Line =  Line.Insert(j, code);
                                 }
                            }
                       }
                        Lines[i] = Line;
                    }
                }
            
            
        }

        public void WriteFileShote1()
        {
            string[] dictionary = MyDictionary.ToArray();

            for (int i = 0; i < dictionary.Length; i++)
            {
                Lines[Lines.Length - 1] = Lines[Lines.Length - 1] + i + dictionary[i];
            }


            System.IO.File.WriteAllLines(@"D:\4.txt", Lines);

        }

        public void ShortFile()
        {
            for (int i = 0; i <Lines.Length; i++)
            {
                Console.WriteLine(Lines[i]);
                if (Lines[i].Trim()=="")
                {
                    Lines[i] = "#";
                }
                TextResult = TextResult + Lines[i];
            }            
        }

        public void LongFile()
        {
            TextResult = "";
            for (int i = Text.Length-1; i < 0; i++)
            {
                if (Text[i]=='#')
                {
                    Text.Insert(i, "#");
                }
            }

           LinestResult = Text.Split(new char[] {'#'});
        }

        public void WriteFileLong()
        {
           
           System.IO.File.WriteAllLines(@"D:\4.txt", LinestResult);

        }

        public void WriteFileShort()
        {
            System.IO.File.WriteAllText(@"D:\5.txt", TextResult);
        }

    } 
}
