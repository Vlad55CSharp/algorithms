using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class Building
    {
        public double width;
        public double length;
        public double height;

        //Конструктор
        public Building(double width, double length, double height = 3)
        {
            this.width = width;
            this.length = length;
            this.height = height;
        }

        public Building(): this(20, 20, 3)
        { 
        
        }

        //метод
        public double GetVolume()
        {
            return width * length * height;
        }
    }
}
