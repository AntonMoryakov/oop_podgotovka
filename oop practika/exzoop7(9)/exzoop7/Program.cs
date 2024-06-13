using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exzoop7
{
    class Program
    {
        delegate void MyDelegate1(int a, string b, bool c);
        delegate int MyDelegate2(int[] a, double b);

        static void Main(string[] args)
        {
            // Создаем объекты делегатов и передаем им ссылки на методы
            MyDelegate1 del1 = Method1;
            MyDelegate2 del2 = Method2;

            // Вызываем методы, связанные с делегатами
            del1.Invoke(10, "hello", true);
            int result = del2.Invoke(new int[] { 1, 2, 3 }, 2.5);
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }

        static void Method1(int a, string b, bool c)
        {
            Console.WriteLine($"Method1: a = {a}, b = {b}, c = {c}");
        }

        static int Method2(int[] a, double b)
        {
            int sum = 0;
            foreach (int num in a)
            {
                sum += num;
            }
            return (int)(sum * b);
        }
    }
}
/*В данном примере мы объявляем два делегата MyDelegate1 и MyDelegate2, которые могут хранить ссылки на методы с соответствующими сигнатурами.

Затем мы создаем объекты делегатов и передаем им ссылки на методы Method1 и Method2.

Далее вызываем эти методы, используя Invoke или краткую форму записи, передавая им необходимые аргументы.

Метод Method1 просто выводит на консоль полученные значения параметров.

Метод Method2 вычисляет сумму элементов массива, умноженную на второй аргумент метода, и возвращает результат.*/