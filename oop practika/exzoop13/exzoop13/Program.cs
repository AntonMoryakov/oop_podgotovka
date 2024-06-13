using System;
using System.Threading;

namespace exzoop13
{
    class Program
    {
        static int myVariable = 0;
        static object locker = new object();

        static void ModifyGlobalVariable()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500); // имитация продолжительной работы
                lock (locker)
                {
                    Console.WriteLine($"{myVariable}");
                    myVariable += 1;
                }
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(ModifyGlobalVariable));
            Thread t2 = new Thread(new ThreadStart(ModifyGlobalVariable));
            Thread t3 = new Thread(new ThreadStart(ModifyGlobalVariable));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine($"Final value of the global variable: {myVariable}");
            Console.ReadKey();
        }
    }
}
