using System;

namespace zachet2 
    // переобразовать строку в массив шестнадцатиричных кодов цветов, преобразовывать по словам
    // берется первые 3 символа слова, и конвертируются в 16СС, складываются, и вот наше хекс число/цвет
{
    internal class Program
    {
        static string char2Hex(char a)
        {
            return Convert.ToByte(a).ToString("X"); //конвертируем символ в его битное число в 10СС, потом в 16СС 
        }

        static string[] str2Hex(string a)
        {
            a = a.Replace(",", ""); a = a.Replace(".", "");//убираем из входной строки точки и запятые
            string[] wordArr = a.Split(' '); //обьявляем новый массив строк, состоящих из слов входной стрки
            string[] hexArr = new string[wordArr.Length]; // массив для хекс чисел, который пойдет на выход и в который мы будем записывать значения
            int i = 0;
            foreach(string word in wordArr)
            {
                switch(word.Length)
                {
                    case 2:
                        hexArr[i] = "#" + char2Hex(word[0]) + char2Hex(word[1]) + "00";
                        i++;
                        break;
                    case 1:
                        hexArr[i] = "#" + char2Hex(word[0]) + "0000";
                        i++;
                        break;
                    default:
                        hexArr[i] = "#" + char2Hex(word[0]) + char2Hex(word[1]) + char2Hex(word[2]);
                        i++;
                        break;
                }
            }

            return hexArr;
        }

        static void Main()
        {
            string Str = "Hello, my name is Gary and I like cheese.";
            Console.WriteLine(Str);
            //Console.WriteLine(char2Hex(Str[0])); // debug
            Console.WriteLine("Otvet:");
            string[] hex = str2Hex(Str);
            foreach(string value in hex)
            {
                Console.Write($"{value}; ");
            }
        }
    }
}
