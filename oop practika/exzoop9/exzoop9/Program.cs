using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exzoop9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyEvent += MyEventHandler;
            myClass.InvokeMyEvent(10);
            myClass.MyEvent -= MyEventHandler;
            Console.ReadKey();
        }

        private static void MyEventHandler(int arg)
        {
            Console.WriteLine($"Метод с аргументом {arg} подписался на событие.");
        }
    }

    class MyClass
    {
        public delegate void MyDelegate(int arg);

        public event MyDelegate MyEvent;

        public void InvokeMyEvent(int arg)
        {
            MyEvent?.Invoke(arg);
        }
    }
}
/*Здесь мы объявляем класс MyClass, который содержит событие MyEvent типа делегата MyDelegate,
 * имеющего сигнатуру void (int). Также у нас есть метод InvokeMyEvent, который вызывает событие, если оно не равно null.

Затем мы создаем метод MyEventHandler, который будет вызываться каждый раз,
когда какой-либо метод подписывается на событие или отписывается от него.

В методе Main мы создаем экземпляр класса MyClass и подписываемся на событие,
вызываем его и затем отписываемся от него. Каждый раз, когда мы подписываемся или отписываемся от события, в консоль выводится информация.

При запуске программы на консоль будет выведено сообщение о том,
что метод с аргументом 42 подписался на событие. После нажатия любой клавиши программа завершится.*/