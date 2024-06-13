using System;

// Определение делегата
delegate void MyEventHandler(int arg);

// Класс, содержащий событие
class MyClass
{
    // Событие
    public event MyEventHandler MyEvent;

    // Метод, вызывающий событие
    public void RaiseEvent(int arg)
    {
        Console.WriteLine("Event raised with argument: " + arg);
        MyEvent?.Invoke(arg);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта класса MyClass
        MyClass obj = new MyClass();

        // Создание метода, подходящего по сигнатуре делегата
        void MyMethod(int arg)
        {
            Console.WriteLine("MyMethod called with argument: " + arg);
        }

        // Подписка на событие и вывод информации
        obj.MyEvent += MyMethod;
        Console.WriteLine("MyMethod subscribed to MyEvent");

        // Вызов события
        obj.RaiseEvent(42);

        // Отписка от события и вывод информации
        obj.MyEvent -= MyMethod;
        Console.WriteLine("MyMethod unsubscribed from MyEvent");

        // Вызов события
        obj.RaiseEvent(84);
    }
}