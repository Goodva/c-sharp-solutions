using System;
// нихуя не дорогой мне второкурсник, если тронеш этот файл я тебе точно руки в жопу засуну

void print_array(int[] a) // высирание массива int в консоль
{
    Console.Write("(");
    for(int i = 0; i < a.Length; i++)
    {
        if(i == a.Length - 1) Console.Write($"{a[i]})\n");
        else Console.Write($"{a[i]}, ");
    }
}

void print_shit(int[,] a) // залупный вывод 2Д массива, мне нужно не совсем это
{
    int rows = a.GetUpperBound(0) + 1;
    int colums = a.Length / rows;

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write($"{a[i,j]}");
        }
        Console.WriteLine();
    }
}

void print_2d_array(int[,] a)
{
    int rows = a.GetUpperBound(0) + 1;
    int colums = a.Length / rows;

    for(int i = 0; i < colums; i++)
    {
        Console.Write("[");
        for(int j = 0; j < rows; j++)
        {
            if(j == rows - 1) Console.Write($"{a[j,i]}");
            else Console.Write($"{a[j,i]}, ");
        }
        Console.WriteLine("]");
    }
}

void print_jagged_r(int[][] a) // высирание зубчатого прямоугольного массива, повернув его на 90град. на лево, мне так надо
{
    int b = a[0].Length;
    for (int i = 0; i < b;i++)
    {
        Console.Write("[");
        for (int j = 0; j < a.Length; j++)
        {
            if(j == a.Length - 1) Console.Write($"{a[j][i]}");
            else Console.Write($"{a[j][i]}, ");
        }
        Console.WriteLine("]");
    }   
}

void print_long(long[] a) // высирание массива long в консоль
{
    Console.Write("(");
    for(int i = 0; i < a.Length; i++)
    {
        if(i == a.Length - 1) Console.Write($"{a[i]})\n");
        else Console.Write($"{a[i]}, ");
    }
}

void print_char(char[] a) // высирание массива char в консоль
{
    Console.Write("(");
    for(int i = 0; i < a.Length; i++)
    {
        if(i == a.Length - 1) Console.Write($"{a[i]})\n");
        else Console.Write($"{a[i]}, ");
    }
}

void print_string_arr(string[] a) // высирание массива string в консоль
{
    Console.Write("(");
    for(int i = 0; i < a.Length; i++)
    {
        if(i == a.Length - 1) Console.Write($"{a[i]})\n");
        else Console.Write($"{a[i]}, ");
    }
}

void print_string(string a)
{
    char[] b = a.ToCharArray();
    print_char(b);
}

int[] bubble(int[] a) // сортировка пузырьcum
{
    int[] sorted = a;
    int temp = 0;
    for(int i = 0; i < a.Length; i++)
    {
        for(int j = 0; j < a.Length - 1; j++)
        {
            if(sorted[j] > sorted[j+1])
            {
                temp = sorted[j+1];
                sorted[j+1] = sorted[j];
                sorted[j] = temp;
            }
        }
    }
    return sorted;
}

int[] quicksort(int[] a, int leftmost, int rightmost) 
//быстрая сортировка, прикинь, leftmost - самый левый индекс нужного массива,
// rightmost - самый правый индекс. эти две херовены нужны потомучто функция - рекурсивная,
// т.е. функция сама себя вызывает
{
    int[] sorted = a;//массив на вывод//int temp = 0;
    int i = leftmost, j = rightmost;//i - первое число, j - предпоследнее, т.к мы берем последнее число для pivot'a
    int pivot = sorted[j]; // наше пиво(t), идет на вывод

    while(i <= j) // сам акт сортировки, тут я разбирать эту залупу не буду, см. в википедии
    {
        while(sorted[i]<pivot) i++;
        while(sorted[j]>pivot) j--;

        if(i <= j)
        {
            int temp = sorted[i];
            sorted[i] = sorted[j];
            sorted[j] = temp;
            i++; j--;
        }
    }

    if(j > leftmost)
        quicksort(sorted,leftmost,j);
    
    if(i < rightmost)
        quicksort(sorted,i,rightmost);
    
    return sorted;
}
Random rng = new Random();
// 24.11.22
/* //////////////// 1
// Сумма квадратов
int square_sum(int[] a){
    int n = a.Length;
    double b = 0;
    for (int i = 0; i < n; i++)
    {
        b += Math.Pow(a[i], 2);
    }
    int c = Convert.ToInt32(b);
    return c;
}
const int n = 3;
int[] array = new int [n];
for(int i = 0; i < n; i++)
{
    Console.Write($"Введите {i+1}-й член массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int a = square_sum(array);
Console.WriteLine($"Сумма квадратов заданного массива равна {a}");
*/

