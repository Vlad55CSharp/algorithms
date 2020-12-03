using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class Building
    {
        private double width;
        private double length;
        

        static int ordNumber;

        //статический конструктор
        static Building()
        {
            ordNumber = 0;
        }

        static public int GetOrdNumber()
        {
            return ordNumber;
        }
        

        public Building()
        {
            width = 10;
            length = 10;
            height = 2;
            ordNumber++;
        }

        //метод
        private double GetVolume()
        {
            return width * length * height;
        }

        //Свойства
        private double height;
        public double Height
        {
            get => height;
            set => height = value > 0 ? value : throw new Exception("Высота здания не может быть менее 0 метров");
        }

        public double Width
        {
            get => width;
            set => width = value > 0 ? value : throw new Exception("Ширина здания не может быть менее 0 метров");
        }

        public double Length
        {
            get => length;
            set => length = value > 0 ? value : throw new Exception("Длина здания не может быть менее 0 метров");
        }

        public string Name { get; set; } = "Неизвестное здание";

        public double Volume => GetVolume();

        public void ExpandSize(int width, int length, int height)
        {
            Width += width;
            Length += length;
            Height += height;
        }
        
        //перегруженный метод
        public void ExpandSize(double width, double length, double height)
        {
            Width += width;
            Length += length;
            Height += height;
        }

        //перегруженный метод
        public void ExpandSize(double width, double length)
        {
            Width += width;
            Length += length;
        }

    }
}
