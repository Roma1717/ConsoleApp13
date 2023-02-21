using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Найти максимальный элемент одномерного массива и его индекс.
            //int[] array = { -3, 4, 0, 18, 9, -2, 11 };
            //int max = -3;
            //int indexMax = 0;
            //for(int i=1;i<array.Length;i++)
            //{
            //    if (array[i]>max)
            //    {
            //        max = array[i];
            //        indexMax = i;
            //    }
            //}
            //Console.WriteLine("$max={ max}\tindexMax={ indexMax} ");
            //Console.Read();
            //Найти минимальный элемнт и его индекс
            //int[] array = { -3, 4, 0, 18, 9, -2, 11 };
            //int min = -3;
            //int indexMin = 0;
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > min)
            //    {
            //        min = array[i];
            //        indexMin = i;
            //    }
            //}
            //Console.WriteLine("$max={min}\tindexMin={ indexMin} ");
            //Console.Read();
            //Задание 2
            //int n;
            //Console.Write("Введите размерность массива : ");
            //n = Convert.ToInt32(Console.ReadLine());
            //Random rand = new Random();
            //int[] arr = new int[n];
            //int max = arr[0], min = arr[0], indexMin = 0, indexMax = 0, b;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(-10, 10);
            //    Console.WriteLine(arr[i]);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        indexMax = i;
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        indexMin = i;
            //    }
            //}
            //b = arr[indexMax];
            //arr[indexMax] = arr[indexMin];
            //arr[indexMin] = b;
            //Console.WriteLine();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"arr[{i}] = {arr[i]}");
            //}
            //Задание 3
            {
                int[] arr = new int[] { 5, 2, 7, 3, 9, 1, 8, 6, 4 };
                int min = 0;
                int max = 0;

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[min])
                    {
                        min = i;
                    }
                    if (arr[i] > arr[max])
                    {
                        max = i;
                    }
                }

                int start = Math.Min(min, max) + 1;
                int end = Math.Max(min, max);
                int count = end - start;

                Console.WriteLine($"Максимальный элемент: {arr[max]}");
                Console.WriteLine($"Минимальный элемент: {arr[min]}");
                Console.WriteLine($"Количество элементов между ними: {count}");
                Console.ReadKey();
            }
        }

    }
}

