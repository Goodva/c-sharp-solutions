using System;
// нихуя не дорогой мне второкурсник, если тронеш этот файл я тебе точно руки в жопу засуну

void print_array(int[] a) // высирание массива int в консоль
{
    Console.Write("(");
    for(int i = 0; i < a.Length; i++)
    {
        if(i == a.Length - 1) Console.Write($"{a[i]})");
        else Console.Write($"{a[i]}, ");
    }
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
Random rng = new Random();
// 24.11.22
/* //////////////// 1
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
