using System;

namespace exzoop2
{
    class MyClass
    {
        public string MyStringProperty { get; set; }
        public bool MyBoolProperty { get; set; }

        public MyClass(string myString, bool myBool)
        {
            MyStringProperty = myString;
            MyBoolProperty = myBool;
        }
    }

    class MyDerivedClass : MyClass
    {
        public MyDerivedClass(string myString, bool myBool) : base(myString, myBool)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int size = int.Parse(Console.ReadLine());

            MyDerivedClass[] array1 = new MyDerivedClass[size];
            MyDerivedClass[] array2 = new MyDerivedClass[size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                array1[i] = new MyDerivedClass($"Строка {i}", random.Next(2) == 0);
                array2[i] = new MyDerivedClass($"Строка {i}", random.Next(2) == 0);
               
            }

            int falseCount1 = 0;
            foreach (var element in array1)
            {
                if (!element.MyBoolProperty)
                {
                    falseCount1++;
                }
            }

            int falseCount2 = 0;
            foreach (var element in array2)
            {
                if (!element.MyBoolProperty)
                {
                    falseCount2++;
                }
            }
            Console.WriteLine("Элементы первого массива:");
            foreach (var element in array1)
            {
                Console.WriteLine($" {element.MyStringProperty}, {element.MyBoolProperty}");
            }

            Console.WriteLine("Элементы второго массива:");
            foreach (var element in array2)
            {
                Console.WriteLine($" {element.MyStringProperty}, {element.MyBoolProperty}");
            }

            Console.WriteLine($"Количество элементов со значением false в первом массиве: {falseCount1}");
            Console.WriteLine($"Количество элементов со значением false во втором массиве: {falseCount2}");

            if (falseCount1 > falseCount2)
            {
                Console.WriteLine("В первом массиве чаще встречается значение false");
            }
            else if (falseCount1 < falseCount2)
            {
                Console.WriteLine("Во втором массиве чаще встречается значение false");
            }
            else
            {
                Console.WriteLine("Количество элементов со значением false в обоих массивах одинаково");
            }

            Console.ReadLine();
        }
    }
}

