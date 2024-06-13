using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exzoop12
{
    //class Program
    //{
    //    static void LongWork()
    //    {
    //        Thread.Sleep(3000);
    //    }

    //    static void Main(string[] args)
    //    {
    //        DateTime start = DateTime.Now;

    //        int count = 0;
    //        while ((DateTime.Now - start).TotalSeconds < 4 && count < 3)
    //        {
    //            LongWork();
    //            Console.WriteLine($"Проход номер: {count+1} ");
    //            count++;
    //        }

    //        Console.WriteLine($"Время работы: {(DateTime.Now - start).TotalSeconds} секунд");
    //        Console.ReadKey();
    //    }
    //}
    class Program
    {
        static async Task LongWorkAsync()
        {
            await Task.Delay(3000);
        }

        static async Task Main(string[] args)
        {
            DateTime start = DateTime.Now;

            int count = 0;
            while ((DateTime.Now - start).TotalSeconds < 4 && count < 3)
            {
                Task task = LongWorkAsync();
                await Task.WhenAny(task, Task.Delay(TimeSpan.FromSeconds(4 - (DateTime.Now - start).TotalSeconds)));
                if (task.Status == TaskStatus.RanToCompletion)
                {
                    Console.WriteLine($"Task #{count + 1} completed in {(DateTime.Now - start).TotalSeconds} seconds");
                }
                else
                {
                    Console.WriteLine($"Task #{count + 1} timed out after {(DateTime.Now - start).TotalSeconds} seconds");
                }
                count++;
            }

            Console.WriteLine($"Total time elapsed: {(DateTime.Now - start).TotalSeconds} seconds");
            Console.ReadKey();
        }
    }
}
