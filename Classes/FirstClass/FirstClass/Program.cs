using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем объект с параметрами width = 20, length = 20, height = 3 и используем инициализатор
            Building building = new Building { width = 40, length = 30, height = 5 };
            //создаем объект с параметрами width = 20, length = 20, height = 3
            Building building2 = new Building();
            Console.WriteLine($"Объем первого здания: {building.GetVolume()}");
            Console.WriteLine($"Объем второго здания: {building2.GetVolume()}");
        }
    }
}
