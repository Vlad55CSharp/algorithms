using System;

namespace GnomeSort
{
    class Program
    {
        //перестановка местами двух элементов в массиве
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static void GnomeSort(int[] inArray)
        {
            int i = 1;
            int j = 2;
            while (i < inArray.Length)
            {
                if (inArray[i - 1] < inArray[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(inArray, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
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

            GnomeSort(intArray);

            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
