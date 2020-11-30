using System;
using System.Globalization;


namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Ivan",  Family = "Ianov", Age = 25};
            Console.WriteLine("Имя {0}\n\rФамилия {1}\n\rВозраст {2}", person.Name, person.Family, person.Age);

            Console.WriteLine("Форматирование валюты");
            double number = 25.9;
            string str = string.Format("{0:C2}", number); //25.90
            string str2 = string.Format("{0:C1}", number); //25.9
            string str3 = string.Format(CultureInfo.CreateSpecificCulture("US-us"), "{0:C1}", number); //$25.9
            Console.WriteLine(str);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            Console.WriteLine("Форматирование целых чисел");
            int intNumber = 23;
            str = string.Format("{0:d}",intNumber);//23
            Console.WriteLine(str);
            str = string.Format("{0:d4}", intNumber);//0023
            Console.WriteLine(str);

            Console.WriteLine("Форматирование дробных чисел");
            double dNumber = 12.4567;
            str = string.Format("{0:E}", dNumber);//1,245670E+001
            Console.WriteLine(str);
            str = string.Format("{0:E2}", dNumber);//1,25E+001
            Console.WriteLine(str);

            str = string.Format("{0:F}", dNumber);//12,46
            Console.WriteLine(str);
            str = string.Format("{0:F3}", dNumber);//12,457
            Console.WriteLine(str);

            str = string.Format("{0:G}", dNumber);//12,4567
            Console.WriteLine(str);
            str = string.Format("{0:G1}", dNumber);//1E+01
            Console.WriteLine(str);

            Console.WriteLine("Форматирование процентов");
            double percent = 0.44231;
            str = string.Format("{0:P}", percent);//44,23%
            Console.WriteLine(str);
            str = string.Format("{0:P1}", percent);//44,2%
            Console.WriteLine(str);

            Console.WriteLine("Настраиваемый формат строк");
            long phone = 79118844578;
            str = string.Format("{0:+#(###)###-##-##}", phone);//+7(911)884-45-78
            Console.WriteLine(str);

            Console.WriteLine("Интерполяция строк в C#");
            Person person2 = new Person { Name = "Ivan", Family = "Ianov", Age = 25 };
            Console.WriteLine($"Имя {person2.Name} Фамилия {person2.Family} Возраст {person2.Age}");
            Person person3 = null;
            Console.WriteLine($"Имя {person3?.Name ?? "Имя по умолчанию - Вася"}");

            double x = 12.23;
            double y = 15.37;
            Console.WriteLine($"{x} + {y} ={x + y}");

            long phone2 = 79118844578;
            string result = $"{phone2:+#-(###)-###-##-##}";
            Console.WriteLine(result);

            Console.WriteLine("Выравнивание");
            Console.WriteLine($"Имя: {person.Name,-5} Возраст: {person.Age,-3}"); // вставляем пробелы после
            Console.WriteLine($"Имя: {person.Name,5} Возраст: {person.Age,3}"); // вставляем пробелы до
        }
    }

    class Person 
    { 
      public string Name { get; set; }
      public string Family { get; set; }
      public byte Age { get; set; }
    }
}
