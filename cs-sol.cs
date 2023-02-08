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

        class Weapon
        {
            private string _name;         //название в файлах типо
            private string _name_loc;     //локализированое название
            private int _id;           //айдишник
            private int _dmg;             //урон
            private double _dmg_var;      //разброс урона, в процентах. т.е. если расброс 25%, то писать суда 0.25
            private int _rof;             //выстрелов в минуту
            private double _crit;         //шанс крита, так же как и с расбросом урона
            private bool _is_auto;        //автоматическое оружие или нет

            public Weapon()
            {
                this._name = "ak";
                this._name_loc = "AK-74";
                this._id = 000000;
                this._dmg = 39;
                this._dmg_var = 0.1;
                this._rof = 600;
                this._crit = 0.1;
                this._is_auto = true;
            }

            public Weapon(string _name, string _name_loc, int _id, int _dmg, double _dmg_var, int _rof, double _crit, bool _is_auto)
            {
                this._name = _name;
                this._name_loc = _name_loc;
                this._id = _id;
                this._dmg = _dmg;
                this._dmg_var = _dmg_var;
                this._rof = _rof;
                this._crit = _crit;
                this._is_auto = _is_auto;
            }

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public string Name_loc
            {
                get { return _name_loc; }
                set { _name_loc = value; }
            }

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public int Dmg
            {
                get { return _dmg; }
                set { _dmg = value; }
            }

            public double Dmg_var
            {
                get { return _dmg_var; }
                set { _dmg_var = value; }
            }

            public int Rof
            {
                get { return _rof; }
                set { _rof = value; }
            }

            public double Crit
            {
                get { return _crit; }
                set { _crit = value; }
            }

            public bool Is_auto
            {
                get { return _is_auto; }
                set { _is_auto = value; }
            }

            public virtual void print()
            {
                Console.WriteLine($"{_name_loc}|ID: {_id}");
                Console.WriteLine($"Урон: {_dmg-_dmg*_dmg_var} - {_dmg + _dmg * _dmg_var}");
                Console.WriteLine($"Шанс крита: {_crit * 100}%");
                Console.Write($"Темп стрельбы: {_rof}, ");
                if (_is_auto) Console.WriteLine($"Автоматический\n");
                else Console.WriteLine($"Полу-автоматический\n");
            }
        }

        class Shotgun : Weapon
        {
            private string _name;           //название в файлах типо
            private string _name_loc;       //локализированое название
            private int _id;                //айдишник
            private int _dmg;               //урон
            private double _dmg_var;        //разброс урона, в процентах. т.е. если расброс 25%, то писать суда 0.25
            private int _pellets;           //кол-во дроби
            private int _rof;               //выстрелов в минуту
            private double _crit;           //шанс крита, так же как и с расбросом урона
            private bool _is_auto;          //автоматическое оружие или нет

            public Shotgun()
            {
                this._name = "spas12";
                this._name_loc = "SPAS-12";
                this._id = 000000;
                this._dmg = 10;
                this._pellets = 12;
                this._dmg_var = 0.1;
                this._rof = 600;
                this._crit = 0.1;
                this._is_auto = true;
            }

            public Shotgun(string _name, string _name_loc, int _id, int _dmg, int _pellets, double _dmg_var, int _rof, double _crit, bool _is_auto)
            {
                this._name = _name;
                this._name_loc = _name_loc;
                this._id = _id;
                this._dmg = _dmg;
                this._pellets = _pellets;
                this._dmg_var = _dmg_var;
                this._rof = _rof;
                this._crit = _crit;
                this._is_auto = _is_auto;
            }

            public int Pellets
            {
                get { return _pellets; }
                set { _pellets = value; }
            }

            public override void print()
            {
                Console.WriteLine($"{_name_loc}|ID: {_id}");
                Console.WriteLine($"Урон: {_dmg - _dmg * _dmg_var}*{_pellets} - {_dmg + _dmg * _dmg_var}*{_pellets}");
                Console.WriteLine($"Шанс крита: {_crit * 100}%");
                Console.Write($"Темп стрельбы: {_rof}, ");
                if (_is_auto) Console.WriteLine($"Автоматический\n");
                else Console.WriteLine($"Полу-автоматический\n");
            }
        }

        class PhotoBook
        {
            private int _numPages;

            public PhotoBook()
            {
                this._numPages = 16;
            }

            public PhotoBook(int _numPages)
            {
                this._numPages = _numPages;
            }

            public int NumPages
            {
                get { return _numPages; }
                set { _numPages = value; }
            }

            public virtual int GetNumPages()
            {
                return _numPages;
            }
        }

        class BigPhotoBook : PhotoBook
        {
            private int _numPages;

            public int NumPages
            {
                get { return _numPages; }
                set { _numPages = value; }
            }

            public BigPhotoBook()
            {
                this._numPages = 64;
            }

            public override int GetNumPages()
            {
                return _numPages;
            }
        }

        class Vigenere
        {
            private char[] alphabet;

            public Vigenere()
            {
                this.alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            }
            
            public string encrypt_en(string msg, string key)
            {
                msg = msg.ToUpper();
                key = key.ToUpper();
                
                int i = 0;

                string result = "";

                foreach(char symbol in msg)
                {
                    int c = (Array.IndexOf(alphabet, symbol) + Array.IndexOf(alphabet, key[i])) % alphabet.Length;
                    result += c;
                    i++;
                    if ((i + 1) == key.Length) i = 0;
                }

                return result;
            }

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

            //fuckingElves(5, 8, 1, 100);


            //03.02.23
            //дрочка с классами
            /*
            Weapon ak = new Weapon();
            ak.print();

            Weapon pistol = new Weapon("glock", "Glock 17", 000002, 25, 0.5, 450, 0.15, false);
            pistol.print();

            pistol.Name = "1911"; pistol.Name_loc = "M1911"; pistol.Rof = 150; pistol.Crit = 0.1; pistol.Dmg = 30;
            pistol.print();

            Shotgun spas = new Shotgun();
            spas.Id = 3;
            spas.print();
            

            PhotoBook book1 = new PhotoBook();
            Console.WriteLine(book1.GetNumPages());

            BigPhotoBook book2 = new BigPhotoBook();
            Console.WriteLine(book2.GetNumPages());

            PhotoBook bookCustom = new PhotoBook(24);
            Console.WriteLine(bookCustom.GetNumPages());
            */

            //08.02.23
            //шифр виженера
            //дается слово для кодировки и ключ
            //пускай будет "SECRET" и "ABC"
            // 

            string message = "amogus at dawn", key = "lemonade";
            Vigenere V = new Vigenere();
            Console.WriteLine(V.encrypt_en(message,key));
        }
    }
}
