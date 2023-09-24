using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_4
{
    internal class Program
    {
        static void Main(string[] args) //Многомерные массива (Герберт Шилдт)
        {
            int t, i; //вспомог. переменные
            int[,] table = new int[3, 4]; //Объявление двумерного массива
            for (t = 0; t < 3; ++t)//вывод массива в столбик, не матрица
            {
                for (i = 0; i < 4; ++i)
                {
                    table[t, i] = (t * 4) + i + 1;
                    Console.WriteLine(table[t, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
