using System;
using System.Text;

class MyClass
{
    public int MyIntProperty { get; set; }
    public string MyStringProperty { get; set; }

    public MyClass(int myInt, string myString)
    {
        MyIntProperty = myInt;
        MyStringProperty = myString;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Введите размерность массива: ");
        int size = int.Parse(Console.ReadLine());

        MyClass[] myArray = new MyClass[size];
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {
            myArray[i] = new MyClass(rnd.Next(100), "строка " + i);
        }

        foreach (var item in myArray)
        {
            Console.WriteLine($"MyIntProperty: {item.MyIntProperty}, MyStringProperty: {item.MyStringProperty}");
        }

        Console.ReadKey();
    }
}