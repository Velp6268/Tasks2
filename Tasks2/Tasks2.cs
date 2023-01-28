using System;
using System.Threading.Tasks;

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



        public void Task2Variant()
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine("1 вариант - а) с предоставленными данными \n" + "2 вариант - б) с данными, введеными с клавиатуры");
            Console.WriteLine("Введите вариант который хотите выбрать: ");
            int numberVariant = Convert.ToInt32(Console.ReadLine());
            double resultSpearman = 0;
            int[] arrX = new int [7];
            int[] arrY = new int [7];
            int[] arrXRank = new int[7];
            int[] arrYRank = new int[7];

            switch (numberVariant)
            {
                case 1:
                    arrX = new int [] { 123, 142, 125, 154, 133, 119, 148 };
                    arrY = new int [] { 134, 142, 163, 127, 142, 155, 120 };
                    break; 
                case 2:        
                    Console.WriteLine("Введите кол-во строк");
                    int n = Convert.ToInt32(Console.ReadLine());
                    arrX = new int[n];
                    arrY = new int[n];
                    Console.WriteLine("Введите");

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Введите X[" + (i + 1) + "] = ");
                        arrX[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите Y[" + (i + 1) + "] = ");
                        arrY[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    arrXRank = new int[n];
                    arrYRank = new int[n];
                    break;
            }

            arrXRank = SortRank(arrX, arrXRank);
            arrYRank = SortRank(arrY, arrYRank);

            resultSpearman = CalculationSperman(arrXRank, arrYRank);

            Console.WriteLine("P = " + resultSpearman);
        }

        public int[] SortRank(int[] arr, int[] resultArr)
        {
            int maxValue = int.MaxValue;
            int count = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > temp && arr[j] < maxValue)
                    {
                        temp = arr[j];
                    }
                }
                for (int k = 0; k < arr.Length; k++)
                {
                    maxValue = temp;
                    if (arr[k] == maxValue)
                    {
                        resultArr[k] = count;
                        count++;
                    }
                }
                
            }
            return resultArr;
        }

        public double CalculationSperman(int[] arrX, int[] arrY)
        {

            double coefficientS = 0;
            double coefficientP = 0;

            for (int i = 0; i < arrX.Length; i++)
            {
                coefficientS += Math.Pow((arrX[i] - arrY[i]), 2);
            }

            coefficientP = 1 - ((6 * coefficientS) / (Math.Pow(arrX.Length, 3) - arrX.Length));

            return coefficientP;
        }
    }
}

