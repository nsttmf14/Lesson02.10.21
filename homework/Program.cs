using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.Write("Введите длину массива: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < array.Length; ++i) //заполнение массива
            {
                Console.Write($"a[{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Отсортированный массив: " + string.Join(", ", QuickSort(array)));

            Console.ReadKey();
        }
        static void Change(ref int first, ref int second) //обмен элементов массива
        {
            int save = first;
            first = second;
            second = save;
        }
        static int findindex(int[] array, int minIndex, int maxIndex) //метод для определения индекса опорного элемента
        {
            int main = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    main++;
                    Change(ref array[main], ref array[i]);
                }
            }
            main++;
            Change(ref array[main], ref array[maxIndex]);
            return main;
        }
        static int[] QuickSort(int[] array) //преобразование для метода ниже
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        static int[] QuickSort(int[] array, int minIndex, int maxIndex) //Quick sort
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            var pivotIndex = findindex(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }
        static void asd(ref int a)
        {
            a += 2;
            Console.WriteLine(a);
        }
    }
    }

