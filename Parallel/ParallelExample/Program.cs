using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParallelExample
{
    class Program
    {

        static void Factorial(int x)
        {
            Console.WriteLine($"Запускаем расчёт факториала числа {x}. CurrentId = {Task.CurrentId}");
            int result = 1;
            for (int i = 1; i <= x; i++)
                result *= i;
            Console.WriteLine($"Расчёт факториала выполнен. Резульат {result}");
        }

        static void Prime(int x)
        {
            Console.WriteLine($"Запускаем расчёт простых чисел от 2 до {x}. CurrentId = {Task.CurrentId}");
            int total = 0;
            for (int i = 2; i <= x; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    total++;
            }
            Console.WriteLine($"Расчёт простых чисел выполнен. Найдено {total} чисел");
        }

        static public void IsPrime (int x, ParallelLoopState parallelLoopState)
            {
               bool isPrime = true;
               for (int i = 2; i < x; i++)
               {
                if (x % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"Первое найденное простое число {x}");
                parallelLoopState.Break();
            }
                
        }
        
        static void Main(string[] args)
        {


            Parallel.Invoke(() => Factorial(10), //первая задача
                            () => Prime(5000),   //вторая задача
                            () => Console.WriteLine("Просто выводим строку на экран") //третья задача
                            );
            Console.ReadLine();

        //    Console.WriteLine("Start Parallel.For");
        //    Parallel.For(2, 5001, IsPrime);
        //    Console.WriteLine("End Parallel.For");


            ParallelLoopResult res = Parallel.ForEach<int>(new List<int> { 10, 12, 2, 3, 4, 5, 6, 7, 89, 198 }, IsPrime);
            if (res.IsCompleted)
                Console.WriteLine("Цикл выполнен полностью");
            Console.WriteLine($"Номер итерации на которой сработал break - {res.LowestBreakIteration}");
            
        }
    }
}
