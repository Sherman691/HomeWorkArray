using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.Найдите количество элементов массива, значения которых лежат в отрезке[20, 90].
            int sizeArray = 10;
            int numberArrayMin = 1;
            int numberArrayMax = 101;
            int lowerRange = 20;
            int upperRange = 90;
            int lot = 0;


            Random random = new Random();
            int[] array = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
                array[i] = random.Next(numberArrayMin, numberArrayMax);
            for (int i = 0; i < sizeArray; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();

            for (int i=0; i < sizeArray; i++)
            {
                if (array[i] >= lowerRange && array[i] <= upperRange)
                {
                    lot++;
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write($"Колличество чисел принадлежащих диапазону [{lowerRange}, {upperRange}] равно {lot}");
            Console.WriteLine();
        }
    }
}
