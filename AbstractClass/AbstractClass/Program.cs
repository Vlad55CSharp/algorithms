using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student("Вася", "Пупкин", "ГВН-105");
            string res = student.Display();
            Console.WriteLine(res);
        }
    }
}
