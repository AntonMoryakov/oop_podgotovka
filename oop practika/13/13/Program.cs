using System;
using System.Threading;

class Program
{
    private static readonly object _lockObject = new object();
    private static int _myVariable = 0;

    static void ModifyGlobalVariable()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(500); // имитация продолжительной работы
            lock (_lockObject)
            {
                Console.WriteLine($"{_myVariable}");
                _myVariable += 1;
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(ModifyGlobalVariable);
        Thread t2 = new Thread(ModifyGlobalVariable);
        Thread t3 = new Thread(ModifyGlobalVariable);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine($"Final value of _myVariable: {_myVariable}");
    }
}