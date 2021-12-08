using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов");
            int[] array = new int[7];
            float sum = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.WriteLine("Cреднее арифметическое элементов равно {0:f2}", sum / 7);
            Console.ReadKey();
        }

    }
}
