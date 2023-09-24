using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_1
{
    internal class Program
    {
        static void Main(string[] args) // Нахождение суммы массива
        {
            int n = 3; //кол-во элементов в массиве
            int[] a = new int[n]; //объявление массива
            string str;//вспомог. переменная
            int i;//вспомог. переменная
            a[0] = 1;//элементы массива
            a[1] = -8;
            a[2] = 14;

            int sum = 0;//обнуляем сумму

            for (i = 0; i < n; i++)//перебираем элементы и прибавляем их к sum
            {
                sum += a[i];
            }
            str = "Сумма массива равна " + sum;
            Console.WriteLine(str);//вывод на экран результата
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
