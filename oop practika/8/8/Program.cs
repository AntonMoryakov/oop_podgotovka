using System;

// Определение интерфейса
interface IMyInterface
{
    void Method1();
    void Method2(string s);
    int Method3(int a, int b);
}

// Реализация интерфейса в классе MyClass
class MyClass : IMyInterface
{
    public void Method1()
    {
        Console.WriteLine("Method1 called");
    }

    public void Method2(string s)
    {
        Console.WriteLine("Method2 called with argument: " + s);
    }

    public int Method3(int a, int b)
    {
        Console.WriteLine("Method3 called with arguments: " + a + ", " + b);
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта класса MyClass
        MyClass obj = new MyClass();

        // Использование интерфейсной ссылки для вызова методов
        IMyInterface objInterface = obj;
        objInterface.Method1();
        objInterface.Method2("Hello, world!");
        int result = objInterface.Method3(2, 3);
        Console.WriteLine("Result: " + result);
    }
}