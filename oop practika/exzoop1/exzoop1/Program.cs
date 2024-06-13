using System;

namespace ConsoleApp
{
    class MyClass
    {
        public int MyInt { get; set; }
        public string MyString { get; set; }

        public MyClass(int myInt, string myString)
        {
            MyInt = myInt;
            MyString = myString;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());

            MyClass[] array = new MyClass[n];

            Random random = new Random();


            for (int i = 0; i < n; i++)
            {
                int myInt = random.Next(1, 100);
                // string myString = " строка #" + (i + 1);
                int charCode = random.Next((int)'a', (int)'z' + 1);
                char randomChar = (char)charCode;
                string myString = randomChar.ToString();

                array[i] = new MyClass(myInt, myString);
            }

            Console.WriteLine("Элементы массива:");

            foreach (MyClass item in array)
            {
                Console.WriteLine($"MyInt: {item.MyInt}, MyString: {item.MyString}");
            }

            Console.ReadKey();
        }
    }
}
