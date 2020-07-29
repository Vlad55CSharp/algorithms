using System;

namespace InsertionSort
{
    class Program
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        

        static void InsertionSort(int[] inArray)
        {
            int x;
            int j;
            for (int i = 1; i < inArray.Length; i++)
            {
                x = inArray[i];
                j = i;
                while (j > 0 && inArray[j - 1] > x)
                {
                    Swap(inArray, j, j - 1);
                    j -= 1;
                }
                inArray[j] = x;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
            string[] nums = Console.ReadLine().Split(new char[] { ',' });
            int[] intArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                intArray[i] = int.Parse(nums[i]);
            }

            InsertionSort(intArray);

            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
