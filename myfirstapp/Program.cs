﻿namespace myfirstapp
{
    // class and methods
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C#!");

            var sum1 = StaticSum(6, 7);
            Console.WriteLine("sum1 = " + sum1);

            var test = MyFirstClass.MyFirstMethod(6, 9);
            Console.WriteLine(test);

            var MyClass = new MyFirstClass();
            var sum3 = MyClass.MySecondMethod(21, 7);
            Console.WriteLine(sum3);

            WriteLineCustomString("Void method");
            WriteLineHelloCSharp();

            var factorial = Fact(5);
            Console.WriteLine("factorial = " + factorial);

            var weather = MyIFClassBase.MyIFMethod(null);
            Console.WriteLine("Weather: " + weather);

            var coloroftheday = MyIFClassBase.MySWITCHMethod(null);
            Console.WriteLine($"Cvet nastroeniya " + coloroftheday);

            for (var i = 0; i < 20; i += 2)
            {
                Console.WriteLine(i + "*" + i + "=" + (i*i));
            }

            //for (var j = 0; j < 20; j++)
            //{
            //    if (j == 15)
            //    {
            //        Console.WriteLine("THIS IS 15... and continue!");
            //        continue;
            //    }
            //    Console.WriteLine(j + "*" + j + "=" + (j * j));
            //}

            for (var j = 0; j < 20; j++)
            {
                if (j == 15)
                {
                    Console.WriteLine("THIS IS 15... and break!");
                    break;
                }
                Console.WriteLine(j + "*" + j + "=" + (j * j));
            }

            Console.WriteLine("This is start");
            goto CHECKUP_GOTO;

            Console.WriteLine("Ahahahah!");

        CHECKUP_GOTO:
            Console.WriteLine("This is the end!");


        }

        public static int StaticSum(int a, int b)
        {
            var sum = a + b;

            return sum;
        }
        
        public static void WriteLineCustomString(string s)
        {
            Console.WriteLine(s);
        }

        public static void WriteLineHelloCSharp()
        {
            Console.WriteLine("Hello, CSharp!");
        }

        public static int Fact(int n)
        {
            if (n == 1)
                return 1;

            return n * Fact(n - 1);
        }

    }

    public class MyFirstClass
    {
        public static int MyFirstMethod(int a, int b)
        {
            Console.WriteLine("test new class and method");

            var sum2 = a + b + 1;

            return sum2;
        }

        public int MySecondMethod(int a, int b)
        {
            Console.WriteLine("this is the second class");

            var sum = a + b + 1;

            return sum;
        }

    }

}
