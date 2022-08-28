using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР07
{
    class Lines
    {
        public string s;
        public Lines()
        {
        }        public Lines(string s)
        {
            this.s = s;
        }

        //Получение слова
        static void GetWord(string s, int fp, int lp, int length, int c/*кол-во слов*/)
        {
            String[] word = s.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' });

        }

        //Подсчет в строке числа букв
        public int LetterCounter(string s)
        {
            int k = 0;
            s.ToLower();
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (char.IsLetter(s[i]))
                {
                    k++;
                }
            }
            return k;
        }

        //Подсчет в строке средней длины слова
        public double MiddleCounter(string s)
        {
            double k = 0;
            string wrd;
            s.ToLower();
            String[] words = s.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' });
            for (int i = 0; i <= words.Length - 1; i++)
            {
                wrd = words[i];
                k += words[i].Length;
            }
            k /= words.Length;
            return k;
        }


        //Замена в строке все вхождения заданного пользователем слова
        public string Change(string s, string word, string change)
        {
            int fp = 0;
            string wrd, s1 = "";
            s1 = s.ToLower();
            String[] words = s1.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' });
            for (int i = 0; i <= words.Length - 1; i++)
            {
                wrd = words[i];
                if (wrd == word)
                {
                    s1 = s1.Remove(fp, words[i].Length);
                    wrd = wrd.Replace(words[i], change);
                    s1 = s1.Insert(fp, wrd);
                }
                if (char.IsLetter(s1[words[i].Length + 2]))
                {
                    fp += words[i].Length + 1;
                }
                else
                {
                    int j = 1;
                    while (!char.IsLetter(s1[words[i].Length + j]))
                    {
                        j++;
                    }
                    fp += words[i].Length + j - 1;
                }
            }
            return s1;
        }

        //Подсчет в строке количество вхождений заданной подстроки
        public int SubSCounter(string s, string subS)
        {
            int i = 0;
            string s1;
            s1 = s.ToLower();
            i = (s1.Length - s1.Replace(subS, "").Length) / subS.Length;

            return i;
        }

        //Проверка, является ли строка палиндромом
        public void IsPalindrome(string s)
        {
            string s1 = s.ToLower();
            String[] words = s1.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' });
            s1 = string.Join("", words);
            string copyS1 = s1;
            copyS1 = ReverseString(copyS1);
            if (copyS1 == s1)
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }

        }

        //Перевертывание строки
        string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        //Получение числа
        static void GetDigit(string s, int fp, int lp, int length)
        {
            int l = s.Length;
            while ((fp <= l) && !(char.IsDigit(s[fp])))
            {
                fp++;
            }
            lp = fp;
            while ((lp <= l) && (char.IsDigit(s[lp])))
            {
                lp++;
            }
            length = lp - fp + 1;
            lp--;

        }

        //Проверка, является ли введенная строка датой
        public void IsData(string s)
        {
            int data = 0;
            int[] dig = new int[3];
            string Sdig;
            String[] words = s.Split(new char[] { '.' });
            if (words.Length == 3)//проверяем кол-во слов в строке
            {
                for (int i = 0; i <= words.Length - 1; i++)
                {
                    Sdig = words[i];
                    //Console.WriteLine(words[i]);
                    int p = 0;
                    for (int j = 0; j <= Sdig.Length-1; j++)
                    {
                        //проверяем, является ли слово числом
                       if (char.IsDigit(Sdig[j]))
                        {
                            p++;
                        }
                       
                    }
                    if (p == Sdig.Length)
                    {
                        dig[i] = Convert.ToInt32(Sdig);
                       
                    }
                    else
                    {
                        data = 0;
                    }
                }
            }
            else
            {
                data = 0;
            }

            int k = 0;
            if (dig[k] > 0)
            {
                if (dig[k] <= 31)
                {
                    if (dig[k + 1] <= 12)
                    {
                        if ((dig[k] > 29) && (dig[k + 1] == 2))
                        {
                            data = 0;
                        }
                        else if ((dig[k] > 30) && ((dig[k + 1] == 4)|| (dig[k + 1] == 6)|| (dig[k + 1] == 9)|| (dig[k + 1] == 11))) {
                            data = 0;
                        }
                        else {
                            if ((dig[k + 2] / 100 == 0) || (dig[k + 2] / 10000 == 0))
                            {
                                data = 3;
                            }
                        }
                        
                    }
                }

            }
            if (data == 3){
                Console.WriteLine("Это дата");
            }
            else
            {
                Console.WriteLine("Это не дата");
            }



        }
    }
}
