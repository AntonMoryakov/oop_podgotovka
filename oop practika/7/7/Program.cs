using System;

// Объявление делегатов
delegate void MyDelegate1(int i, string s, bool b);
delegate int MyDelegate2(int[] arr, double d);

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов делегатов и сохранение ссылок на методы
        MyDelegate1 del1 = new MyDelegate1(MyMethod1);
        MyDelegate2 del2 = new MyDelegate2(MyMethod2);

        // Вызов методов через делегаты
        del1(42, "Hello, world!", true);
        int result = del2(new int[] { 1, 2, 3 }, 3.14);
        Console.WriteLine("Result: " + result);
    }

    // Реализация методов, подходящих под сигнатуры делегатов
    static void MyMethod1(int i, string s, bool b)
    {
        Console.WriteLine("MyMethod1: i = " + i + ", s = " + s + ", b = " + b);
    }

    static int MyMethod2(int[] arr, double d)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return (int)(sum * d);
    }
}