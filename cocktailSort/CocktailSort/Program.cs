using System;

namespace CocktailSort
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
        
        static void CocktailSort(int[] inArray)
        {
            int left = 0,
                 right = inArray.Length - 1;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                   if (inArray[i] > inArray[i + 1])
                        Swap(inArray, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                   if (inArray[i - 1] > inArray[i])
                        Swap(inArray, i - 1, i);
                }
                left++;
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

            CocktailSort(intArray);

            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
