using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Tasks2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            Tasks tasks = new Tasks();

            do
            {
                Console.Clear();


                Console.WriteLine("Введите номер задания: ");
                int numberTask = Convert.ToInt32(Console.ReadLine());
                switch (numberTask)
                {
                    case 1:
                        tasks.Task1();
                        break;
                    case 2:
                        Console.WriteLine("Задание 2");
                        Console.WriteLine("1 вариант - а) с предоставленными данными \n" + "2 вариант - б) с данными, введеными с клавиатуры");
                        Console.WriteLine("Введите вариант который хотите выбрать: ");
                        int numberVariant = Convert.ToInt32(Console.ReadLine());
                        switch (numberVariant)
                        {
                            case 1:
                                tasks.Task2Variant1();
                                break;

                            case 2:
                                tasks.Task2Variant2();
                                break;

                        }
                        break;
                }

                Console.WriteLine("\nЧто бы закончить, нажмите клавишу 'q', если хотите продолжить нажмите любую клавишу. ");
                cki = Console.ReadKey(true);

            } while (cki.Key != ConsoleKey.Q);

        }
    }
}

