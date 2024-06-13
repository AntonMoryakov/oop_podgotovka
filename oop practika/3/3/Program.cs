using System;
using System.Text;

abstract class MyBaseClass
{
    public virtual void VirtualMethod()
    {
        Console.WriteLine("Вызван виртуальный метод базового класса");
    }

    public abstract void AbstractMethod();
}

class MyDerivedClass : MyBaseClass
{
    public override void VirtualMethod()
    {
        Console.WriteLine("Вызван переопределенный виртуальный метод");
    }

    public override void AbstractMethod()
    {
        Console.WriteLine("Вызван переопределенный абстрактный метод");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        MyDerivedClass myObj = new MyDerivedClass();
        myObj.VirtualMethod();
        myObj.AbstractMethod();

        Console.ReadKey();
    }
}