/* //////////////// 2
// Mассив первых M множителей числа N
int[] func(int a, int b)
{
    int[] ar = new int [b];
    int c = a;
    for(int i = 0; i < b; i++)
    {
        ar[i] = c;
        c += a;
    }
    return ar;
}
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int[] array = func(a,b);
Console.Write($"Mассив первых {b} множителей числа {a}: (");
for(int i = 0; i < array.Length; i++)
{
    if(i == array.Length - 1) Console.Write($"{array[i]})");
    else Console.Write($"{array[i]}, ");
}
*/

/* //////////////// 3
// Переворот массива
int[] reverse_order(int a){
    int[] b = new int[a];
    for(int i = 0; i < a; i++)
    {
        b[i] = a - i;
    }
    return b;
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = reverse_order(n);
Console.WriteLine($"Обратная последовательность от {n} до 1: ");
print_array(array);
*/

/* //////////////// 4
// сумма чисел от N до M включительно
int sum_between(int a, int b)
{
    int sum = 0;
    if(a == b) return a;
    else if(a > b){ for(int i = b; i <= a; i++) sum += i; }
    else { for(int i = a; i <= b; i++) sum += i;}
    return sum;
}
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"сумма чисел от {a} до {b} включительно равна {sum_between(a,b)}");
*/

/* //////////////// 5
// Сумма всех множителей 3 и 5 от 1 до N
int some_summ(int n)
{
    int summ = 0;
    for(int i = 1; i < n; i++)
    {
        if(i % 3 == 0 || i % 5 == 0) summ += i;
    }
    return summ;
}
int check = 0;
int a = 0;
while(check != 1)
{
    Console.Write("Введите положительное число: ");
    a = Convert.ToInt32(Console.ReadLine());
    if(a >= 0) check++;
    else Console.WriteLine("Введеное число не положительно, введите заново.");
}
Console.WriteLine($"Сумма всех множителей 3 и 5 от 1 до {a} равна {some_summ(a)}.");
*/

/* //////////////// 6
// Какому веку принадлежит год
int vek(int a)
{
    int b = (a - a % 100)/100;
    if(a%100 == 0) return b;
    else b++;
    return b;
}

int check = 0;
int a = 0;
while(check != 1)
{
    Console.Write("Введите год: ");
    a = Convert.ToInt32(Console.ReadLine());
    if(a >= 0) check++;
    else Console.WriteLine("Год не может быть отрицательным, тупица.");
}

Console.WriteLine($"{a} год пренадлежит {vek(a)} веку.");
*/

//25.11.22

//int a = 5, b = 7; //тернарная операция
//int c = a > b ? a : b;
/* //////////////// 1
// Сумма от 1 до N
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 0, i = 0;

if(a == 1) b = 1;
else if (a > 1)
{
    
    while(i != a)
    {
        b += i;
        i++;
    } 
}
else
{
    
    while (i != a)
    {
        b += i;
        i--;
    } 
}
Console.WriteLine($"Сумма от 1 до {a} равна {b}.");
*/

