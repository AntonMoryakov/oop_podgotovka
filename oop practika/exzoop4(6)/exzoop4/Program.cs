using System;

namespace exzoop4
{


    class MyClass
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public static MyClass operator +(MyClass obj1, MyClass obj2)
        {
            return new MyClass
            {
                Value1 = obj1.Value1 + obj2.Value1,
                Value2 = obj1.Value2 + obj2.Value2
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var obj1 = new MyClass { Value1 = rnd.Next(1,100), Value2 = rnd.Next(1, 100) };
            var obj2 = new MyClass { Value1 = rnd.Next(1, 100), Value2 = rnd.Next(1, 100) };
            Console.WriteLine($"{obj1.Value1},{obj1.Value2}");
            Console.WriteLine($"{obj2.Value1},{obj2.Value2}");


            var result = obj1 + obj2;

            Console.WriteLine($"Value1: {result.Value1}, Value2: {result.Value2}");

            Console.ReadKey();
        }
    }
}

