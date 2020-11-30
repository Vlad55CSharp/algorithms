using System;

namespace CSharpString1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1; //объевили переменную типа string
            str1 = "Привет";//присвоили строке значение
            //объявили и создали строку из двух символов 'a'
            string str2 = new String('a', 2);
            //объявили и создали строку из массива символов
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string helloString = new string(letters);
            //объявиили и создали пустую строку
            string emptyStr = string.Empty;
            string nullStr = null;

            //использование регулярного литерала
            string path = "c:\\Program Files\\dotnet\\dotnet.exe";
            //использование буквального литерала
            string path2 = @"c:\Program Files\dotnet\dotnet.exe";

            Console.WriteLine("Форматирование таблицы");
            //выводим в консоль таблицу 3х3
            Console.WriteLine("Номер\tЗначение\tОписание");
            Console.WriteLine("1\t0,1\t\tописание 1");
            Console.WriteLine("2\t0,2\t\tописание 2");
            Console.WriteLine("3\t0,3\t\tописание 3");
            
         //   Console.WriteLine("Строка с буквальным литералом");
            //использование буквального литерала
            string str = @"Эта строка содержит символ \ , а также одинарные кавычки 'текст в кавычках' 
                           и переносы строки
                           ";

            string str4; //объявили переменную
            str4 = "hello"; //выделили память под 5 символов и присвоили значение переменной
            str4 = "hello world";//освободили память, по новой выделили память уже под 11 символов и присвоили новое значение

            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";

            Console.WriteLine(s2);

         //   Console.WriteLine(str);
            //  Console.WriteLine(str2);
            //  Console.WriteLine(helloString);
            //  Console.WriteLine(emptyStr);
            //  Console.WriteLine(nullStr);
        }
    }
}
