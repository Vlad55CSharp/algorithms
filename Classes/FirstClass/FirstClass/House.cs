using System;

namespace FirstClass
{
    class House: Building
    {
        private int windowCount;
        public int WindowCount
        {
            get => windowCount;
            set => windowCount = value > 0 ? value : throw new Exception("Количество окон не может быть меньше нуля");
        }

        public override string ToString()
        {
            return $"Ширина {Width} Длина {Length} Высота {Height} Количество окон {WindowCount}";
        }
    }

}
