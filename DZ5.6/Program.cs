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
            Console.WriteLine("Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:");
            Console.WriteLine("Введите размер матрицы");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, n];
            int sumD1 = 0;
            int sumD2 = 0;
            int sumG1 = 0;
            int sumG2 = 0;
            int sumV1 = 0;
            int sumV2 = 0;
            bool f = false;
            Console.WriteLine("Заполни матрицу");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", mas[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                    {
                        sumD1 += mas[i, j];
                    }
                    if (j == n - (i + 1))
                    {
                        sumD2 += mas[i, j];
                    }
                    sumG1 += mas[i, j];

                    if (sumG2 != sumG1 && j == n - 1 && i > 0)
                    {
                        f = true;
                        break;
                    }
                }
                sumG2 = sumG1;
                sumG1 = 0;
            }
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    sumV1 += mas[i, j];

                    if (sumV2 != sumV1 && i == n - 1 && j > 0)
                    {
                        f = true;
                        break;
                    }
                }
                sumV2 = sumV1;
                sumV1 = 0;
            }
            if (sumD1 == sumD2 && sumG2 == sumV2 && sumD2 == sumG2 && f == false)
            {
                Console.WriteLine("матрица является магическим квадратом");
            }
            else
            {
                Console.WriteLine("матрица не является магическим квадратом");
            }
            Console.ReadKey();
        }
    }
}
