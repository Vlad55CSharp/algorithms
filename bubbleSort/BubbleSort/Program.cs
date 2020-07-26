using System;

namespace BubbleSort
{
    class Program
    {
        static void BubbleSort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] > inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
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

            BubbleSort(intArray);

            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
