using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new Building();
            

            

            Console.WriteLine($"Объем дома {house.Volume}");
            Console.WriteLine($"Количество окон {house.WindowCount}");
            Console.WriteLine($"Порядковый номер {House.GetOrdNumber()}");
            Console.WriteLine($"{house.ToString()}");
        }
    }
}
