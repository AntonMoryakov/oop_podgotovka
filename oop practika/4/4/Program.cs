using System;
class MyClass
{
    public int IntProperty1 { get; set; }
    public int IntProperty2 { get; set; }

    public MyClass(int int1, int int2)
    {
        IntProperty1 = int1;
        IntProperty2 = int2;
    }

    public static MyClass operator +(MyClass obj1, MyClass obj2)
    {
        return new MyClass(obj1.IntProperty1 + obj2.IntProperty1, obj1.IntProperty2 + obj2.IntProperty2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj1 = new MyClass(1, 2);
        MyClass obj2 = new MyClass(3, 4);
        MyClass result = obj1 + obj2;
        Console.WriteLine($"Результат: {result.IntProperty1}, {result.IntProperty2}");

        Console.ReadKey();
    }
}