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


            Building building = new House 
            {
                Height = 5,
                Length = 15,
                Width = 20,
                WindowCount = 5
            };

            ((House)building).WindowCount = 3;

            Object newBuilding = new House();
            ((House)newBuilding).WindowCount = 3;

            Console.WriteLine($"Объем дома {house.Volume}");
            Console.WriteLine($"Количество окон {house.WindowCount}");
            Console.WriteLine($"Порядковый номер {House.GetOrdNumber()}");
            Console.WriteLine($"{house}");
        }
    }
}
