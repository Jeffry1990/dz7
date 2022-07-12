using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int grandmother;
            int time = 10;
            int hour;
            int minutes;
            int timeWait;
            
            Console.Write("Введите кол-во старушек: ");
            grandmother = Convert.ToInt32(Console.ReadLine());

            timeWait = grandmother * time;
            hour = timeWait / 60;
            minutes = timeWait % 60;

            Console.WriteLine("Вы должны отстоять в очереди " + hour + " часа и " + minutes + " минут.");
        }
    }
}
