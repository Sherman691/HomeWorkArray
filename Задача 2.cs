using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
            int sizeArray = 10;
            int lot = 0;
            int numberArrayMin = -10;
            int numberArrayMax = 11;

            Random random = new Random();
            int[] array = new int[sizeArray];

            for (int i = 0; i < sizeArray; i++)
            {
                if (numberArrayMax != 0)
                array[i] = random.Next(numberArrayMin, numberArrayMax);
                else
                    array[i] = random.Next();
            }
                
            for (int i = 0; i < sizeArray; i++)
                Console.Write(array[i] + " ");

            Console.WriteLine();

            for(int i= 0; i < sizeArray; i++)
            {
                if (array[i] % 2 == 0)
                    lot++;
            }
            Console.Write($"Колличество четных чисел в массиве => {lot}");
            Console.WriteLine();
        }
    }
}
