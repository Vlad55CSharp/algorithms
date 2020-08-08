using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskApp
{
    class Program
    {
        public static void LongAction()
        {
            Thread.Sleep(3000);
            Console.WriteLine("LongAction");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start Main()");
            
            Task task = Task.Run(LongAction);
            task.Wait(500); //ждем, пока задача не будет полностью выполнена  

            if (task.Status == TaskStatus.Running)
                Console.WriteLine("LongAction ещё выполняется");

            Console.WriteLine("LongAction выпонена, запускаемостальные задачи");
            Task task2 = Task.Run(() => Console.WriteLine($"task2  Task={Task.CurrentId}, Thread={Thread.CurrentThread.ManagedThreadId}"));
            Task task3 = Task.Run(() => Console.WriteLine($"task3  Task={Task.CurrentId}, Thread={Thread.CurrentThread.ManagedThreadId}"));
            Task task4 = Task.Run(() => Console.WriteLine($"task4  Task={Task.CurrentId}, Thread={Thread.CurrentThread.ManagedThreadId}"));
            
            Console.WriteLine("End Main()");
            Console.ReadLine();
        }
    }
}
