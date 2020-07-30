using System;

namespace Tuples
{

    class Program
    {

        enum Method 
        { 
           Select,
           Bubble,
           Insertion
        }

        static void SortArray(string[] input, Method method)
        {
            int[] array = GetArray(input);

            Console.WriteLine("\r\nНесортированный массив:");
            PrintArray(array);

            (int Count, int Permutations) Result;
            
            switch (method)
            {

                case Method.Select: 
                    {
                        Result = SelectSort(array);
                        Console.Write($"\r\nСортировка выбором: итераций цикла {Result.Count}; Перестановок {Result.Permutations}");
                        break; 
                    }
                case Method.Bubble: 
                    {
                        Result = BubbleSort(array);
                        Console.Write($"\r\nСортировка пузырьком: итераций цикла {Result.Count}; Перестановок {Result.Permutations}");
                        break; 
                    }
                case Method.Insertion: 
                    {
                        Result = InsertionSort(array);
                        Console.Write($"\r\nСортировка вставками: итераций цикла {Result.Count}; Перестановок {Result.Permutations}");
                        break; 
                    }
            }
            Console.Write("\r\nОтсортированный массив:");
            PrintArray(array);
        }


        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void PrintArray(int[] array)
        {
            foreach (int value in array)
            {
                Console.Write($"{value} ");
            }
        }

        static (int, int) SelectSort(int[] array)
        {
            int indx; 
            int count = 0; //общее количество итераций цикла
            int permut = 0;//количество перестановок
            for (int i = 0; i < array.Length; i++) 
            {
                indx = i; 
                count++; 
                for (int j = i; j < array.Length; j++) 
                {
                    if (array[j] < array[indx])
                    {
                        indx = j; 
                    }
                    count++;
                }

                if (array[indx] == array[i]) 
                    continue;
                Swap(array, i, indx);
                permut++;
            }
            return (count, permut);
        }


        static (int, int) BubbleSort(int[] array)
        {
            int count = 0;
            int permut = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j+1);
                        permut++;
                    }
                    count++;
                }
            }
            return (count, permut);
        }


        static (int, int) InsertionSort(int[] inArray)
        {
            int x;
            int j;
            int count = 0;
            int permut = 0;
            for (int i = 1; i < inArray.Length; i++)
            {
                x = inArray[i];
                j = i;
                count++;
                while (j > 0 && inArray[j - 1] > x)
                {
                    Swap(inArray, j, j - 1);
                    j -= 1;
                    count++;
                    permut++;
                }
                inArray[j] = x;
            }
            return (count, permut);
        }

        static int[] GetArray(string[] strArray)
        {
            int[] intArray = new int[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                intArray[i] = int.Parse(strArray[i]);
            }
            return intArray;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
            string[] nums = Console.ReadLine().Split(new char[] { ',' });

            SortArray(nums, Method.Select);
            SortArray(nums, Method.Bubble);
            SortArray(nums, Method.Insertion);



        }
    }
}