/* //////////////// 2
// Суммирование введеных чисел до остановки пользователя
int count = 0, summ = 0, input = 0;
do{
    Console.Write("Введите число:");
    input = Convert.ToInt32(Console.ReadLine());
    count++;
    summ += input;
    if(input == 0){ 
        count--;
        break;
    }
}while(true);

Console.WriteLine($"Сумма введеных чисел: {summ}; Кол-во введеных чисел: {count}.");
*/

/* //////////////// 3
// Проверка на ввод числа от 1 до 99 включительно??? хз
int a;
do{
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());
    if(a > 0 && a < 100) break;
    else Console.Write("Неверное число. ");
}while(true);
Console.WriteLine("Число введено правильно.");
*/

// 02.12.22
// foreach(int i in Array)
//{
//  Console.WriteLine(i)
//}

// 09.12.22
//////////////// 1
// создайте массив и найдите все положительные числа

/*
Console.Write("Введите размер рандомного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int a = 0;
int[] arr = new int[n];

for(int i = 0; i < n; i++)
{
    arr[i] = rng.Next(-100,100);
    if(arr[i] >= 0) a++;
}

Console.Write($"массив, рамера {n} из чисел от -100 до 100: ");
print_array(arr);
Console.Write($", где {a} чисел - положительные.");

*/

 //////////////// 2
//создайте массив и инвертируете его ежжи

/*
Console.Write("Введите размер рандомного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int[] rra = new int[n]; // инвертнутый массив ежжи

for(int i = 0; i < n; i++)
{
    arr[i] = rng.Next(-100,100);
    rra[n - 1 - i] = arr[i];
}
Console.Write($"массив, рамера {n} из чисел от -100 до 100: ");
print_array(arr);
Console.Write(";\nинвертированый массив arr: ");
print_array(rra);

*/

 //////////////// 3
/* сортировка массива guh?

Console.Write("Введите размер рандомного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n];
int[] arr_sorted = new int[n]; // сортированый массив ежжи

for(int i = 0; i < n; i++){ arr[i] = rng.Next(-100,100); }

Console.Write($"массив, рамера {n} из чисел от -100 до 100: ");
print_array(arr);

arr_sorted = bubble(arr);
Console.Write("\nОтсортированый массив:");
print_array(arr_sorted);

*/

// 18.01.23
//////////////// 1
// сортировка пиво(м)том

// Console.Write("Введите размер рандомного массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[n];
// int[] arr_sorted = new int[n]; // массив куда будет отсортировываться сгенерированая залупа

// for(int i = 0; i < n; i++){ arr[i] = rng.Next(-100,100); }

// Console.Write($"массив, рамера {n} из чисел от -100 до 100: ");
// print_array(arr);

// arr_sorted = quicksort(arr,0,arr.Length-1);
// Console.Write("\nОтсортированый массив:");
// print_array(arr_sorted);

// 20.01.23
//////////////// 1
// сравнение с нулем

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if(n > 0) Console.WriteLine("Введеное число больше нуля.");
// else if(n < 0) Console.WriteLine("Введеное число меньше нуля.");
// else Console.WriteLine("Введеное число равно нулю.");

//////////////// 2
// проверка строчки на полиндром 
// без учета пробелов и регистров

// Console.Write("Введите слово или предложение(кириллицу не видит): ");
// string a = Convert.ToString(Console.ReadLine());

// a = a.ToLower(); // весь регистр строки сносим нахой
// a = a.Replace(" ", ""); // вынос пробелов из строки

// char[] arr = a.ToCharArray(); char[] rra = arr;
// Array.Reverse(rra); 

// if(arr == rra) Console.WriteLine("Введеное является полиндромом.");
// else Console.WriteLine("Введеное не является полиндромом.");
    
// print_char(arr); Console.Write(", "); print_char(rra);

//////////////// 3
// Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета a. Использовать вложенные циклы.

