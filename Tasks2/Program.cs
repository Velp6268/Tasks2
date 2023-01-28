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
                        tasks.Task2Variant();
                        break;
                }

                Console.WriteLine("\nЧто бы закончить, нажмите клавишу 'q', если хотите продолжить нажмите любую клавишу. ");
                cki = Console.ReadKey(true);

            } while (cki.Key != ConsoleKey.Q);

        }
    }
}

