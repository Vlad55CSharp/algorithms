using System;

namespace SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую целые числа и нажмите Enter");
            string[] nums = Console.ReadLine().Split(new char[] { ',' });
            int[] intArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                intArray[i] = int.Parse(nums[i]);
            }

            Console.WriteLine("Неотсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }

            int indx; //переменная для хранения индекса минимального элемента массива
            for (int i = 0; i < intArray.Length; i++) //проходим по массиву с начала и до конца
            {
                indx = i; //считаем, что минимальный элемент имеет текущий индекс 
                for (int j = i; j < intArray.Length; j++) //ищем минимальный элемент в неотсортированной части
                {
                    if (intArray[j] < intArray[indx])
                    {
                        indx = j; //нашли в массиве число меньше, чем intArray[indx] - запоминаем его индекс в массиве
                    }
                }

                if (intArray[indx] == intArray[i]) //если минимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами минимальный элемент и первый в неотсортированной части
                int temp = intArray[i]; //временная переменная, чтобы не потерять значение intArray[i]
                intArray[i] = intArray[indx];
                intArray[indx] = temp;
            }


            Console.WriteLine("\r\nОтсортированный массив:");
            foreach (int value in intArray)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
