using System;
namespace Tasks2
{
    public class Tasks
    {
        Metods metods = new Metods();

        public void Task1()
        {
            Console.WriteLine("Задание 1: Человек шел со скоростью 3 км/ч вдоль трамвайной линии и считал трамваи. И те, которые двигались ему на встречу, и те, " +
                         "которые обгоняли его. Человек насчитал 40 трамваев, обгонявших его, и 60 встречных. Предположим, что трамваи движутся равномерно, " +
                         "с одинаковыми интервалами между собой (в задаче это вполне возможно). Какова средняя скорость движения трамваев?");
            Console.WriteLine();
            int speedHuman = 3;
            int comingTramsNumber = 40;
            int onComingTramsNumber = 60;

            Console.WriteLine("Скорость человека: " + speedHuman + "км/ч");
            Console.WriteLine("Двигались на встречу человеку " + comingTramsNumber + " трамваев");
            Console.WriteLine("Обгонявших человека " + onComingTramsNumber + " трамваев");

            Console.Write("Ответ: ");
            metods.Task1(speedHuman, comingTramsNumber, onComingTramsNumber);

        }

        public void Task2Variant1()
        {
            int n = 7;
            double t_a = 0, t_b = 0, S = 0, p = 0;

            Variable[] a = new Variable[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new Variable();
            }

            Sort_RankXY ob = new Sort_RankXY();

            a[0].x = 123;
            a[1].x = 142;
            a[2].x = 125;
            a[3].x = 154;
            a[4].x = 133;
            a[5].x = 119;
            a[6].x = 148;

            a[0].y = 134;
            a[1].y = 142;
            a[2].y = 163;
            a[3].y = 127;
            a[4].y = 142;
            a[5].y = 155;
            a[6].y = 120;

            Console.WriteLine("Предоставленные данные X и Y: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].x + "   " + a[i].y);
            }
            Console.WriteLine();

            ob.QuickX(0, n - 1, ref a);
            ob.RankX(n - 1, ref t_a, ref a);
            ob.QuickY(0, n - 1, ref a);
            ob.RankY(n - 1, ref t_b, ref a);

            Console.WriteLine("Переформированные ранги X и Y: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].rx + "   " + a[i].ry);
            }

            Console.WriteLine("Матрица рангов: ");
            for (int i = 0; i < n; i++)
            {
                a[i].dr = Math.Pow(a[i].rx - a[i].ry, 2); Console.WriteLine("{0:f4}", a[i].dr);
                S = S + a[i].dr;
            }
            Console.WriteLine("Находим сумму разности квадратов X и Y ((dx-dy)^2), после складываем полученные результаты, и получаем, то что,");
            Console.WriteLine("S=" + S);

            Console.WriteLine("Затем вычесляем кф Спирмена");
            p = 1 - 6 * (S + t_a + t_b) / (n * (n * n - 1));
            Console.WriteLine("p = {0:f10}", p);
        }

        public void Task2Variant2()
        {
            int n;
            double t_a = 0, t_b = 0, S = 0, p = 0;

            Console.WriteLine("Количесво строк: ");
            n = Convert.ToInt32(Console.ReadLine());

            Variable[] a = new Variable[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = new Variable();
            }

            Sort_RankXY ob = new Sort_RankXY();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите x[" + (i + 1) + "] = ");
                a[i].x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y[" + (i + 1) + "] = ");
                a[i].y = Convert.ToDouble(Console.ReadLine());
            }
            ob.QuickX(0, n - 1, ref a);
            ob.RankX(n - 1, ref t_a, ref a);
            ob.QuickY(0, n - 1, ref a);
            ob.RankY(n - 1, ref t_b, ref a);

            Console.WriteLine("Переформированные ранги X и Y: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i].rx + "   " + a[i].ry);
            }

            Console.WriteLine("Матрица рангов: ");
            for (int i = 0; i < n; i++)
            {
                a[i].dr = Math.Pow(a[i].rx - a[i].ry, 2); Console.WriteLine("{0:f4}", a[i].dr);
                S = S + a[i].dr;
            }
            Console.WriteLine("Находим сумму разности квадратов X и Y ((dx-dy)^2), после складываем полученные результаты, и получаем, то что,");
            Console.WriteLine("S=" + S);

            Console.WriteLine("Затем вычесляем кф Спирмена");
            p = 1 - 6 * (S + t_a + t_b) / (n * (n * n - 1));
            Console.WriteLine("p = {0:f10}", p);
        }

    }
}

