using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2_3
{
    internal class Program
    {
        static void Main(string[] args) //Создание динамического массива
        {
            double[] a = new double[] { -8, 13, 26, 14, 17, 21, -34, 28 }; //объявляем новый массив и сразу вносим значения
            int n = a.Length;//n=кол-во элементов
            string str;//вспомог. переменная
            int i;//вспомог. переменная
            double sum = 0;//Обнуляем сумму
            for (i = 0; i < n; i++)//выводим на экран каждый элемент массива
            {
                Console.WriteLine(a[i]);
                sum += a[i];
            }
            double avg;
            avg = sum / n;//высчитываем среднее арифм
            str = "Сумма массива равна " + sum + "\nСреднее арифметическое массива равно  " + avg;
            Console.WriteLine(str);//вывод суммы и среднего арифм.
            Console.WriteLine("Нажмите любую кнопку!");
            Console.ReadKey();
        }
    }
}
