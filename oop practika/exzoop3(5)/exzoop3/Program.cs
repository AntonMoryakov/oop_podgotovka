using System;

namespace exzoop3
{
    abstract class MyClass
    {
        public abstract void MyAbstractMethod();
        public virtual void MyVirtualMethod()
        {
            Console.WriteLine("This is the base virtual method.");
        }
    }

    class MyDerivedClass : MyClass
    {
        public override void MyAbstractMethod()
        {
            Console.WriteLine("Переопределённый абстрактный метод.");
        }

        public override void MyVirtualMethod()
        {
            Console.WriteLine("Переопределённый виртуальный метод.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass myDerivedObj = new MyDerivedClass();
            myDerivedObj.MyAbstractMethod(); // Вызов переопределенного абстрактного метода
            myDerivedObj.MyVirtualMethod(); // Вызов переопределенного виртуального метода
            Console.ReadKey();
        }
    }
}
