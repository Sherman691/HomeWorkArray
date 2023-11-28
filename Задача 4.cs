using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000.
            //Создайте массив, состоящий из цифр этого числа.
            //Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
            //Размер массива должен быть равен количеству цифр.

            Console.Write("Введите число от 1 до 100 000: ");
            int customNumber = Convert.ToInt32(Console.ReadLine());

            string str = customNumber.ToString();
            int[] array = new int[customNumber];

            for (int i = 0; i < customNumber; i++)
            {
                array[i] = int.Parse(str[i].ToString());                
                Console.Write(array[i] + " ");
            }

            



        }
    }
}
