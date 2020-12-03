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
            bool yes = false;

            Console.WriteLine("Введите количестово элементов последовательности (N) и нажмите Enter");
            n = byte.Parse(Console.ReadLine());
            Console.WriteLine("Введите последнее число из ряда (1..M) и нажмите Enter");
            m = byte.Parse(Console.ReadLine());

            Sequence = new byte[n];

            void Next(byte[] sequence, bool yes)
            {
                int i = n;
                while ((i > 0) && (sequence[i] == m))
                {
                    sequence[i] = 1;
                    i--;
                }
                yes = i > 0;

                if (yes)
                {
                    sequence[i]++; 
                }
            }

            for (int i = 1; i <= n; i++)
            {
                Sequence[i] = 1;
            }

            do
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(Sequence[i]);
                }
                Console.WriteLine();
                Next(Sequence, yes);
            }
            while (yes);

        }
    }
}
