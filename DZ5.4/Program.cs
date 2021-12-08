using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество   нечетных положительных элементов, стоящих на четных местах.");
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,3} ", array[i]);
                if (array[i] > 0 && array[i] % 2 > 0 && i % 2 == 0)
                {
                    s++;
                    //Console.Write("(место {0})", i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах {0}", s);
            Console.ReadKey();
        }
    }
}
