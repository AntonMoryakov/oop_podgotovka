using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exzoop5
{
    class MyClass<T>
    {
        public void DisplayDataType()
        {
            Console.WriteLine($"Type of data used: {typeof(T).Name}");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass<int> intClass = new MyClass<int>();
            intClass.DisplayDataType();

            MyClass<string> stringClass = new MyClass<string>();
            stringClass.DisplayDataType();
        }
    }
}
