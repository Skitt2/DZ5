using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:");
            Console.Write("целочисленное значение N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = random.Next(0, 2);
                    Console.Write("{0,2}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
