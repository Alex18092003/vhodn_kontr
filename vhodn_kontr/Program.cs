using System;


namespace vhodn_kontr
{
    class Program
    {
        static void vvod(double a, double b)
        {
            double c;
            c = Math.Pow(a, b);
            Console.WriteLine($"Результат вычислений = {c}");

        }

        static void vvod2(double c)
        {
            double d = c % 2;
            double a = c % 3;
            if (d == a)
            {
                Console.WriteLine("Число дает одинаковый остаток при деление на 2 и на 3");
            }
            else
            {
                Console.WriteLine("Число дает не одинаковый остаток при деление на 2 и на 3");
            }


        }

        static void vvod3(double v, double d)
        {
            double c = 1 + Math.Sin(Math.Sqrt(v+1));
            double l = Math.Cos(12*d - 4);
            Console.WriteLine($"Результат вычисления примера = {c/l}");
        }

        static void Fibonachi (int l)
        {
            int prev = 0;
            int curr = 1;
            int next = 1;
            Console.WriteLine("Последовательность чисел Фибоначчи с четным индексом: "); ;
            for (int i = 1; i <= l; i++)
{
                if (i % 2 == 0)
                {
                    Console.WriteLine("Число = " + curr + " Индекс = " + i);
                }
                prev = curr;
                curr = next;
                next = prev + curr;
                
            }
            
        }

        static void vvod4(int n)
        {
            double m = 1;
            double o = 2;
            double c = 0;
            
            for (int i = 1; i <= n; i++)
            {
                c = c + m/o;
                m=m+1;
                o=o+1;
            }
            Console.WriteLine($"Результат вычислений = {c}");
        }

        static void vvod5(double nn, double nnn, double nnnn)
        {
            if (nn > nnn && nn > nnnn)
            {
                Console.WriteLine($"Первый победил {nn}");
            }
            if (nnn > nn && nnn > nnnn)
            {
                Console.WriteLine($"Второй победил {nnn}");
            }
            if (nnnn > nn && nnnn > nnn)
            {
                Console.WriteLine($"Третий победил {nnnn}");
            }
            if (nn > nnnn && nnn > nnnn)
            {
                Console.WriteLine($"Первый и второй победили {nn} и {nnn}");
            }
            if (nn > nnn && nnnn > nnn)
            {
                Console.WriteLine($"Первый и третий победили {nn} и {nnnn}");
            }
            if (nnn > nn && nnnn > nn)
            {
                Console.WriteLine($"Второй и третий победили {nnn} и {nnnn}");
            }
            else
            {
                Console.WriteLine($"Ничья {nn} и {nnn} и {nnnn}");
            }

        }

        static void Main (string[] arg)
        {
            while (true)
            {
                Console.WriteLine("Задача 1:");
                double a, b;
                try
                {
                    Console.WriteLine("Введите первое вещественное число:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе вещественное число:");
                    b = Convert.ToDouble(Console.ReadLine());
                    vvod(a, b);
                }
                catch
                {
                    Console.WriteLine("Введены некоректные данные");
                }
                Console.WriteLine();
                Console.WriteLine("Задача 3:");
                double c;
                try
                {
                    Console.WriteLine("Введите число:");
                    c = Convert.ToDouble(Console.ReadLine());
                    vvod2(c);
                }
                catch
                {
                    Console.WriteLine("Введены некоректные данные");
                }
                Console.WriteLine();
                Console.WriteLine("Задача 5:");
                double v, d;
                try
                {
                    Console.WriteLine("Введите x:");
                    v = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y:");
                    d = Convert.ToDouble(Console.ReadLine());
                    vvod3(v, d);
                }
                catch
                {
                    Console.WriteLine("Введены некоректные данные");
                }
                Console.WriteLine();
                Console.WriteLine("Задача 6:");
                int l;
                try
                {
                    Console.WriteLine("Введите количество чисел Фибоначчи:");
                    l = Convert.ToInt32(Console.ReadLine());
                    Fibonachi(l);
                }
                catch
                {
                    Console.WriteLine("Введены некоректные данные");
                }
                Console.WriteLine();
                Console.WriteLine("Задача 7:");
                int n;
                try
                {
                    Console.WriteLine("Введите число n:");
                    n = Convert.ToInt32(Console.ReadLine());
                    vvod4(n);
                }
                catch
                {
                    Console.WriteLine("Введены некоректные данные");
                }
                Console.WriteLine();
                Console.WriteLine("Задача 8:");
                double nn, nnn, nnnn;
                try
                {
                    Console.WriteLine("Введите результат первого спортсмена:");
                    nn = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите результат второго спортсмена:");
                    nnn = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите результат третьего спортсмена:");
                    nnnn = Convert.ToDouble(Console.ReadLine());
                    vvod5(nn, nnn, nnnn);
                }
                catch
                {
                    Console.WriteLine("Введены некоректные данные");
                }


                char otv;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Хотите повторить выполнение программ? \nЕсли да, то нажмите на кнопку Y (на англ)\nЕсли нет, то нажмите на любую другую кнопку \nОтвет:");
                        otv = Convert.ToChar(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Введены некоректные данные");
                    }
                }
                if (!(otv.Equals('Y') || otv.Equals('y') || otv.Equals('н') || otv.Equals('Н')))
                {
                    Console.WriteLine("Программы выполнила студентка группы 41П\nЛебедева Александра Федоровна");
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }



            }

        
    }

}

