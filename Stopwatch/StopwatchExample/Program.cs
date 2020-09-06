using System;
using System.Diagnostics;

namespace StopwatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTimerProperties();
            Stopwatch stopwatch = Stopwatch.StartNew();//создаем и запускаем таймер
            for (int i = 0; i < 100; i++) 
            { 
                Console.WriteLine(i);
            }
            //останавливаем счётчик 
            stopwatch.Stop(); //смотрим сколько миллисекунд было затрачено на выполнение 
            Console.WriteLine($"Первая операция {stopwatch.ElapsedMilliseconds}");
            
            stopwatch.Restart(); //перезапускаем счётчик
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i*i);
            }
            stopwatch.Stop(); //смотрим сколько миллисекунд было затрачено на выполнение 
            Console.WriteLine($"Вторая операция {stopwatch.ElapsedMilliseconds}");
        }

        public static void DisplayTimerProperties()
        {
            if (Stopwatch.IsHighResolution)
            {
                Console.WriteLine("Операции рассчитываются с использованием системного счетчика производительности с высоким разрешением.");
            }
            else
            {
                Console.WriteLine("Операции рассчитываются с использованием класса DateTime.");
            }

            long frequency = Stopwatch.Frequency;
            Console.WriteLine($"  Частота таймера = {frequency}");
            long nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
            Console.WriteLine($"  Таймер работает с точностью до {nanosecPerTick} наносекунд");
        }
    }

}
