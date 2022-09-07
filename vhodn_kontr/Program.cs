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
                Console.WriteLine("Число дает одинаковый остаток");
            }
            else
            {
                Console.WriteLine("Число дает не одинаковый остаток");
            }


        }

        static void vvod3(double v, double d)
        {
            double c = 1 + Math.Sin(Math.Sqrt(v+1));
            
            


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

                char otv;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Хотите повторить выполнение программ? \nЕсли да, то нажмите на кнопку Y (на англ)\n Если нет, то нажмите на любую другую кнопку \nОтвет:");
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

