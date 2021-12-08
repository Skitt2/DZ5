using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.");
            Console.Write("целочисленное значение N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = Convert.ToInt32(Console.Read());
                    //Console.Write("{0,4}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
