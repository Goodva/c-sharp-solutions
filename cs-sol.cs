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
            for(int i = a+1; i <= b; i++)
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
            public int[] cont = new int[4] {200, 10, 7, 9};     //КБЖУ на 100г: ККал, белки, жир, углеводы

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

        public static void Main(string[] args)
        {
            /*
            Borgar burger = new Borgar(); burger.print();
            int[] cont = { 400, 3, 300, 228 }; Console.WriteLine("===================");
            Borgar senior = new Borgar("Бургер Сеньйор", 199.99, 240, cont);    senior.print();
            */
            int a = 1;
            int b = 40;
            //Console.WriteLine($"ввод: {a}; вывод: {DigitMult(a)}");
            Console.WriteLine($"Ввод: {a}, {b}; Вывод: {MultRange(a, b)}");
        }
    }
}
