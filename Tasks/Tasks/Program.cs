using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // отмены действия 
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            //в  таск можно метод 
            //action
            Task task1 = new Task(() => Console.WriteLine("Задача в рабочем потоке"));
            task1.Start();
            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Задача в рабочем потоке"));

            cancellationTokenSource.Cancel();

            Task task3 = Task.Run(() =>
            {
                Console.WriteLine("Задача в рабочем потоке");
                if(cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("Запрос на отмену");
                }
            }
            );

            ////в  таск можно метод 
            ////action
            //Task task1 = new Task(() => Console.WriteLine("Задача в рабочем потоке"));
            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Задача в рабочем потоке"));
            //Task task3 = Task.Run(() => Console.WriteLine("Задача в рабочем потоке"));

            //func
            Task<string> task4 = Task.Run<string>(() => { return "2"; });

            //ознокомиться
            //TaskScheduler
        }
    }
}
