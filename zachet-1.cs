using System;

namespace zachet // сортировка вставкой
{
    internal class Program
    {
        static void printArr(int[] a) // высирание массива int в консоль
        {
            Console.Write("(");
            for (int i = 0; i < a.Length; i++)
            {
                if (i == a.Length - 1) Console.Write($"{a[i]})\n");
                else Console.Write($"{a[i]}, ");
            }
        }

        static int[] InsertionSort (int[] a) 
        {
            int n = a.Length;
            int s, j; // переменные для сравнения и перезаписи
            for(int i = 1; i < n; i++) // основной цикл, начинаем со 2 элемента т.к. 1 элемент несчем сравнить
            {
                s = a[i];
                j = i - 1;
                while(j >= 0 && a[j] > s) // ищем элемент, который меньше a[i]. если не нашли - то получается, что он - наименьший на данный момент
                {
                    a[j + 1] = a[j]; // перестановка элементов 
                    j--;
                }
                a[j + 1] = s; // присваивание
            }
            return a;
        }

        static void Main()
        {
            int[] Arr = new int[] {3, 5, 6, 2, 4, 1};

            Console.Write("Massiv: "); printArr(Arr); Console.WriteLine("-----");

            Arr = InsertionSort(Arr);

            Console.Write("Otsortirovanii massiv: "); printArr(Arr);
        }
    }
}
