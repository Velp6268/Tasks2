using System;
namespace Tasks2
{
    public class Metods
    {
        public int Task1(int speedHuman, int onComingNumber, int comingNumber)
        {
            int speedTram;
            int commonfactor = 20;

            speedTram = ((onComingNumber / commonfactor) + (comingNumber / commonfactor)) * speedHuman;

            PrintTask1(speedTram);
            return speedTram;
        }

        public void PrintTask1(int speed)
        {
            Console.WriteLine("Средняя скорость трамвая " + speed + "км/ч");
        }


    }
}

