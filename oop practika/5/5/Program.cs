using System;

class MyClass<T>
{
    public void PrintType()
    {
        Console.WriteLine($"Тип данных: {typeof(T).Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass<int> myIntObj = new MyClass<int>();
        myIntObj.PrintType();

        MyClass<string> myStringObj = new MyClass<string>();
        myStringObj.PrintType();

        Console.ReadKey();
    }
}