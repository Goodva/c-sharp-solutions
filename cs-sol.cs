using System;

namespace ConsoleApp1
{
    public class Program
    {
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
            Person p = new Person();
            p.Print();

            p.age = 96; p.name = "suka yeblivaya";
            p.Print();
            */

            /*
            Person Vitalya = new Person(); Vitalya.Print();
            Person noName = new Person(40); noName.Print();
            Person noAge = new Person("Дима"); noAge.Print();
            Person ZMP = new Person("Зубенко Михаил Петрович", 56); ZMP.Print();
            */

            Shpala shp = new Shpala();
            shp.height = 11; shp.width = 6;

            Shpala shpala = new();

            Shpala shpala1 = new Shpala(10);
            Shpala shpala2 = new Shpala(10, 6);

            shp.print();
            shpala.print();
            shpala1.print();
            shpala2.print();
        }
    }
}
