using System;
namespace Tasks2
{
    public class Metods
    {
        public int Task1(int speedHuman, int onComingNumber, int comingNumber)
        {
            int speedTram;
            int commonfactor = 20; //общий кф 

            speedTram = ((onComingNumber / commonfactor) + (comingNumber / commonfactor)) * speedHuman; //вычесление ср. скорости трамвая

            PrintTask1(speedTram);
            return speedTram;
        }

        public void PrintTask1(int speed)//Метод отвечающий за вывод результата на консоль (просто захотел сделать)
        {
            Console.WriteLine("Средняя скорость трамвая " + speed + "км/ч");
        }
    }
}

