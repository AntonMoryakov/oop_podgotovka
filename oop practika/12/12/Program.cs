using System;
using System.Threading.Tasks;

class Program
{
    static async Task LongRunningMethod()
    {
        Console.WriteLine($"Started long running method at {DateTime.Now.TimeOfDay}");
        await Task.Delay(3000);
        Console.WriteLine($"Finished long running method at {DateTime.Now.TimeOfDay}");
    }

    static async Task Main()
    {
        Console.WriteLine($"Started main method at {DateTime.Now.TimeOfDay}");

        var task1 = LongRunningMethod();
        var task2 = LongRunningMethod();
        var task3 = LongRunningMethod();

        await Task.WhenAny(task1, task2, task3);
        await Task.WhenAny(task1, task2, task3);
        await Task.WhenAny(task1, task2, task3);

        Console.WriteLine($"Finished main method at {DateTime.Now.TimeOfDay}");
    }
}