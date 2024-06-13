using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exzoop6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass<MyDerivedClass> myClass = new MyClass<MyDerivedClass>();
            myClass.MyProperty = new MyDerivedClass(42, "hello");

            Console.WriteLine($"MyProperty: {myClass.MyProperty}");

            Console.ReadLine();
        }
    }

    public class MyClass<T> where T : MyBaseClass
    {
        public T MyProperty { get; set; }
    }

    public class MyBaseClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass(int myIntProperty, string myStringProperty)
        {
            MyIntProperty = myIntProperty;
            MyStringProperty = myStringProperty;
        }

        public override string ToString()
        {
            return $"MyIntProperty: {MyIntProperty}, MyStringProperty: {MyStringProperty}";
        }
    }
}
