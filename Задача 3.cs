using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива
            int sizeArray = 10;
            int numberArrayMin = 1;
            int numberArrayMax = 10;
            //double numberMin = 0;
            double numberMin = 0;

            Random random = new Random();
            double[] array = new double[sizeArray];


            for (int i = 0; i < sizeArray; i++)
                array[i] = Math.Round(random.Next(numberArrayMin, numberArrayMax) + random.NextDouble(),2);
            for (int i = 0; i < sizeArray; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();

            for (int i = 0; i <sizeArray; i++)
            {
                for (int j = 0; j < sizeArray - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        numberMin = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = numberMin;
                    }
                }
            }
            //for (int i = 0; i < sizeArray; i++)
            //Console.Write(array[i] + " ");

            Console.WriteLine();

            Console.WriteLine($"Разнаци между максимальным эллементом массива ({array[sizeArray - 1]}) и минимальным эллементом массива ({array[0]}), равна: {array[sizeArray-1] - array[0]}");

            

            

        }
    }
}