// Console.Write("Введите катет прямоугольного треугольника(длина стороны крч): ");
// int a = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i <= a; i++)
// {
//     if(i == 1 || i == a)
//     {
//         for(int j = 1; j <= i; j++)
//         {
//             Console.Write("*");
//             if(j == i) Console.Write("\n");
//         }
//     }
//     else
//     {
//         Console.Write("*");
//         for(int j = 2; j < i; j++) Console.Write(" ");
//         Console.Write("*\n");
//     }
// }

//////////////// 4
// Дано три различных числа a, b, c. Вывести среднее из них.

// int[] a = new int[3];
// Console.WriteLine("Введите 3 числа:");
// for(int i = 0; i < 3; i++)
// {
//     Console.Write($"Введите {i+1}е число: ");
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }

// if(a[0] == a[1] || a[1] == a[2] || a[0] == a[2]) Console.WriteLine("Двое или все из введеных чисел равны, среднего нет.");
// else {
//     a = bubble(a);
//     Console.WriteLine($"Средним числом является {a[1]}.");
// }

//protip:
//double b = 16.2;
//вместо 
//  int a = Convert.ToInt32(b);
//можно написать
//  int a = (int)b;

//////////////// доп. задача, чисто для меня и демидова
// Перетасовка Ханафуда

// int n; // размер колоды
// while(true)
// {
//     Console.Write("Введите размер колоды (1 <= n <= 50): ");
//     n = Convert.ToInt32(Console.ReadLine());
//     if(1 <= n && n <= 50) break;
//     else Console.WriteLine("Размер введенной колоды уходит за заданные гранницы");
// }

// int r;
// while(true)
// {
//     Console.Write("Введите кол-во срезов (1 <= r <= 50): ");
//     r = Convert.ToInt32(Console.ReadLine());
//     if(1 <= r && r <= 50) break;
//     else Console.WriteLine("Кол-во срезов уходит за заданные гранницы");
// }

// int p; //с какой карты сверху начнется срез
// while(true)
// {
//     Console.Write($"Введите с какой карты снизу начнется срез (1 <= p <= {n}, где 1 - дно колоды): ");
//     p = Convert.ToInt32(Console.ReadLine());
//     if(1 <= p && p <= n) break;
//     else Console.WriteLine("Номер карты уходит за заданные гранницы");
// }

// int c; //кол-во карт в срезе
// while(true)
// {
//     Console.Write($"Введите кол-во карт в срезе (1 <= c <= {p}): ");
//     c = Convert.ToInt32(Console.ReadLine());
//     if(1 <= c && c <= n-p) break;
//     else Console.WriteLine("Кол-во карт уходит за заданные гранницы");
// }

// // Console.WriteLine($"n = {n}, r = {r}, p = {p}, c = {c}.");

// //n - размер, r - кол-во срезов, p - с какой карты сверху идет срез, c - кол-во карт в срезе

// int[] deck = new int[n]; // наша колода
// for(int i = 0; i < n; i++) deck[i] = i+1; // заполнение колоды

// int[] cut = new int[c]; // массив для среза
// int[] offset = new int[n-p]; // массив для перестановки сверху на место среза

// Console.WriteLine("Колода выглядит так: ");
// print_array(deck);
// Console.Write($", где 1 - дно колоды, {n} - верхушка.\n");
// Console.Write("=================================");

// int k = 0; // индекс для записи в сut и offset

// for(int i = 0; i < r; i++) // сам цикл, циклицться по кол-ву срезов(очевидно)
// {   
//     for(int j = p - c ; j < p ; j++) // запись в cut, снизу вверх
//     {
//         cut[k] = deck[j];
//         k++;
//     }
//     k = 0;
//     //Console.Write($"\ncut {i+1} "); print_array(cut);

//     for(int j = p; j <= n-1; j++) // запись в offset, тоже снизу вверх
//     {
//         offset[k] = deck[j];
//         k++;
//     }
//     int o = p - c;
//     //Console.Write($"\noffset "); print_array(offset);

//     for(k = 0; k < offset.Length; k++) // перепись самой колоды(перетасовка), запись карты выше среза вниз
//     {
//         deck[o] = offset[k];
//         o++;
//     }
//     //Console.Write("\noffset deck: "); print_array(deck);

