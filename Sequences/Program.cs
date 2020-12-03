using System;

namespace Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            byte m;
            byte n;
            byte[] Sequence;
            int counter = 1;

            Console.WriteLine("Введите количестово элементов последовательности (N) и нажмите Enter");
            n = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число из ряда (1..M) и нажмите Enter");
            m = byte.Parse(Console.ReadLine());

            Sequence = new byte[n]; //массив в котором будет храниться очередная последовательность

            bool yes;
           
            void Next(byte[] sequence)
            {
                int i = n - 1;
                while ((i > -1) && (sequence[i] == m))
                {
                    sequence[i] = 1;
                    i--;
                }
                yes = i > -1;
                //если очередной элемент в последовательности можно нарастить
                if (yes)
                {
                    sequence[i]++;
                }
            }

            //задаем первую последовательность, например, (1,1,1,1)
            for (int i = 0; i < n; i++)
            {
                Sequence[i] = 1;
            }

            //пробуем перебрать все последовательности
            do
            {
                //выводим счётчик очередной последовательности (стартуем с 1)
                Console.Write($"{counter}: ");
                counter++;
                //выводим на экран очередную последовательность
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{Sequence[i]} ");
                }
                Console.WriteLine();
                //пробуем найти следующую последовательность
                Next(Sequence);
            }
            while (yes);

        }
    }
}
