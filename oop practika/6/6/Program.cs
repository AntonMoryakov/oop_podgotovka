using System;

// Объявление класса, использующего обобщенный тип данных
public class MyClass<T> where T : MyBaseClass
{
    private T _value;

    public MyClass(T value)
    {
        _value = value;
    }

    public void PrintValue()
    {
        Console.WriteLine(_value.ToString());
    }
}

// Базовый класс для ограничения обобщенного типа данных
public class MyBaseClass
{
    // Код базового класса
}

// Класс-наследник базового класса
public class MyDerivedClass : MyBaseClass
{
    // Код класса-наследника
}

// Класс с конструктором, принимающим два параметра
public class MyClassWithConstructor
{
    public int IntegerValue { get; set; }
    public string StringValue { get; set; }

    public MyClassWithConstructor(int intValue, string strValue)
    {
        IntegerValue = intValue;
        StringValue = strValue;
    }
}

// Тестирование созданных классов
class Program
{
    static void Main(string[] args)
    {
        // Создание объекта класса MyClass с ограниченным обобщенным типом данных
        var myClass = new MyClass<MyDerivedClass>(new MyDerivedClass());
        myClass.PrintValue();

        // Создание объекта класса MyClassWithConstructor
        var myClassWithConstructor = new MyClassWithConstructor(42, "Hello, world!");
        Console.WriteLine("Integer value: " + myClassWithConstructor.IntegerValue);
        Console.WriteLine("String value: " + myClassWithConstructor.StringValue);
    }
}