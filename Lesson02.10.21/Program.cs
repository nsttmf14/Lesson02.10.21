using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
    
    namespace Lesson02._10._21
{
    class Program
    {
        public static void SquareEquation(int a, int b, int c)//задание1
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("дискриминант < 0, измените коэффициенты");
            }
            else if (discriminant == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1} (дискриминант = 0)");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
        }
        public static int Arraynew(ref int multiplication, out int SredArifm, params int[] integers)//задание5
        {
            int sum = 0;
            for (int i = 0; i < integers.Length; i++) //сумма элементов массива
                sum += integers[i];

            multiplication = integers[0];
            for (int i = 1; i < integers.Length; i++) //произведение элементов массива
                multiplication *= integers[i];
            SredArifm = sum / integers.Length; //среднее арифметическое элементов массива
            Console.Write("Произведение элементов массива: " + multiplication + "\nСреднее арифметическое элементов массива: " + SredArifm + "\nСумма элементов массива: ");
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Введите коэффициенты уравнения");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            SquareEquation(a, b, c);

            Console.WriteLine("\nTask 2");
            int element1, element2, index1, index2, save;
            Random random = new Random();
            int[] randomarray = new int[20];
            for (int i = 0; i < 20; i++)
                randomarray[i] = random.Next(0, 100);
            Console.WriteLine(string.Join(", ", randomarray));
            Console.Write("Введите первый элемент массива: ");
            element1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второй элемент массива: ");
            element2 = Convert.ToInt32(Console.ReadLine());
            index1 = Array.IndexOf(randomarray, element1);
            index2 = Array.IndexOf(randomarray, element2);
            save = randomarray[index1];
            randomarray[index1] = randomarray[index2];
            randomarray[index2] = save;
            Console.WriteLine(string.Join(", ", randomarray));

            Console.WriteLine("\nTask 3");//отсортируем массив по возрастанию
            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[n];
            for (int i = 0; i < n; i++)
                array2[i] = random.Next(0, 100);
            Console.WriteLine("массив: " + string.Join(", ", array2));
            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array2[k] < array2[j])
                    {
                        int saver = array2[k];
                        array2[k] = array2[j];
                        array2[j] = saver;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", array2));

            Console.WriteLine("\nTask 4");
            int multiplication = 0, SredArifm;
            Console.Write("Введите длину массива: ");
            int order = Convert.ToInt32(Console.ReadLine());
            int[] array3 = new int[order];
            for (int l = 0; l < order; l++)
            {
                Console.Write($"Введите элемент {l + 1}: ");
                array3[l] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", array3));
            Console.WriteLine(Arraynew(ref multiplication, out SredArifm, array3));

            Console.WriteLine("\nTask 5");
            try
            {
                start:
                Console.Write("Введите цифру: ");
                string number =Console.ReadLine();
                if (number == "exit" || number == "закрыть")
                    Environment.Exit(0);
                int intnumber = Convert.ToInt32(number);
                switch (intnumber)
                {
                    case 1: 
                        Console.WriteLine("\n##\n #\n #\n #\n###"); 
                        goto start;
                    case 2: 
                        Console.WriteLine("\n###\n  #\n  #\n #\n#\n###");
                        goto start;
                    case 3:
                        Console.WriteLine("\n ##\n#  #\n   #\n  #\n   #\n#  #\n ##");
                        goto start;
                    case 4: 
                        Console.WriteLine("\n#  #\n#  #\n#  #\n####\n   #\n   #\n   #");
                        goto start;
                    case 5: 
                        Console.WriteLine("\n####\n#\n#\n ##\n   #\n   #\n###");
                        goto start;
                    case 6: 
                        Console.WriteLine("\n ##\n#  #\n#\n###\n#  #\n#  #\n ##");
                        goto start;
                    case 7: 
                        Console.WriteLine("\n####\n   #\n   #\n  #\n  #\n #\n #");
                        goto start;
                    case 8:
                        Console.WriteLine("\n ##\n#  #\n#  #\n ##\n#  #\n#  #\n ##");
                        goto start;
                    case 9: 
                        Console.WriteLine("\n ##\n#  #\n#  #\n ###\n   #\n   #\n ##");
                        goto start;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                        Thread.Sleep(3000);
                        Console.WriteLine("Ошибка: введено неправильное число.");
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка: введены некорректные данные.");
            }


            Console.ReadKey();

        }
       
    }
    }

