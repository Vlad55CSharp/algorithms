using System;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число (N) от 1 до 255");
            byte n = byte.Parse(Console.ReadLine());
            
            byte[] x = new byte[n];


            void Swap(byte a, byte b)
            {
                byte c;
                c = a;
                a = b;
                b = c;
            }

            void Permutation(byte[] perm, bool yes)
            { 
                int i = n - 2;
                int j;
                while ((i > -1) && perm[i - 1] > perm[i])
                {
                    i--;
                }
                if (i > 0)
                {
                    j = i+1;
                    while ((j < n - 1) && (perm[j] > perm[i - 1]))
                    {
                        j++;
                    }
                    Swap(perm[i], perm[j]);
                    for (int k = i; k <= (n + i) / 2; k++)
                    {
                        Swap(perm[k], perm[n - k + i]);
                    }
                }
                else
                    yes = false;
            }

            bool y = false;
            for (byte m = 0; m <= n-1; m++)
            {
                x[m] = m;
            }

            do
            {
                for (int i = 0; i <= n-1; i++)
                {
                    Console.Write(x[i]);
                }
                Console.WriteLine();
                Permutation(x, y);
            }
                while (!y);

        }
    }
}
