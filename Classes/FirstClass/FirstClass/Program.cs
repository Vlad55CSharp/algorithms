using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House
            {
                Height = 5,
                Length = 15,
                Width = 20,
                WindowCount = 5
            };
            Console.WriteLine($"Объем дома {house.Volume}");
            Console.WriteLine($"Количество окон {house.WindowCount}");
            Console.WriteLine($"Порядковый номер {House.GetOrdNumber()}");
            Console.WriteLine($"{house}");
        }
    }
}