//     for(k = 0; k < cut.Length; k++) // перепись колоды, постановка среза на верх колоды
//     {
//         deck[o] = cut[k];
//         o++;
//     }
//     //Console.Write($"\ncut {i} done:"); print_array(deck);
// }

// Console.WriteLine($"\nTopdeck после {r} среза(ов): {deck[deck.Length-1]}.");

// 25.01.23
//////////////// 1
// фибоначчи, лмао
// Your task is to efficiently calculate the nth element in the Fibonacci sequence 
// and then count the occurrence of each digit in the number. Return a list of integer pairs sorted in descending order.

// https://www.codewars.com/kata/5779f894ec8832493f00002d/python

// int n; // искомое число фибоначчи
// while(true){
//     Console.Write("Введите искомое число фибоначчи(10 <= n <= 93):");
//     n = Convert.ToInt32(Console.ReadLine());
//     if(10 <= n && n <= 93) break;
//     else Console.WriteLine("неправильно");
// }

// long[] f = new long[n]; f[0] = 0; f[1] = 1; 
// for(int i = 2; i < n; i++) f[i] = f[i-1] + f[i-2];
// long a = f[n-1]; // нахождение нужного числа

// Console.Write($"Искомое число фибоначчи: {a}.");// \nмассив: ");  print_string(f); 

// int[][] count = new int[2][];
// count[0] = new int[10] {0,1,2,3,4,5,6,7,8,9}; // массив индекслов, залупа
// count[1] = new int[10] {0,0,0,0,0,0,0,0,0,0}; // массив счета чисел

// string b = a.ToString(); // ,блять, я заебался,
// int[] numba = new int[b.Length];
// for(int i = 0; i < b.Length; i++) {numba[i] = int.Parse(b[i].ToString());}

// for(int i = 0; i < 10; i++) // подсчет цифр в числе бляяяяяяяя
// {
//     for(int j = 0; j < numba.Length; j++)
//     {   
//         if(i == numba[j]) count[1][i]++;
//     }
// }

// int[] temp = new int[2]; // для перестановки | 0 - индекс, 1 - сам счет
// for(int i = 9; i >= 0; i--) // сортировка пузырьcum, от наименьшего к большему
// {
//     for(int j = 9; j > 0; j--)
//     {
//         if(count[1][j] > count[1][j-1])
//         {
//             temp[0] = count[0][j-1];        temp[1] = count[1][j-1];
//             count[0][j-1] = count[0][j];    count[1][j-1] = count[1][j];
//             count[0][j] = temp[0];          count[1][j] = temp[1];
//         }
//     }
// }

// Console.WriteLine("\nОтсортировано: ");print_jagged_r(count);

//////////////// 2
// удаление символов из строки

// string stringi = "Petuhon";
// int i;
// while(stringi.Length != 0)
// {
//     Console.Write($"Дана строка {stringi}, введите число от 0 до {stringi.Length-1} для удаления символа из строки. \nВведите i < 0 чтобы выйти.");
//     i = Convert.ToInt32(Console.ReadLine());
//     if(i < 0) break;
//     else if(i > stringi.Length-1) Console.WriteLine("Индекс символа уходит за границу, еблан.");
//     else stringi = stringi.Remove(i,1);
// }

//////////////// 2
// Написать прогу для проверки двух заданных целых чисел, каждое из которых находится в диапазоне 10..99. 
// Возвращает значение true, если в обоих числах появляется цифра, например 3 в 13 и 33 
int a, b;
while(true)
{
    Console.WriteLine("Введите первое число(10-99): ");
    a = Convert.ToInt32(Console.ReadLine());
    if(a > 9 && a < 100) break;
}
while(true)
{
    Console.WriteLine("Введите второ число: ");
    b = Convert.ToInt32(Console.ReadLine());
    if(b > 9 && b < 100) break;
}
