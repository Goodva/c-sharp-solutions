using System;

namespace ConsoleApp1
{
    public class Program
    {
        static int DigitMult(int a)
        {
            int num = a, length = (a.ToString()).Length;
            int result = 1;
            for (int i = 0; i < length; i++)
            {
                result *= num % 10; num /= 10;
            }
            return result;
        }

        static long MultRange(int a, int b)
        {
            if (a == b) return a;
            long result = a;
            for (int i = a + 1; i <= b; i++)
            {
                result *= i;
            }
            return result;
        }

        class Person
        {
            public string name = "Зубенко Михаил Петровичъ";
            public int age = 69;

            public void Print()
            {
                Console.WriteLine($"Меня зовут {name}, мне {age} лет.");
            }

            public Person()
            {
                name = "Chruka";
                age = 50;
            }

            public Person(int n)
            {
                name = "";
                age = n;
            }

            public Person(string n)
            {
                name = n;
                age = 0;
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class Borgar
        {
            public string name = "borgar сеньйор";                      //имя
            public double price = 119.99;                       //цена
            public int mass = 200;                              //масса, в граммах
            public int[] cont = new int[4] { 200, 10, 7, 9 };     //КБЖУ на 100г: ККал, белки, жир, углеводы

            public void print()
            {
                Console.WriteLine($"Название предмета в меню: {name}");
                Console.WriteLine($"Цена: {price}руб");
                Console.WriteLine($"Масса нет.: {mass}г.");
                Console.WriteLine($"КБЖУ на 100г:\n-Ккал: {cont[0]};\n-Белки: {cont[1]};\n-Жир: {cont[2]};\n-Углеводы: {cont[3]}.");
            }

            public Borgar()
            {
                this.name = "borgar джун";
                this.price = 119.99;
                this.mass = 200;
                this.cont[0] = 200; this.cont[1] = 10; this.cont[2] = 7; this.cont[3] = 9;
            }

            public Borgar(string name, double price, int mass, int[] cont)
            {
                this.name = name;
                this.price = price;
                this.mass = mass;
                this.cont = cont;
            }
            public Borgar(string name) : this()
            {
                this.name = name;
            }

            public Borgar(double price) : this()
            {
                this.price = price;
            }

            public Borgar(int mass) : this()
            {
                this.mass = mass;
            }

            public Borgar(int[] cont) : this()
            {
                this.cont = cont;
            }
        }

        struct Shpala
        {
            public int height, width;
            public void print()
            {
                Console.WriteLine($"Шпала высотой {height}см и шириной {width}см.");
            }

            public Shpala(int h, int w)
            {
                height = h; width = w;
            }

            public Shpala(int h) : this()
            {
                height = h;
            }
        }
        static void print_2d(int[,] a)
        {
            int rows = a.GetUpperBound(0) + 1;
            int colums = a.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void fuckingElves(int m, int n, int l, int t)
        {
            int[,] a = new int[m, n];
            int summ = 0;
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = i^j;
                    a[i, j] -= l;
                    if (a[i, j] < 0) a[i, j] = 0;
                    summ += a[i, j];
                }
            }
            Console.WriteLine("Говнотабличка:");
            print_2d(a);
            //summ %= t;
            if (summ % t != 0)
                Console.WriteLine($"При введенных данных, пажилому из чата задонатили {summ} секунд, но из-за говнокода ему всего пришло {summ % t}");
            else
                Console.WriteLine($"При введенных данных, пажилому из чата задонатили {summ} секунд, ни секунды не было потеряно из-за говнокода");
        }

        public static void Main(string[] args)
        {
            /*
            Borgar burger = new Borgar(); burger.print();
            int[] cont = { 400, 3, 300, 228 }; Console.WriteLine("===================");
            Borgar senior = new Borgar("Бургер Сеньйор", 199.99, 240, cont);    senior.print();
            
            int a = 1;
            int b = 40;
            //Console.WriteLine($"ввод: {a}; вывод: {DigitMult(a)}");
            Console.WriteLine($"Ввод: {a}, {b}; Вывод: {MultRange(a, b)}");
            */

            //Блять, я отказываюсь это комментировать
            //https://www.codewars.com/kata/59568be9cc15b57637000054/javascript
            //дана матрица, M x N 
            //матрица не рандомно генериться, члену матрицы присваевается xor его столбика и строки (M^N)
            //даны L - потеря на каждый член матрицы, и T - макс. лимит от 0 до 2^32-1
            //посчитать сумму матрицы после потери??? если сумма больше лимита, вычитается лимит лол
            //если член матрицы меньше или равен L, то с него донат не вычитаеться с него

            fuckingElves(5, 8, 1, 100);
        }
    }
}
