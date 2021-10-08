using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs5
{
    class Program
    {
        public static void Max(int x, int y)//задание 5.1(большее число)
        {
            if (x > y)
                Console.WriteLine($"{x} > {y}");
            else if (x == y)
                Console.WriteLine($"{y} = {x}");
            else
                Console.WriteLine($"{y} < {x}");
        }
        public static void changes(ref int a, ref int b)//задание 5.2(перемещение)
        {
            int save = a;
            a = b;
            b = save;
            Console.WriteLine($"a = {a}, b = {b}");
        }
        public static bool Factorial(ref int n)//задание 5.3(факториал)
        {
            try
            {
                int multiplication = 1;
                for (int i = 1; i < (n + 1); i++)
                {
                    checked
                    {
                        multiplication *= i;
                    }
                }
                Console.WriteLine("Факториал, полученный после вычислений: " + multiplication);
                return true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Произошло переполнение стека!");
                return false;
            }
        }
        public static int recursivefactorial(int number)//функция вызывает сама себя
        {
            if (number == 0)

                return 1;
            else
                
                return number * recursivefactorial(number - 1);//происходит рекурсивный спуск
        }
        public static int NOD(int thesmallestfirst, int thesmallestsecond)
        {
            while ((thesmallestfirst != 0) && (thesmallestsecond != 0))
            {
                if (thesmallestfirst > thesmallestsecond)

                    thesmallestfirst -= thesmallestsecond;
                else
                    thesmallestsecond -= thesmallestfirst;
            }
            return Math.Max(thesmallestfirst, thesmallestsecond);
        }
        public static int Fib(int n)//последующие числа равны сумме двух предыдущих
        {
            int sum = 0;
            if (n <= 1)
                return n;
            int[] integers = new int[n];
            sum = Fib(n - 2) + Fib(n - 1);
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5.1");
            Console.WriteLine("Введите числа и программа вернет большее из них");
            Console.Write("1 число: ");
            int digit1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2 число: ");
            int digit2 = Convert.ToInt32(Console.ReadLine());
            Max(digit1, digit2);


            Console.WriteLine("\nTask 5.2");
            try
            {
                Console.WriteLine("Введите числа и программа поменяет их местами");
                Console.Write("a = ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("b = ");
                int second = Convert.ToInt32(Console.ReadLine());
                changes(ref first, ref second);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введена строка!Введите число!");
            }

            Console.WriteLine("\nTask 5.3");
            Console.Write("Введите число для вычисления факториала:");
            int factorial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(ref factorial));

            Console.WriteLine("\nTask 5.4");
            Console.Write("Введите число для вычисления факториала:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Факториал вычислен: " + recursivefactorial(number));

            Console.WriteLine("\nHomeTask 5.1");
            Console.Write("Введите 1 число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("НОД для введенных чисел = " + NOD(num1, num2));

            Console.WriteLine("\nHomeTask 5.2");
            Console.Write("Введите номер числа Фибоначии: ");
            int numberFib = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число Фибоначчи: " + Fib(numberFib - 1));

            Console.ReadKey();
        }
        
    }
    }

