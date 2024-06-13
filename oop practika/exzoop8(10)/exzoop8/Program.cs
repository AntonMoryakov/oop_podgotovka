using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exzoop8
{
    interface IMyInterface
    {
        void Method1();
        void Method2();
        void Method3();
    }

    // Класс, являющийся наследником интерфейса и реализующий его методы
    class MyClass : IMyInterface
    {
        public void Method1()
        {
            Console.WriteLine("Вызван метод 1");
        }

        public void Method2()
        {
            Console.WriteLine("Вызван метод 2");
        }

        public void Method3()
        {
            Console.WriteLine("Вызван метод 3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса MyClass
            MyClass myObject = new MyClass();

            // Присваивание ссылки на объект MyClass интерфейсной переменной
            IMyInterface myInterface = myObject;

            // Вызов методов через интерфейсную ссылку
            myInterface.Method1();
            myInterface.Method2();
            myInterface.Method3();

            Console.ReadKey();
        }
    }
}

/*В данном примере определен интерфейс IMyInterface, который содержит три метода.
 * Затем создан класс MyClass, который является наследником интерфейса и реализует все его методы.

Далее в методе Main создается объект класса MyClass, после чего создается интерфейсная переменная myInterface, 
которая присваивается ссылкой на объект myObject. Затем через эту переменную вызываются методы объекта класса MyClass.*/